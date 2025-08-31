using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WinFormsApp1
{
    public partial class Codera : Form
    {
        #region Fields
        private string photoPath = string.Empty;
        private PrintDocument printDocument = new PrintDocument();

        // Fonts
        private readonly Font titleFont = new Font("Arial", 16, FontStyle.Bold);
        private readonly Font headingFont = new Font("Arial", 12, FontStyle.Bold);
        private readonly Font normalFont = new Font("Arial", 10, FontStyle.Regular);
        private readonly Font italicFont = new Font("Arial", 10, FontStyle.Italic);

        private int yPos = 0;
        private ErrorProvider errorProvider;
        #endregion

        #region Initialization
        public Codera()
        {
            InitializeComponent();
            // Remove this line:
            // InitializeBackButton();
            SetupValidation();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void Codera_Load(object sender, EventArgs e)
        {
            InitializeControls();
            SetupTooltips();
        }

        private void InitializeControls()
        {
            cmbProficiency.SelectedIndex = 0;

            // Configure column widths
            ConfigureListViewColumns();
        }

        private void ConfigureListViewColumns()
        {
            // Education columns
            listViewEducation.Columns[0].Width = 300;
            listViewEducation.Columns[1].Width = 300;
            listViewEducation.Columns[2].Width = 100;

            // Experience columns
            listViewExperience.Columns[0].Width = 150;
            listViewExperience.Columns[1].Width = 150;
            listViewExperience.Columns[2].Width = 150;
            listViewExperience.Columns[3].Width = 200;

            // Skills columns
            listViewSkills.Columns[0].Width = 400;
            listViewSkills.Columns[1].Width = 200;
        }

        private void SetupTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtFullName, "Enter your full name (letters only, no numbers)");
            toolTip.SetToolTip(txtEmail, "Enter a valid email address (e.g., name@example.com)");
            toolTip.SetToolTip(txtPhone, "Enter a valid phone number (e.g., 123-456-7890)");
            toolTip.SetToolTip(txtGradYear, "Enter a valid year (e.g., 2020)");
            toolTip.SetToolTip(txtStartDate, "Enter date in MM/YYYY format");
            toolTip.SetToolTip(txtEndDate, "Enter date in MM/YYYY format or leave blank for 'Present'");
        }

        private void SetupValidation()
        {
            txtFullName.TextChanged += TxtFullName_TextChanged;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            txtGradYear.TextChanged += TxtGradYear_TextChanged;
            txtStartDate.TextChanged += TxtStartDate_TextChanged;
            txtEndDate.TextChanged += TxtEndDate_TextChanged;
            txtInstitution.TextChanged += TxtInstitution_TextChanged;
            txtCompany.TextChanged += TxtCompany_TextChanged;
            txtPosition.TextChanged += TxtPosition_TextChanged;

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void InitializeBackButton()
        {
            btnBack = new Button
            {
                Text = "← Back",
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                BackColor = Color.FromArgb(45, 52, 70),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Size = new Size(80, 30),
                Location = new Point(10, 10),
                Cursor = Cursors.Hand
            };

            btnBack.Click += BtnBack_Click;
            headerPanel.Controls.Add(btnBack);
            btnBack.BringToFront();
        }
        #endregion

        #region Navigation
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (HasUnsavedData())
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Are you sure you want to go back?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            this.Close();
        }

        private bool HasUnsavedData()
        {
            return !string.IsNullOrWhiteSpace(txtFullName.Text) ||
                   !string.IsNullOrWhiteSpace(txtAddress.Text) ||
                   !string.IsNullOrWhiteSpace(txtPhone.Text) ||
                   !string.IsNullOrWhiteSpace(txtEmail.Text) ||
                   pictureBoxPhoto.Image != null ||
                   listViewEducation.Items.Count > 0 ||
                   listViewExperience.Items.Count > 0 ||
                   listViewSkills.Items.Count > 0;
        }
        #endregion

        #region Photo Management
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a profile picture";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TryLoadImage(openFileDialog.FileName);
                }
            }
        }

        private void TryLoadImage(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                const int maxSizeInBytes = 2 * 1024 * 1024; // 2MB

                if (fileInfo.Length > maxSizeInBytes)
                {
                    MessageBox.Show("Image size must be less than 2MB.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                photoPath = filePath;
                pictureBoxPhoto.Image = Image.FromFile(photoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Validation
        private bool ValidateNameFormat(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z\s\-'.]+$");
        }

        private bool ValidateEmailFormat(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool ValidatePhoneFormat(string phone)
        {
            string pattern = @"^(\+\d{1,3}[-\s]?)?\(?\d{3}\)?[-\s]?\d{3}[-\s]?\d{4}$";
            return Regex.IsMatch(phone, pattern);
        }

        private bool ValidateYearFormat(string year)
        {
            if (!Regex.IsMatch(year, @"^\d{4}$"))
                return false;

            int yearValue = int.Parse(year);
            return yearValue >= 1900 && yearValue <= DateTime.Now.Year + 10;
        }

        private bool ValidateDateFormat(string date)
        {
            return Regex.IsMatch(date, @"^(0[1-9]|1[0-2])\/\d{4}$");
        }

        private void ValidatePersonalInfo()
        {
            if (!ValidateNameFormat(txtFullName.Text))
            {
                throw new Exception("Name must contain only letters, no numbers");
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !ValidateEmailFormat(txtEmail.Text))
            {
                throw new Exception("Please enter a valid email address");
            }

            if (!string.IsNullOrWhiteSpace(txtPhone.Text) && !ValidatePhoneFormat(txtPhone.Text))
            {
                throw new Exception("Please enter a valid phone number");
            }
        }
        #endregion

        #region Education Management
        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (!ValidateEducationInputs())
                return;

            AddEducationToList();
            ClearEducationFields();
        }

        private bool ValidateEducationInputs()
        {
            if (string.IsNullOrWhiteSpace(txtInstitution.Text) ||
                string.IsNullOrWhiteSpace(txtDegree.Text) ||
                string.IsNullOrWhiteSpace(txtGradYear.Text))
            {
                MessageBox.Show("Please fill in all education fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateNameFormat(txtInstitution.Text))
            {
                MessageBox.Show("Institution name must contain only letters, no numbers.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateYearFormat(txtGradYear.Text))
            {
                MessageBox.Show("Please enter a valid graduation year (4 digits).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AddEducationToList()
        {
            ListViewItem item = new ListViewItem(txtInstitution.Text);
            item.SubItems.Add(txtDegree.Text);
            item.SubItems.Add(txtGradYear.Text);
            listViewEducation.Items.Add(item);
        }

        private void ClearEducationFields()
        {
            txtInstitution.Clear();
            txtDegree.Clear();
            txtGradYear.Clear();
            txtInstitution.Focus();
        }
        #endregion

        #region Experience Management   
        private void btnAddExperience_Click(object sender, EventArgs e)
        {
            if (!ValidateExperienceInputs())
                return;

            AddExperienceToList();
            ClearExperienceFields();
        }

        private bool ValidateExperienceInputs()
        {
            if (string.IsNullOrWhiteSpace(txtCompany.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtStartDate.Text))
            {
                MessageBox.Show("Please fill in all required work experience fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateNameFormat(txtCompany.Text))
            {
                MessageBox.Show("Company name must contain only letters, no numbers.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateNameFormat(txtPosition.Text))
            {
                MessageBox.Show("Position must contain only letters, no numbers.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateDateFormat(txtStartDate.Text))
            {
                MessageBox.Show("Please enter start date in MM/YYYY format (e.g., 01/2020).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEndDate.Text) && !ValidateDateFormat(txtEndDate.Text))
            {
                MessageBox.Show("Please enter end date in MM/YYYY format (e.g., 01/2022).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AddExperienceToList()
        {
            string duration = txtStartDate.Text + " - " + (string.IsNullOrWhiteSpace(txtEndDate.Text) ? "Present" : txtEndDate.Text);

            ListViewItem item = new ListViewItem(txtCompany.Text);
            item.SubItems.Add(txtPosition.Text);
            item.SubItems.Add(duration);
            item.SubItems.Add(txtJobDescription.Text);
            listViewExperience.Items.Add(item);
        }

        private void ClearExperienceFields()
        {
            txtCompany.Clear();
            txtPosition.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtJobDescription.Clear();
            txtCompany.Focus();
        }
        #endregion

        #region Skills Management
        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if (!ValidateSkillInputs())
                return;

            AddSkillToList();
            ClearSkillFields();
        }

        private bool ValidateSkillInputs()
        {
            if (string.IsNullOrWhiteSpace(txtSkill.Text))
            {
                MessageBox.Show("Please enter a skill.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (ListViewItem item in listViewSkills.Items)
            {
                if (item.Text.Equals(txtSkill.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This skill has already been added.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void AddSkillToList()
        {
            ListViewItem newItem = new ListViewItem(txtSkill.Text);
            newItem.SubItems.Add(cmbProficiency.SelectedItem.ToString());
            listViewSkills.Items.Add(newItem);
        }

        private void ClearSkillFields()
        {
            txtSkill.Clear();
            cmbProficiency.SelectedIndex = 0;
            txtSkill.Focus();
        }
        #endregion

        #region Form Actions
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            // Clear personal information
            txtFullName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            pictureBoxPhoto.Image = null;
            photoPath = string.Empty;

            // Clear all list views
            listViewEducation.Items.Clear();
            listViewExperience.Items.Clear();
            listViewSkills.Items.Clear();

            // Clear all other form fields
            txtInstitution.Clear();
            txtDegree.Clear();
            txtGradYear.Clear();
            txtCompany.Clear();
            txtPosition.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtJobDescription.Clear();
            txtSkill.Clear();
            cmbProficiency.SelectedIndex = 0;

            // Set focus to the first field
            txtFullName.Focus();

            // Scroll the content panel to the top
            contentPanel.AutoScrollPosition = new Point(0, 0);
        }

        private void btnGenerateCV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter at least your full name to generate a CV.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ValidatePersonalInfo();
                HandleCVGeneration();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating CV: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleCVGeneration()
        {
            DialogResult result = MessageBox.Show("Would you like to preview the CV before printing?",
                "Preview CV", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PreviewCV();
            }
            else if (result == DialogResult.No)
            {
                PrintCV();
            }
        }

        private void PrintCV()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
                MessageBox.Show("CV printed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PreviewCV()
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        #endregion

        #region CV Printing
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int width = e.MarginBounds.Width;

            yPos = topMargin;

            PrintCVHeader(g, leftMargin, width);
            PrintPersonalInfo(g, leftMargin, width, topMargin); // Pass topMargin parameter
            PrintEducation(g, leftMargin, width);
            PrintWorkExperience(g, leftMargin, width);
            PrintSkills(g, leftMargin, width);
            PrintFooter(g, leftMargin, e.MarginBounds.Bottom);
        }

        private void PrintCVHeader(Graphics g, int leftMargin, int width)
        {
            // Change title text or formatting
            g.DrawString("PROFESSIONAL RESUME", titleFont, Brushes.DarkBlue, leftMargin, yPos);
            yPos += 40;

            // Change header separator line style
            g.DrawLine(new Pen(Color.Navy, 2), leftMargin, yPos, leftMargin + width, yPos);
            yPos += 20;
        }

        private void PrintPersonalInfo(Graphics g, int leftMargin, int width, int topMargin)
        {
            // Change section title
            g.DrawString("ABOUT ME", headingFont, Brushes.DarkBlue, leftMargin, yPos);
            yPos += 25;

            // Create a two-column layout for contact info
            int midPoint = leftMargin + (width / 2);
            
            // Left column
            g.DrawString($"Name: {txtFullName.Text}", normalFont, Brushes.Black, leftMargin, yPos);
            
            // Right column (if email exists)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                g.DrawString($"Email: {txtEmail.Text}", normalFont, Brushes.Black, midPoint, yPos);
            }
            yPos += 20;

            // Next row
            if (!string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                g.DrawString($"Address: {txtAddress.Text}", normalFont, Brushes.Black, leftMargin, yPos);
                
                if (!string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    g.DrawString($"Phone: {txtPhone.Text}", normalFont, Brushes.Black, midPoint, yPos);
                }
                yPos += 20;
            }
            else if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                g.DrawString($"Phone: {txtPhone.Text}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }

            // Photo positioning - make it smaller or larger
            if (pictureBoxPhoto.Image != null)
            {
                int photoX = leftMargin + width - 120; // Adjust position
                int photoY = topMargin + 50; // Adjust position
                int photoSize = 110; // Adjust size

                g.DrawImage(pictureBoxPhoto.Image, new Rectangle(photoX, photoY, photoSize, photoSize));
            }

            yPos += 20;
        }

        private void PrintEducation(Graphics g, int leftMargin, int width)
        {
            if (listViewEducation.Items.Count <= 0)
                return;
            
            // Change section title styling
            g.DrawString("ACADEMIC BACKGROUND", headingFont, Brushes.DarkBlue, leftMargin, yPos);
            yPos += 25;
            
            // Add a thin line under the section title
            g.DrawLine(new Pen(Color.LightGray, 1), leftMargin, yPos - 5, leftMargin + width - 150, yPos - 5);

            foreach (ListViewItem item in listViewEducation.Items)
            {
                // Use bold font for institution name
                g.DrawString($"{item.SubItems[0].Text}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
                yPos += 20;
                
                // Add degree with graduation year in italics
                g.DrawString($"{item.SubItems[1].Text} ({item.SubItems[2].Text})", italicFont, Brushes.DarkSlateGray, leftMargin + 15, yPos);
                yPos += 25;
            }

            yPos += 10;
        }

        private void PrintWorkExperience(Graphics g, int leftMargin, int width)
        {
            if (listViewExperience.Items.Count <= 0)
                return;
                
            // Change section title
            g.DrawString("PROFESSIONAL EXPERIENCE", headingFont, Brushes.DarkBlue, leftMargin, yPos);
            yPos += 25;
            
            // Add a thin line under the section title
            g.DrawLine(new Pen(Color.LightGray, 1), leftMargin, yPos - 5, leftMargin + width - 150, yPos - 5);

            foreach (ListViewItem item in listViewExperience.Items)
            {
                // Make company name bold
                Font companyFont = new Font("Arial", 10, FontStyle.Bold);
                g.DrawString($"{item.SubItems[0].Text}", companyFont, Brushes.Black, leftMargin, yPos);
                
                // Right-align the duration
                SizeF durationSize = g.MeasureString(item.SubItems[2].Text, italicFont);
                g.DrawString(item.SubItems[2].Text, italicFont, Brushes.DarkGray, 
                    leftMargin + width - durationSize.Width - 20, yPos);
                
                yPos += 20;
                
                // Make position title emphasized
                g.DrawString($"{item.SubItems[1].Text}", new Font("Arial", 10, FontStyle.Italic), 
                    Brushes.DarkSlateGray, leftMargin + 15, yPos);
                yPos += 20;

                if (!string.IsNullOrWhiteSpace(item.SubItems[3].Text))
                {
                    // Format description with bullet point
                    string description = "• " + item.SubItems[3].Text;
                    RectangleF rect = new RectangleF(leftMargin + 15, yPos, width - 35, 1000);
                    SizeF size = g.MeasureString(description, normalFont, width - 35);
                    g.DrawString(description, normalFont, Brushes.Black, rect);
                    yPos += (int)size.Height + 5;
                }

                yPos += 10;
            }

            yPos += 10;
        }

        private void PrintSkills(Graphics g, int leftMargin, int width)
        {
            if (listViewSkills.Items.Count <= 0)
                return;
                
            g.DrawString("TECHNICAL SKILLS", headingFont, Brushes.DarkBlue, leftMargin, yPos);
            yPos += 25;
            
            // Add a thin line under the section title
            g.DrawLine(new Pen(Color.LightGray, 1), leftMargin, yPos - 5, leftMargin + width - 150, yPos - 5);

            // Create a two-column layout for skills
            int columnWidth = (width - 40) / 2;
            int rightColumnStart = leftMargin + columnWidth + 20;
            int originalYPos = yPos;
            int itemCount = listViewSkills.Items.Count;
            int leftColumnItems = (itemCount + 1) / 2; // Split items evenly

            // Print left column
            for (int i = 0; i < leftColumnItems && i < itemCount; i++)
            {
                ListViewItem item = listViewSkills.Items[i];
                g.DrawString($"• {item.SubItems[0].Text} - {item.SubItems[1].Text}", 
                    normalFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }

            // Reset Y position for right column
            yPos = originalYPos;
            
            // Print right column
            for (int i = leftColumnItems; i < itemCount; i++)
            {
                ListViewItem item = listViewSkills.Items[i];
                g.DrawString($"• {item.SubItems[0].Text} - {item.SubItems[1].Text}", 
                    normalFont, Brushes.Black, rightColumnStart, yPos);
                yPos += 20;
            }

            // Set yPos to the end of the longer column
            if (itemCount > leftColumnItems)
            {
                // Both columns have items
                int rightColumnHeight = (itemCount - leftColumnItems) * 20;
                int leftColumnHeight = leftColumnItems * 20;
                yPos = originalYPos + Math.Max(rightColumnHeight, leftColumnHeight);
            }
        }

        private void PrintFooter(Graphics g, int leftMargin, int bottomMargin)
        {
            // Add a line above the footer
            g.DrawLine(new Pen(Color.LightGray, 1), leftMargin, bottomMargin - 30, 
                leftMargin + g.VisibleClipBounds.Width - 80, bottomMargin - 30);
            
            // Generate timestamp
            string timestamp = $"Generated on {DateTime.Now.ToString("MMMM d, yyyy")}";
            Font footerFont = new Font("Arial", 8, FontStyle.Italic);
            
            // Center the footer text
            SizeF footerSize = g.MeasureString(timestamp, footerFont);
            float centerX = leftMargin + (g.VisibleClipBounds.Width - footerSize.Width) / 2;
            
            g.DrawString(timestamp, footerFont, Brushes.Gray, centerX, bottomMargin - 20);
        }
        #endregion

        #region Validation Event Handlers
        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFullName.Text) && !ValidateNameFormat(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Name must contain only letters, no numbers");
            }
            else
            {
                errorProvider.SetError(txtFullName, "");
            }
        }

        private void TxtInstitution_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtInstitution.Text) && !ValidateNameFormat(txtInstitution.Text))
            {
                errorProvider.SetError(txtInstitution, "Institution name must contain only letters, no numbers");
            }
            else
            {
                errorProvider.SetError(txtInstitution, "");
            }
        }

        private void TxtCompany_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCompany.Text) && !ValidateNameFormat(txtCompany.Text))
            {
                errorProvider.SetError(txtCompany, "Company name must contain only letters, no numbers");
            }
            else
            {
                errorProvider.SetError(txtCompany, "");
            }
        }

        private void TxtPosition_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPosition.Text) && !ValidateNameFormat(txtPosition.Text))
            {
                errorProvider.SetError(txtPosition, "Position must contain only letters, no numbers");
            }
            else
            {
                errorProvider.SetError(txtPosition, "");
            }
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !ValidateEmailFormat(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Please enter a valid email address");
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPhone.Text) && !ValidatePhoneFormat(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Please enter a valid phone number");
            }
            else
            {
                errorProvider.SetError(txtPhone, "");
            }
        }

        private void TxtGradYear_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGradYear.Text) && !ValidateYearFormat(txtGradYear.Text))
            {
                errorProvider.SetError(txtGradYear, "Please enter a valid year (4 digits)");
            }
            else
            {
                errorProvider.SetError(txtGradYear, "");
            }
        }

        private void TxtStartDate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStartDate.Text) && !ValidateDateFormat(txtStartDate.Text))
            {
                errorProvider.SetError(txtStartDate, "Please enter date in MM/YYYY format");
            }
            else
            {
                errorProvider.SetError(txtStartDate, "");
            }
        }

        private void TxtEndDate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEndDate.Text) && !ValidateDateFormat(txtEndDate.Text))
            {
                errorProvider.SetError(txtEndDate, "Please enter date in MM/YYYY format");
            }
            else
            {
                errorProvider.SetError(txtEndDate, "");
            }
        }
        #endregion

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrawSectionHeader(Graphics g, string title, int leftMargin, int width)
        {
            // Draw section title
            g.DrawString(title, headingFont, Brushes.DarkBlue, leftMargin, yPos);
            yPos += 25;
            
            // Draw separator line
            g.DrawLine(new Pen(Color.LightGray, 1), leftMargin, yPos - 5, leftMargin + width - 150, yPos - 5);
        }

    }
}