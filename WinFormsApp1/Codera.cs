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
        private string photoPath = string.Empty;
        private PrintDocument printDocument = new PrintDocument();
        private Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold);
        private Font headingFont = new Font("Segoe UI", 14, FontStyle.Bold);
        private Font normalFont = new Font("Segoe UI", 11, FontStyle.Regular);
        private Font italicFont = new Font("Segoe UI", 11, FontStyle.Italic);
        private int yPos = 0;
        private Button btnBack;
        private ErrorProvider errorProvider;

        public Codera()
        {
            InitializeComponent();
            InitializeBackButton();
            SetupValidation();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void Codera_Load(object sender, EventArgs e)
        {
            cmbProficiency.SelectedIndex = 0;

            listViewEducation.Columns[0].Width = 300;
            listViewEducation.Columns[1].Width = 300;
            listViewEducation.Columns[2].Width = 100;

            listViewExperience.Columns[0].Width = 150;
            listViewExperience.Columns[1].Width = 150;
            listViewExperience.Columns[2].Width = 150;
            listViewExperience.Columns[3].Width = 200;

            listViewSkills.Columns[0].Width = 400;
            listViewSkills.Columns[1].Width = 200;

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
                FlatAppearance = { BorderSize = 1 },
                BackColor = Color.FromArgb(45, 52, 70),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Size = new Size(80, 30),
                Location = new Point(10, 8),
                Cursor = Cursors.Hand,
                Visible = true
            };

            btnBack.Click += BtnBack_Click;
            headerPanel.Controls.Add(btnBack);
            btnBack.BringToFront();
        }

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

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a profile picture";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                        if (fileInfo.Length > 2 * 1024 * 1024)
                        {
                            MessageBox.Show("Image size must be less than 2MB.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        photoPath = openFileDialog.FileName;
                        pictureBoxPhoto.Image = Image.FromFile(photoPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

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
                throw new Exception("Name must contain only letters, spaces, hyphens, apostrophes, or periods.");
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !ValidateEmailFormat(txtEmail.Text))
            {
                throw new Exception("Please enter a valid email address.");
            }

            if (!string.IsNullOrWhiteSpace(txtPhone.Text) && !ValidatePhoneFormat(txtPhone.Text))
            {
                throw new Exception("Please enter a valid phone number.");
            }
        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInstitution.Text) ||
                string.IsNullOrWhiteSpace(txtDegree.Text) ||
                string.IsNullOrWhiteSpace(txtGradYear.Text))
            {
                MessageBox.Show("Please fill in all education fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateNameFormat(txtInstitution.Text))
            {
                MessageBox.Show("Institution name must contain only letters, no numbers.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateYearFormat(txtGradYear.Text))
            {
                MessageBox.Show("Please enter a valid graduation year (4 digits).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(txtInstitution.Text);
            item.SubItems.Add(txtDegree.Text);
            item.SubItems.Add(txtGradYear.Text);
            listViewEducation.Items.Add(item);

            txtInstitution.Clear();
            txtDegree.Clear();
            txtGradYear.Clear();
            txtInstitution.Focus();
        }

        private void btnAddExperience_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompany.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtStartDate.Text))
            {
                MessageBox.Show("Please fill in all required work experience fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateNameFormat(txtCompany.Text))
            {
                MessageBox.Show("Company name must contain only letters, no numbers.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateNameFormat(txtPosition.Text))
            {
                MessageBox.Show("Position must contain only letters, no numbers.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateDateFormat(txtStartDate.Text))
            {
                MessageBox.Show("Please enter start date in MM/YYYY format (e.g., 01/2020).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEndDate.Text) && !ValidateDateFormat(txtEndDate.Text))
            {
                MessageBox.Show("Please enter end date in MM/YYYY format (e.g., 01/2022).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string duration = txtStartDate.Text + " - " + (string.IsNullOrWhiteSpace(txtEndDate.Text) ? "Present" : txtEndDate.Text);

            ListViewItem item = new ListViewItem(txtCompany.Text);
            item.SubItems.Add(txtPosition.Text);
            item.SubItems.Add(duration);
            item.SubItems.Add(txtJobDescription.Text);
            listViewExperience.Items.Add(item);

            txtCompany.Clear();
            txtPosition.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtJobDescription.Clear();
            txtCompany.Focus();
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSkill.Text))
            {
                MessageBox.Show("Please enter a skill.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in listViewSkills.Items)
            {
                if (item.Text.Equals(txtSkill.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This skill has already been added.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(txtSkill.Text);
            newItem.SubItems.Add(cmbProficiency.SelectedItem.ToString());
            listViewSkills.Items.Add(newItem);

            txtSkill.Clear();
            cmbProficiency.SelectedIndex = 0;
            txtSkill.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            pictureBoxPhoto.Image = null;
            photoPath = string.Empty;

            listViewEducation.Items.Clear();
            listViewExperience.Items.Clear();
            listViewSkills.Items.Clear();

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

            txtFullName.Focus();

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

                DialogResult result = MessageBox.Show("Would you like to preview the CV before printing?",
                    "Preview CV", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PreviewCV();
                }
                else if (result == DialogResult.No)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating CV: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int width = e.MarginBounds.Width;

            yPos = topMargin;

            g.DrawString("CURRICULUM VITAE", titleFont, Brushes.Navy, leftMargin, yPos);
            yPos += 40;

            g.DrawLine(new Pen(Color.Gray, 1), leftMargin, yPos, leftMargin + width, yPos);
            yPos += 20;

            g.DrawString("PERSONAL INFORMATION", headingFont, Brushes.Navy, leftMargin, yPos);
            yPos += 25;

            g.DrawString($"Name: {txtFullName.Text}", normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;

            if (!string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                g.DrawString($"Address: {txtAddress.Text}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }

            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                g.DrawString($"Phone: {txtPhone.Text}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                g.DrawString($"Email: {txtEmail.Text}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }

            if (pictureBoxPhoto.Image != null)
            {
                int photoX = leftMargin + width - 100;
                int photoY = topMargin + 40;

                g.DrawImage(pictureBoxPhoto.Image, new Rectangle(photoX, photoY, 100, 120));
            }

            yPos += 20;

            if (listViewEducation.Items.Count > 0)
            {
                g.DrawString("EDUCATION", headingFont, Brushes.Navy, leftMargin, yPos);
                yPos += 25;

                foreach (ListViewItem item in listViewEducation.Items)
                {
                    g.DrawString($"{item.SubItems[0].Text}", normalFont, Brushes.Black, leftMargin, yPos);
                    yPos += 20;
                    g.DrawString($"{item.SubItems[1].Text} ({item.SubItems[2].Text})", italicFont, Brushes.Black, leftMargin + 10, yPos);
                    yPos += 25;
                }

                yPos += 10;
            }

            if (listViewExperience.Items.Count > 0)
            {
                g.DrawString("WORK EXPERIENCE", headingFont, Brushes.Navy, leftMargin, yPos);
                yPos += 25;

                foreach (ListViewItem item in listViewExperience.Items)
                {
                    g.DrawString($"{item.SubItems[0].Text} - {item.SubItems[1].Text}", normalFont, Brushes.Black, leftMargin, yPos);
                    yPos += 20;
                    g.DrawString($"{item.SubItems[2].Text}", italicFont, Brushes.Black, leftMargin + 10, yPos);
                    yPos += 20;

                    if (!string.IsNullOrWhiteSpace(item.SubItems[3].Text))
                    {
                        RectangleF rect = new RectangleF(leftMargin + 10, yPos, width - 20, 1000);
                        SizeF size = g.MeasureString(item.SubItems[3].Text, normalFont, width - 20);
                        g.DrawString(item.SubItems[3].Text, normalFont, Brushes.Black, rect);
                        yPos += (int)size.Height + 5;
                    }

                    yPos += 10;
                }

                yPos += 10;
            }

            if (listViewSkills.Items.Count > 0)
            {
                g.DrawString("SKILLS", headingFont, Brushes.Navy, leftMargin, yPos);
                yPos += 25;

                foreach (ListViewItem item in listViewSkills.Items)
                {
                    g.DrawString($"• {item.SubItems[0].Text} - {item.SubItems[1].Text}", normalFont, Brushes.Black, leftMargin, yPos);
                    yPos += 20;
                }
            }

            int footerY = e.MarginBounds.Bottom - 20;
            g.DrawString($"Generated on {DateTime.Now.ToShortDateString()}", new Font("Arial", 8), Brushes.Gray, leftMargin, footerY);
        }

        private void PreviewCV()
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

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

        private void ApplyModernColorScheme()
        {
            Color primaryColor = Color.FromArgb(41, 128, 185);

            Color accentColor = Color.FromArgb(46, 204, 113);

            Color lightBgColor = Color.FromArgb(245, 247, 250);

            headerPanel.BackColor = primaryColor;
            btnGenerateCV.BackColor = accentColor;
            btnGenerateCV.ForeColor = Color.White;

            contentPanel.BackColor = lightBgColor;
        }

        private void AddSectionDividers()
        {
            Panel divider1 = new Panel
            {
                Height = 1,
                BackColor = Color.FromArgb(200, 200, 200),
                Dock = DockStyle.None,
                Width = 660,
                Location = new Point(20, 195)
            };
            contentPanel.Controls.Add(divider1);

        }

        private void EnhanceFormFields()
        {
            SetPlaceholderText(txtFullName, "e.g., Ivann Codera");
            SetPlaceholderText(txtEmail, "e.g., ivann@example.com");

            btnGenerateCV.FlatStyle = FlatStyle.Flat;
            btnGenerateCV.FlatAppearance.BorderSize = 0;

        }

        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
