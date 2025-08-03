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
        private Font titleFont = new Font("Arial", 16, FontStyle.Bold);
        private Font headingFont = new Font("Arial", 12, FontStyle.Bold);
        private Font normalFont = new Font("Arial", 10, FontStyle.Regular);
        private Font italicFont = new Font("Arial", 10, FontStyle.Italic);
        private int yPos = 0;

        public Codera()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void Codera_Load(object sender, EventArgs e)
        {
            // Initialize the form
            cmbProficiency.SelectedIndex = 0;
            
            // Set up list view columns
            listViewEducation.Columns[0].Width = 300;
            listViewEducation.Columns[1].Width = 300;
            listViewEducation.Columns[2].Width = 100;
            
            listViewExperience.Columns[0].Width = 150;
            listViewExperience.Columns[1].Width = 150;
            listViewExperience.Columns[2].Width = 150;
            listViewExperience.Columns[3].Width = 300;
            
            listViewSkills.Columns[0].Width = 400;
            listViewSkills.Columns[1].Width = 200;
            
            // Add tooltips to explain validation requirements
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtEmail, "Enter a valid email address (e.g., name@example.com)");
            toolTip.SetToolTip(txtPhone, "Enter a valid phone number (e.g., 123-456-7890)");
            toolTip.SetToolTip(txtGradYear, "Enter a valid year (e.g., 2020)");
            toolTip.SetToolTip(txtStartDate, "Enter date in MM/YYYY format");
            toolTip.SetToolTip(txtEndDate, "Enter date in MM/YYYY format or leave blank for 'Present'");
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
                        // Validate image size (max 2MB)
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

        private bool ValidateEmailFormat(string email)
        {
            // Simple regex for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool ValidatePhoneFormat(string phone)
        {
            // Allow various phone formats
            string pattern = @"^(\+\d{1,3}[-\s]?)?\(?\d{3}\)?[-\s]?\d{3}[-\s]?\d{4}$";
            return Regex.IsMatch(phone, pattern);
        }

        private bool ValidateYearFormat(string year)
        {
            // Year should be 4 digits and reasonable (between 1900 and current year + 10)
            if (!Regex.IsMatch(year, @"^\d{4}$"))
                return false;

            int yearValue = int.Parse(year);
            return yearValue >= 1900 && yearValue <= DateTime.Now.Year + 10;
        }

        private bool ValidateDateFormat(string date)
        {
            // Date should be in MM/YYYY format
            return Regex.IsMatch(date, @"^(0[1-9]|1[0-2])\/\d{4}$");
        }

        private void ValidatePersonalInfo()
        {
            // Validate email if provided
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !ValidateEmailFormat(txtEmail.Text))
            {
                throw new Exception("Please enter a valid email address.");
            }

            // Validate phone if provided
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

            // Validate graduation year
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

            // Clear fields after adding
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

            // Validate start date format
            if (!ValidateDateFormat(txtStartDate.Text))
            {
                MessageBox.Show("Please enter start date in MM/YYYY format (e.g., 01/2020).", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate end date format if provided
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

            // Clear fields after adding
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

            // Check if the skill already exists
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

            // Clear fields after adding
            txtSkill.Clear();
            cmbProficiency.SelectedIndex = 0;
            txtSkill.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear personal information
            txtFullName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            pictureBoxPhoto.Image = null;
            photoPath = string.Empty;

            // Clear lists
            listViewEducation.Items.Clear();
            listViewExperience.Items.Clear();
            listViewSkills.Items.Clear();

            // Clear input fields
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

            // Focus on the first field
            tabControl.SelectedIndex = 0;
            txtFullName.Focus();
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
                // Validate personal information
                ValidatePersonalInfo();

                // Ask user if they want to preview or print directly
                DialogResult result = MessageBox.Show("Would you like to preview the CV before printing?", 
                    "Preview CV", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Show preview
                    PreviewCV();
                }
                else if (result == DialogResult.No)
                {
                    // Show print dialog
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print();
                        MessageBox.Show("CV printed successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // If Cancel, do nothing
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating CV: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get the graphics object
            Graphics g = e.Graphics;
            
            // Set margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int width = e.MarginBounds.Width;
            
            // Reset Y position
            yPos = topMargin;
            
            // Print header
            g.DrawString("CURRICULUM VITAE", titleFont, Brushes.Navy, leftMargin, yPos);
            yPos += 40;
            
            // Print horizontal line
            g.DrawLine(new Pen(Color.Gray, 1), leftMargin, yPos, leftMargin + width, yPos);
            yPos += 20;
            
            // Print personal information
            g.DrawString("PERSONAL INFORMATION", headingFont, Brushes.Navy, leftMargin, yPos);
            yPos += 25;
            
            // Print name
            g.DrawString($"Name: {txtFullName.Text}", normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            
            // Print address if provided
            if (!string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                g.DrawString($"Address: {txtAddress.Text}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }
            
            // Print phone if provided
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                g.DrawString($"Phone: {txtPhone.Text}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }
            
            // Print email if provided
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                g.DrawString($"Email: {txtEmail.Text}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }
            
            // Add photo if available
            if (pictureBoxPhoto.Image != null)
            {
                // Calculate position for photo (right side)
                int photoX = leftMargin + width - 100;
                int photoY = topMargin + 40;
                
                // Draw photo
                g.DrawImage(pictureBoxPhoto.Image, new Rectangle(photoX, photoY, 100, 120));
            }
            
            yPos += 20;
            
            // Print education section if available
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
            
            // Print work experience section if available
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
                        // Wrap long descriptions
                        RectangleF rect = new RectangleF(leftMargin + 10, yPos, width - 20, 1000);
                        SizeF size = g.MeasureString(item.SubItems[3].Text, normalFont, width - 20);
                        g.DrawString(item.SubItems[3].Text, normalFont, Brushes.Black, rect);
                        yPos += (int)size.Height + 5;
                    }
                    
                    yPos += 10;
                }
                
                yPos += 10;
            }
            
            // Print skills section if available
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
            
            // Add footer with date
            int footerY = e.MarginBounds.Bottom - 20;
            g.DrawString($"Generated on {DateTime.Now.ToShortDateString()}", new Font("Arial", 8), Brushes.Gray, leftMargin, footerY);
        }

        // Method to preview the CV before printing
        private void PreviewCV()
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}
