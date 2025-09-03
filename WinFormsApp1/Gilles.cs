using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Gilles : Form
    {
        // Add printing components
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        
        public Gilles()
        {
            InitializeComponent();

            // Initialize the printing components
            SetupPrinting();
            
            // Initialize error provider with form as container
            // Don't create a new ErrorProvider since it's already defined in Designer.cs
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            
            // Add validation handlers to input controls
            SetupValidation();
        }
        
        private void SetupValidation()
        {
            // Attach validation events to textboxes
            textBox2.Validating += NameValidating;
            textBox2.Validated += ControlValidated;
            
            textBox1.Validating += PhoneValidating;
            textBox1.Validated += ControlValidated;
            
            textBox4.Validating += EmailValidating;
            textBox4.Validated += ControlValidated;
            
            // Set up validation for rich text boxes
            richTextBox2.TextChanged += RichTextBoxTextChanged;
            richTextBox3.TextChanged += RichTextBoxTextChanged;
            richTextBox4.TextChanged += RichTextBoxTextChanged;
            richTextBox6.TextChanged += RichTextBoxTextChanged;
            
            // Add status validation
            textBox3.Validating += StatusValidating;
            textBox3.Validated += ControlValidated;
        }
        
        private void NameValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Name cannot be empty");
                e.Cancel = true;
            }
            else if (textBox.Text.Length < 2)
            {
                errorProvider.SetError(textBox, "Name must be at least 2 characters");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(textBox.Text, @"^[a-zA-Z\s\-'.]+$"))
            {
                errorProvider.SetError(textBox, "Name contains invalid characters");
                e.Cancel = true;
            }
        }
        
        private void PhoneValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            
            // Only validate if the field is not empty
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^[\d\+\-\(\)\s\.]+$"))
                {
                    errorProvider.SetError(textBox, "Invalid phone number format");
                    e.Cancel = true;
                }
                else if (textBox.Text.Count(c => char.IsDigit(c)) < 10)
                {
                    errorProvider.SetError(textBox, "Phone number should have at least 10 digits");
                    e.Cancel = true;
                }
            }
        }
        
        private void EmailValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            
            // Only validate if the field is not empty
            if (!string.IsNullOrWhiteSpace(textBox.Text) && !Regex.IsMatch(textBox.Text, emailPattern))
            {
                errorProvider.SetError(textBox, "Invalid email format");
                e.Cancel = true;
            }
        }
        
        private void StatusValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            
            // Only validate if the field is not empty
            if (!string.IsNullOrWhiteSpace(textBox.Text) && textBox.Text.Length < 2)
            {
                errorProvider.SetError(textBox, "Status must be at least 2 characters");
                e.Cancel = true;
            }
        }
        
        private void ControlValidated(object sender, EventArgs e)
        {
            // Clear the error when validation succeeds
            errorProvider.SetError((Control)sender, "");
        }
        
        private void RichTextBoxTextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            
            if (richTextBox.Text.Length > 2000) // Only validate max length
            {
                errorProvider.SetError(richTextBox, "Text is too long (max 2000 characters)");
                // Optionally truncate text
                richTextBox.Text = richTextBox.Text.Substring(0, 2000);
                richTextBox.SelectionStart = richTextBox.Text.Length;
            }
            else
            {
                errorProvider.SetError(richTextBox, "");
            }
        }
        
        // Validate all fields before printing or other operations
        private bool ValidateAllFields()
        {
            bool isValid = true;
            
            // Only validate the name field as required
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider.SetError(textBox2, "Name is required");
                isValid = false;
            }
            else
            {
                // Validate name format if it's not empty
                CancelEventArgs args = new CancelEventArgs();
                NameValidating(textBox2, args);
                if (args.Cancel) isValid = false;
            }
            
            // For other fields, only validate them if they're not empty
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                CancelEventArgs args = new CancelEventArgs();
                PhoneValidating(textBox1, args);
                if (args.Cancel) isValid = false;
            }
            
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                CancelEventArgs args = new CancelEventArgs();
                EmailValidating(textBox4, args);
                if (args.Cancel) isValid = false;
            }
            
            return isValid;
        }

        private void SetupPrinting()
        {
            // Create the PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Create the PrintPreviewDialog
            printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                UseAntiAlias = true,
                ShowIcon = false,
                ClientSize = new Size(800, 600)
            };
        }

        private int currentPage = 0;
        private const int maxPagesExpected = 3; // Adjust based on typical CV length

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create fonts with using statements to ensure proper disposal
            using Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            using Font labelFont = new Font("Arial", 12, FontStyle.Bold);
            using Font valueFont = new Font("Arial", 12, FontStyle.Regular);
            
            try
            {
                // Layout variables
                float marginLeft = 100;
                float marginTop = 100;
                float lineHeight = 30;
                float currentY = marginTop;
                float pageHeight = e.MarginBounds.Height;
                currentPage++;
                
                // First page content
                if (currentPage == 1)
                {
                    // Draw photo if available
                    if (pictureBox1.Image != null)
                    {
                        Rectangle imageRect = new Rectangle((int)(marginLeft + 400), (int)marginTop, 120, 150);
                        e.Graphics.DrawImage(pictureBox1.Image, imageRect);
                    }

                    // Draw header
                    e.Graphics.DrawString("CURRICULUM VITAE", headerFont, Brushes.Black, marginLeft, currentY);
                    currentY += lineHeight * 2;

                    // Draw Name
                    e.Graphics.DrawString("Name:", labelFont, Brushes.Black, marginLeft, currentY);
                    e.Graphics.DrawString(textBox2.Text, valueFont, Brushes.Black, marginLeft + 100, currentY);
                    currentY += lineHeight;

                    // Draw Status
                    e.Graphics.DrawString("Status:", labelFont, Brushes.Black, marginLeft, currentY);
                    e.Graphics.DrawString(textBox3.Text, valueFont, Brushes.Black, marginLeft + 100, currentY);
                    currentY += lineHeight;

                    // Draw Contact Info
                    e.Graphics.DrawString("Phone:", labelFont, Brushes.Black, marginLeft, currentY);
                    e.Graphics.DrawString(textBox1.Text, valueFont, Brushes.Black, marginLeft + 100, currentY);
                    currentY += lineHeight;

                    // Draw Email
                    e.Graphics.DrawString("Email:", labelFont, Brushes.Black, marginLeft, currentY);
                    e.Graphics.DrawString(textBox4.Text, valueFont, Brushes.Black, marginLeft + 100, currentY);
                    currentY += lineHeight;

                    // Draw Address
                    e.Graphics.DrawString("Address:", labelFont, Brushes.Black, marginLeft, currentY);
                    e.Graphics.DrawString(textBox5.Text, valueFont, Brushes.Black, marginLeft + 100, currentY);
                    currentY += lineHeight * 1.5f;

                    // Draw About Me section
                    e.Graphics.DrawString("ABOUT ME", labelFont, Brushes.Black, marginLeft, currentY);
                    currentY += lineHeight;
                    e.Graphics.DrawString(richTextBox2.Text, valueFont, Brushes.Black, marginLeft, currentY);
                    currentY += GetTextHeight(richTextBox2.Text, valueFont, e.Graphics, 600) + lineHeight;

                    // Check if we need to continue to next page
                    if (currentY > pageHeight - marginTop)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    // Draw Education section
                    e.Graphics.DrawString("EDUCATION", labelFont, Brushes.Black, marginLeft, currentY);
                    currentY += lineHeight;
                    e.Graphics.DrawString(richTextBox3.Text, valueFont, Brushes.Black, marginLeft, currentY);
                    currentY += GetTextHeight(richTextBox3.Text, valueFont, e.Graphics, 600) + lineHeight;
                    
                    // Check if we need to continue to next page
                    if (currentY > pageHeight - marginTop)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
                
                // Second page content or continuation
                if (currentPage == 2 || (currentPage == 1 && currentY <= pageHeight - marginTop))
                {
                    // If this is page 2, reset the Y position
                    if (currentPage == 2)
                    {
                        currentY = marginTop;
                        
                        // Add page header for continuity
                        e.Graphics.DrawString("CURRICULUM VITAE (Continued)", headerFont, Brushes.Black, marginLeft, currentY);
                        currentY += lineHeight * 2;
                    }
                    
                    // Only draw these sections if we haven't already on page 1
                    if (currentPage == 2 || (currentPage == 1 && currentY > marginTop + lineHeight * 2))
                    {
                        // Draw Experience section
                        e.Graphics.DrawString("EXPERIENCE", labelFont, Brushes.Black, marginLeft, currentY);
                        currentY += lineHeight;
                        e.Graphics.DrawString(richTextBox4.Text, valueFont, Brushes.Black, marginLeft, currentY);
                        currentY += GetTextHeight(richTextBox4.Text, valueFont, e.Graphics, 600) + lineHeight;
                        
                        // Check if we need to continue to next page
                        if (currentY > pageHeight - marginTop)
                        {
                            e.HasMorePages = true;
                            return;
                        }
                        
                        // Draw Skills section
                        e.Graphics.DrawString("SKILLS", labelFont, Brushes.Black, marginLeft, currentY);
                        currentY += lineHeight;
                        e.Graphics.DrawString(richTextBox6.Text, valueFont, Brushes.Black, marginLeft, currentY);
                        currentY += GetTextHeight(richTextBox6.Text, valueFont, e.Graphics, 600) + lineHeight;
                        
                        // Check if we need to continue to next page
                        if (currentY > pageHeight - marginTop)
                        {
                            e.HasMorePages = true;
                            return;
                        }
                    }
                }
                
                // Third page content or continuation
                if (currentPage == 3 || (currentPage <= 2 && currentY <= pageHeight - marginTop))
                {
                    // If this is page 3, reset the Y position
                    if (currentPage == 3)
                    {
                        currentY = marginTop;
                        
                        // Add page header for continuity
                        e.Graphics.DrawString("CURRICULUM VITAE (Continued)", headerFont, Brushes.Black, marginLeft, currentY);
                        currentY += lineHeight * 2;
                    }
                    
                    // Draw References section
                    e.Graphics.DrawString("REFERENCES", labelFont, Brushes.Black, marginLeft, currentY);
                    currentY += lineHeight;
                    e.Graphics.DrawString(richTextBox5.Text, valueFont, Brushes.Black, marginLeft, currentY);
                }
                
                // No more pages
                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.HasMorePages = false;
            }
        }

        // Helper method to calculate text height
        private float GetTextHeight(string text, Font font, Graphics graphics, int maxWidth)
        {
            if (string.IsNullOrEmpty(text))
                return font.Height;

            SizeF size = graphics.MeasureString(text, font, maxWidth);
            return size.Height + 10; // Add some padding
        }

        // Event handlers
        private void button7_Click(object sender, EventArgs e)
        {
            // Validate the essential fields before printing
            if (!ValidateAllFields())
            {
                MessageBox.Show("Please correct the errors before proceeding.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                // Use a cursor to indicate processing
                Cursor = Cursors.WaitCursor;
                
                // Reset page counter before printing
                currentPage = 0;
                
                // Show print preview with improved settings
                printPreviewDialog.ShowIcon = false;
                printPreviewDialog.UseAntiAlias = true;
                printPreviewDialog.WindowState = FormWindowState.Maximized;
                
                // Add print button to the print preview dialog
                printPreviewDialog.Document = printDocument;
                
                // Show the dialog
                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                {
                    // If user clicks OK in the print preview, print the document
                    using (PrintDialog printDialog = new PrintDialog())
                    {
                        printDialog.Document = printDocument;
                        printDialog.AllowSomePages = true;
                        printDialog.AllowSelection = false;
                        printDialog.AllowPrintToFile = false;
                        
                        // Set reasonable defaults for page range
                        printDocument.PrinterSettings.MinimumPage = 1;
                        printDocument.PrinterSettings.MaximumPage = maxPagesExpected;
                        printDocument.PrinterSettings.FromPage = 1;
                        printDocument.PrinterSettings.ToPage = maxPagesExpected;
                        
                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            printDocument.Print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restore cursor
                Cursor = Cursors.Default;
            }
        }

        // Enhanced TextChanged handler for phone number formatting
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            
            // If the change is programmatic, don't reformat to avoid infinite loop
            if (textBox.Tag != null && (bool)textBox.Tag)
            {
                textBox.Tag = false;
                return;
            }
            
            // Keep cursor position for better UX
            int cursorPosition = textBox.SelectionStart;
            
            // Keep only digits
            string digitsOnly = new string(textBox.Text.Where(c => char.IsDigit(c)).ToArray());
            
            // Format the phone number
            string formattedNumber = digitsOnly;
            
            try
            {
                if (digitsOnly.Length > 0)
                {
                    // US format example: (123) 456-7890
                    if (digitsOnly.Length >= 10)
                    {
                        formattedNumber = $"({digitsOnly.Substring(0, 3)}) {digitsOnly.Substring(3, 3)}-{digitsOnly.Substring(6, Math.Min(4, digitsOnly.Length - 6))}";
                        if (digitsOnly.Length > 10)
                        {
                            formattedNumber += " " + digitsOnly.Substring(10);
                        }
                    }
                    
                    // Only update if it actually changed to avoid infinite loop
                    if (formattedNumber != textBox.Text)
                    {
                        textBox.Tag = true; // Mark this as a programmatic change
                        textBox.Text = formattedNumber;
                        
                        // Try to maintain cursor position
                        int newPosition = cursorPosition;
                        if (formattedNumber.Length > textBox.Text.Length && cursorPosition > 0)
                        {
                            // Adjust for added formatting characters
                            newPosition = Math.Min(formattedNumber.Length, cursorPosition + 
                                                  (formattedNumber.Length - textBox.Text.Length));
                        }
                        textBox.SelectionStart = Math.Min(newPosition, textBox.Text.Length);
                    }
                }
            }
            catch (Exception)
            {
                // If formatting fails, just keep the digits
                textBox.Tag = true; // Mark this as a programmatic change
                textBox.Text = digitsOnly;
                textBox.SelectionStart = Math.Min(cursorPosition, textBox.Text.Length);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a photo";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image newImage = null;
                    try
                    {
                        // Load new image first before disposing the old one
                        using (var stream = new System.IO.FileStream(openFileDialog.FileName, 
                               System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            newImage = new Bitmap(stream);
                        }
                        
                        // Then dispose old image
                        if (pictureBox1.Image != null)
                        {
                            Image oldImage = pictureBox1.Image;
                            pictureBox1.Image = null;
                            oldImage.Dispose();
                        }
                        
                        // Set new image
                        pictureBox1.Image = newImage;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        // If an exception occurs but we already created the new image, ensure it's disposed
                        if (newImage != null)
                        {
                            newImage.Dispose();
                        }
                        
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Show image selection dialog on click too
            button2_Click(sender, e);
        }

        private void Gilles_Load(object sender, EventArgs e)
        {
            // Set up scrollbar
            this.AutoScroll = true;
            
            // Set initial focus to name field
            textBox2.Focus();
            
            // Set tab order for major fields
            textBox2.TabIndex = 1; // Name
            textBox3.TabIndex = 2; // Status
            textBox1.TabIndex = 3; // Phone
            textBox4.TabIndex = 4; // Email
            textBox5.TabIndex = 5; // Address
            richTextBox2.TabIndex = 6; // About Me
            richTextBox3.TabIndex = 7; // Education
            richTextBox4.TabIndex = 8; // Experience
            richTextBox6.TabIndex = 9; // Skills
            richTextBox5.TabIndex = 10; // References
            button7.TabIndex = 11; // Print button
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Implementation if needed
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Implementation if needed
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Instead of creating a new Form1 instance, find the existing one
            // or create a new one only if needed
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            
            if (mainForm == null)
            {
                // Create a new instance only if there isn't one already
                mainForm = new Form1();
            }
            
            mainForm.Show();
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.AutoScroll = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // This could be used to add a new experience entry or some other functionality
            MessageBox.Show("Experience button clicked", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Add these methods to enable data persistence
        private void SaveCV(string filename)
        {
            try
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename))
                {
                    // Save personal info
                    writer.WriteLine($"Name:{textBox2.Text}");
                    writer.WriteLine($"Status:{textBox3.Text}");
                    writer.WriteLine($"Phone:{textBox1.Text}");
                    writer.WriteLine($"Email:{textBox4.Text}");
                    writer.WriteLine($"Address:{textBox5.Text}");
                    
                    // Save sections
                    writer.WriteLine($"AboutMe:{richTextBox2.Text}");
                    writer.WriteLine($"Education:{richTextBox3.Text}");
                    writer.WriteLine($"Experience:{richTextBox4.Text}");
                    writer.WriteLine($"Skills:{richTextBox6.Text}");
                    writer.WriteLine($"References:{richTextBox5.Text}");
                    
                    // Save image if available
                    if (pictureBox1.Image != null)
                    {
                        string imageFilename = System.IO.Path.ChangeExtension(filename, ".png");
                        pictureBox1.Image.Save(imageFilename, System.Drawing.Imaging.ImageFormat.Png);
                        writer.WriteLine($"Image:{imageFilename}");
                    }
                }
                
                MessageBox.Show("CV saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving CV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCV(string filename)
        {
            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int separatorIndex = line.IndexOf(':');
                        if (separatorIndex > 0)
                        {
                            string key = line.Substring(0, separatorIndex);
                            string value = line.Substring(separatorIndex + 1);
                            
                            switch (key)
                            {
                                case "Name": textBox2.Text = value; break;
                                case "Status": textBox3.Text = value; break;
                                case "Phone": textBox1.Text = value; break;
                                case "Email": textBox4.Text = value; break;
                                case "Address": textBox5.Text = value; break;
                                case "AboutMe": richTextBox2.Text = value; break;
                                case "Education": richTextBox3.Text = value; break;
                                case "Experience": richTextBox4.Text = value; break;
                                case "Skills": richTextBox6.Text = value; break;
                                case "References": richTextBox5.Text = value; break;
                                case "Image":
                                    if (System.IO.File.Exists(value))
                                    {
                                        pictureBox1.Image = Image.FromFile(value);
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    break;
                            }
                        }
                    }
                }
                
                MessageBox.Show("CV loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CV Files|*.cv|All Files|*.*";
                saveFileDialog.Title = "Save CV";
                saveFileDialog.DefaultExt = "cv";
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveCV(saveFileDialog.FileName);
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CV Files|*.cv|All Files|*.*";
                openFileDialog.Title = "Load CV";
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadCV(openFileDialog.FileName);
                }
            }
        }
    }
}