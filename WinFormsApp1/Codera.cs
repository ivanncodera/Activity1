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

        // Date picker controls
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private CheckBox checkBoxPresent;

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
            SetupDateValidation();
        }

        private void InitializeControls()
        {
            cmbProficiency.SelectedIndex = 0;

            // Configure date pickers for easier date entry
            ConfigureDatePickers();

            // Configure column widths
            ConfigureListViewColumns();
        }

        private void ConfigureDatePickers()
        {
            // If txtStartDate and txtEndDate are TextBoxes, hide them and add MonthCalendar controls
            // Add these variables to the Fields region if you implement this approach
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();

            // Configure start date picker
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MM/yyyy";
            dateTimePickerStart.ShowUpDown = true;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerStart.Location = new Point(txtStartDate.Location.X, txtStartDate.Location.Y);
            dateTimePickerStart.Size = txtStartDate.Size;
            dateTimePickerStart.ValueChanged += (s, e) => {
                txtStartDate.Text = dateTimePickerStart.Value.ToString("MM/yyyy");
                
                // Automatically update end date if it would be invalid
                if (dateTimePickerEnd.Value < dateTimePickerStart.Value && !checkBoxPresent.Checked)
                {
                    dateTimePickerEnd.Value = dateTimePickerStart.Value;
                }
            };

            // Configure end date picker
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM/yyyy";
            dateTimePickerEnd.ShowUpDown = true;
            dateTimePickerEnd.Value = DateTime.Now;
            dateTimePickerEnd.Location = new Point(txtEndDate.Location.X, txtEndDate.Location.Y);
            dateTimePickerEnd.Size = txtEndDate.Size;
            dateTimePickerEnd.ValueChanged += (s, e) => {
                // Prevent setting end date before start date
                if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
                {
                    dateTimePickerEnd.Value = dateTimePickerStart.Value;
                }
                txtEndDate.Text = dateTimePickerEnd.Value.ToString("MM/yyyy");
            };

            // Add checkbox for "Present" option
            checkBoxPresent = new CheckBox();
            checkBoxPresent.Text = "Present";
            checkBoxPresent.Location = new Point(dateTimePickerEnd.Right + 10, dateTimePickerEnd.Top);
            checkBoxPresent.CheckedChanged += (s, e) => {
                dateTimePickerEnd.Enabled = !checkBoxPresent.Checked;
                if (checkBoxPresent.Checked)
                    txtEndDate.Text = "Present";
                else
                    txtEndDate.Text = dateTimePickerEnd.Value.ToString("MM/yyyy");
            };

            // Add controls to the form
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(checkBoxPresent);

            // Hide original text boxes or replace their functionality
            // txtStartDate.Visible = false;
            // txtEndDate.Visible = false;
        }

        private void SetupTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtFullName, "Enter your full name (letters only, no numbers)");
            toolTip.SetToolTip(txtEmail, "Enter a valid email address (e.g., name@example.com)");
            toolTip.SetToolTip(txtPhone, "Enter a valid phone number (e.g., 123-456-7890)");
            toolTip.SetToolTip(txtGradYear, "Enter a valid year (e.g., 2020)");
            toolTip.SetToolTip(txtStartDate, "Enter date in MM/YYYY format (e.g., 01/2020 for January 2020)");
            toolTip.SetToolTip(txtEndDate, "Enter date in MM/YYYY format or leave blank for 'Present'");

            // Add tooltips for new date controls if implemented
            if (dateTimePickerStart != null)
            {
                toolTip.SetToolTip(dateTimePickerStart, "Select the start month and year");
                toolTip.SetToolTip(dateTimePickerEnd, "Select the end month and year");
                toolTip.SetToolTip(checkBoxPresent, "Check if this is your current position");
            }
        }

        private void SetupValidation()
        {
            // Create a dictionary to map controls to their validation methods
            var validationMap = new Dictionary<Control, Func<string, bool>>
            {
                { txtFullName, ValidateNameFormat },
                { txtInstitution, ValidateNameFormat },
                { txtCompany, ValidateNameFormat },
                { txtPosition, ValidateNameFormat },
                { txtEmail, ValidateEmailFormat },
                { txtPhone, ValidatePhoneFormat },
                { txtGradYear, ValidateYearFormat },
                { txtStartDate, ValidateDateFormat },
                { txtEndDate, ValidateDateFormat },
                { txtDegree, ValidateDegree },
                { txtJobDescription, ValidateJobDescription },
                { txtSkill, ValidateSkillName },
                { txtAddress, ValidateAddressFormat }
            };

            // Set up error provider
            errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

            // Add event handlers
            foreach (var pair in validationMap)
            {
                var control = pair.Key;
                var validator = pair.Value;
                var errorMessage = GetErrorMessageForControl(control);

                control.TextChanged += (s, e) =>
                {
                    var textBox = s as TextBox;
                    if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text) && !validator(textBox.Text))
                        errorProvider.SetError(textBox, errorMessage);
                    else
                        errorProvider.SetError(textBox, "");
                };
            }
        }

        private string GetErrorMessageForControl(Control control)
        {
            // Return appropriate error message based on control
            if (control == txtFullName || control == txtInstitution ||
                control == txtCompany || control == txtPosition)
                return "Must contain only letters, no numbers";
            else if (control == txtEmail)
                return "Please enter a valid email address";
            else if (control == txtPhone)
                return "Please enter a valid phone number";
            else if (control == txtGradYear)
                return "Please enter a valid year (4 digits)";
            else if (control == txtStartDate || control == txtEndDate)
                return "Please enter date in MM/YYYY format";
            else if (control == txtDegree)
                return "Please enter a valid degree name";
            else if (control == txtJobDescription)
                return "Description is too long (max 500 characters)";
            else if (control == txtSkill)
                return "Please enter a valid skill name";
            else if (control == txtAddress)
                return "Address is too long (max 200 characters)";

            return "";
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
            if (date.Equals("Present", StringComparison.OrdinalIgnoreCase))
                return true;

            return Regex.IsMatch(date, @"^(0[1-9]|1[0-2])\/\d{4}$");
        }

        private bool ValidateDegree(string degree)
        {
            // Validate that degree isn't too long and contains valid characters
            return !string.IsNullOrWhiteSpace(degree) &&
                   degree.Length <= 100 &&
                   Regex.IsMatch(degree, @"^[a-zA-Z0-9\s\-'.(),]+$");
        }

        private bool ValidateSkillName(string skill)
        {
            // Validate that skill name contains valid characters
            return !string.IsNullOrWhiteSpace(skill) &&
                   skill.Length <= 50 &&
                   Regex.IsMatch(skill, @"^[a-zA-Z0-9\s\-'.#+(),]+$");
        }

        private bool ValidateJobDescription(string description)
        {
            // Optional field but if provided should not exceed reasonable length
            return string.IsNullOrWhiteSpace(description) || description.Length <= 500;
        }

        private bool CheckDateOrder(string startDate, string endDate)
        {
            // If end date is "Present" or empty, it's always valid
            if (string.IsNullOrWhiteSpace(endDate) || 
                endDate.Equals("Present", StringComparison.OrdinalIgnoreCase))
                return true;
                
            try
            {
                // Parse MM/YYYY format
                string[] startParts = startDate.Split('/');
                string[] endParts = endDate.Split('/');

                if (startParts.Length != 2 || endParts.Length != 2)
                    return false;

                int startYear = int.Parse(startParts[1]);
                int startMonth = int.Parse(startParts[0]);
                int endYear = int.Parse(endParts[1]);
                int endMonth = int.Parse(endParts[0]);

                // Create DateTime objects for comparison (day is set to 1)
                DateTime startDateTime = new DateTime(startYear, startMonth, 1);
                DateTime endDateTime = new DateTime(endYear, endMonth, 1);

                // Compare dates
                return startDateTime <= endDateTime;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ValidateAddressFormat(string address)
        {
            // Address is optional but if provided should not be too long
            return string.IsNullOrWhiteSpace(address) || address.Length <= 200;
        }

        private void ValidatePersonalInfo()
        {
            // Full name is required
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                throw new Exception("Full name is required");
            }

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

            if (!ValidateAddressFormat(txtAddress.Text))
            {
                throw new Exception("Address is too long (maximum 200 characters)");
            }
        }
        #endregion

        #region Education Management
        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (!ValidateEducationInputs())
                return;

            ListViewItem item = new ListViewItem(txtInstitution.Text);
            item.SubItems.Add(txtDegree.Text);
            item.SubItems.Add(txtGradYear.Text);

            AddItemToList(item, listViewEducation, ClearEducationFields);
        }

        private void ShowValidationError(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool ValidateEducationInputs()
        {
            if (string.IsNullOrWhiteSpace(txtInstitution.Text) ||
                string.IsNullOrWhiteSpace(txtDegree.Text) ||
                string.IsNullOrWhiteSpace(txtGradYear.Text))
            {
                ShowValidationError("Please fill in all education fields.");
                return false;
            }

            if (!ValidateNameFormat(txtInstitution.Text))
            {
                ShowValidationError("Institution name must contain only letters, no numbers.");
                return false;
            }

            if (!ValidateDegree(txtDegree.Text))
            {
                ShowValidationError("Please enter a valid degree name (letters, numbers, and basic punctuation only).");
                return false;
            }

            if (!ValidateYearFormat(txtGradYear.Text))
            {
                ShowValidationError("Please enter a valid graduation year (4 digits).");
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

            // Check that end date is not before start date
            if (!string.IsNullOrWhiteSpace(txtEndDate.Text) && !CheckDateOrder(txtStartDate.Text, txtEndDate.Text))
            {
                MessageBox.Show("End date cannot be before start date.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateJobDescription(txtJobDescription.Text))
            {
                MessageBox.Show("Job description is too long (maximum 500 characters).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AddExperienceToList()
        {
            string startDate = txtStartDate.Text;
            string endDate = txtEndDate.Text;
            string duration = FormatDateRange(startDate, endDate);

            ListViewItem item = new ListViewItem(txtCompany.Text);
            item.SubItems.Add(txtPosition.Text);
            item.SubItems.Add(duration);
            item.SubItems.Add(txtJobDescription.Text);

            // Store original dates in tag for validation/editing
            item.Tag = new string[] { startDate, endDate };

            listViewExperience.Items.Add(item);
        }

        private void ClearExperienceFields()
        {
            txtCompany.Clear();
            txtPosition.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtJobDescription.Clear();

            // Reset date pickers if implemented
            if (dateTimePickerStart != null)
            {
                dateTimePickerStart.Value = DateTime.Now;
                dateTimePickerEnd.Value = DateTime.Now;
                checkBoxPresent.Checked = false;
            }

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

            if (!ValidateSkillName(txtSkill.Text))
            {
                MessageBox.Show("Please enter a valid skill name (max 50 characters, letters, numbers, and basic punctuation only).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (cmbProficiency.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a proficiency level.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
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

            DrawSectionHeader(g, "ACADEMIC BACKGROUND", leftMargin, width);

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

            DrawSectionHeader(g, "PROFESSIONAL EXPERIENCE", leftMargin, width);

            foreach (ListViewItem item in listViewExperience.Items)
            {
                // Make company name bold
                Font companyFont = new Font("Arial", 10, FontStyle.Bold);
                g.DrawString($"{item.SubItems[0].Text}", companyFont, Brushes.Black, leftMargin, yPos);

                // Right-align the duration with improved formatting
                string duration = item.SubItems[2].Text;

                SizeF durationSize = g.MeasureString(duration, italicFont);
                g.DrawString(duration, italicFont, Brushes.DarkGray,
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

            DrawSectionHeader(g, "TECHNICAL SKILLS", leftMargin, width);

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

        private void TxtDegree_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDegree.Text) && !ValidateDegree(txtDegree.Text))
            {
                errorProvider.SetError(txtDegree, "Please enter a valid degree name");
            }
            else
            {
                errorProvider.SetError(txtDegree, "");
            }
        }

        private void TxtJobDescription_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateJobDescription(txtJobDescription.Text))
            {
                errorProvider.SetError(txtJobDescription, "Description is too long (max 500 characters)");
            }
            else
            {
                errorProvider.SetError(txtJobDescription, "");
            }
        }

        private void TxtSkill_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSkill.Text) && !ValidateSkillName(txtSkill.Text))
            {
                errorProvider.SetError(txtSkill, "Please enter a valid skill name");
            }
            else
            {
                errorProvider.SetError(txtSkill, "");
            }
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateAddressFormat(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Address is too long (max 200 characters)");
            }
            else
            {
                errorProvider.SetError(txtAddress, "");
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

        // Create a generic method for adding items to lists
        private void AddItemToList<T>(T item, ListView listView, Action clearFields) where T : ListViewItem
        {
            listView.Items.Add(item);
            clearFields();
        }

        // Modify the FormatDateForDisplay method to show month names instead of numbers
        private string FormatDateForDisplay(string mmyyyyDate)
        {
            if (mmyyyyDate.Equals("Present", StringComparison.OrdinalIgnoreCase))
                return "Present";

            try
            {
                string[] parts = mmyyyyDate.Split('/');
                int month = int.Parse(parts[0]);
                int year = int.Parse(parts[1]);

                return new DateTime(year, month, 1).ToString("MMMM yyyy");
            }
            catch
            {
                return mmyyyyDate; // Return original if parsing fails
            }
        }

        // Add this method for more user-friendly date display
        private string FormatDateRange(string startDate, string endDate)
        {
            string formattedStart = FormatDateForDisplay(startDate);
            string formattedEnd = string.IsNullOrWhiteSpace(endDate) ? "Present" : FormatDateForDisplay(endDate);

            return $"{formattedStart} - {formattedEnd}";
        }

        private void ConfigureListViewColumns()
        {
            // Education columns
            listViewEducation.Columns[0].Width = 300;  // Institution
            listViewEducation.Columns[1].Width = 300;  // Degree
            listViewEducation.Columns[2].Width = 100;  // Year

            // Experience columns
            listViewExperience.Columns[0].Width = 150; // Company
            listViewExperience.Columns[1].Width = 150; // Position
            listViewExperience.Columns[2].Width = 150; // Duration
            listViewExperience.Columns[3].Width = 200; // Description

            // Skills columns
            listViewSkills.Columns[0].Width = 400;     // Skill name
            listViewSkills.Columns[1].Width = 200;     // Proficiency
        }

        private void txtEndDate_TextChanged_1(object sender, EventArgs e)
        {

        }
        // Add this method to fix CS0103: The name 'SetupDateValidation' does not exist in the current context
        private void SetupDateValidation()
        {
            // Attach validation handlers for date fields if needed
            txtStartDate.TextChanged += TxtStartDate_TextChanged;
            txtEndDate.TextChanged += TxtEndDate_TextChanged;
        }
    }
}