using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
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

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Layout variables
                float marginLeft = 100;
                float marginTop = 100;
                float lineHeight = 30;
                float currentY = marginTop;
                Font headerFont = new Font("Arial", 16, FontStyle.Bold);
                Font labelFont = new Font("Arial", 12, FontStyle.Bold);
                Font valueFont = new Font("Arial", 12, FontStyle.Regular);

                // Draw photo if available
                if (pictureBox1.Image != null)
                {
                    Rectangle imageRect = new Rectangle((int)(marginLeft + 350), (int)marginTop, 120, 150);
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

                // Draw Education section
                e.Graphics.DrawString("EDUCATION", labelFont, Brushes.Black, marginLeft, currentY);
                currentY += lineHeight;
                e.Graphics.DrawString(richTextBox3.Text, valueFont, Brushes.Black, marginLeft, currentY);
                currentY += GetTextHeight(richTextBox3.Text, valueFont, e.Graphics, 600) + lineHeight;

                // Draw Experience section
                e.Graphics.DrawString("EXPERIENCE", labelFont, Brushes.Black, marginLeft, currentY);
                currentY += lineHeight;
                e.Graphics.DrawString(richTextBox4.Text, valueFont, Brushes.Black, marginLeft, currentY);
                currentY += GetTextHeight(richTextBox4.Text, valueFont, e.Graphics, 600) + lineHeight;

                // Draw Skills section
                e.Graphics.DrawString("SKILLS", labelFont, Brushes.Black, marginLeft, currentY);
                currentY += lineHeight;
                e.Graphics.DrawString(richTextBox6.Text, valueFont, Brushes.Black, marginLeft, currentY);
                currentY += GetTextHeight(richTextBox6.Text, valueFont, e.Graphics, 600) + lineHeight;

                // Draw References section
                e.Graphics.DrawString("REFERENCES", labelFont, Brushes.Black, marginLeft, currentY);
                currentY += lineHeight;
                e.Graphics.DrawString(richTextBox5.Text, valueFont, Brushes.Black, marginLeft, currentY);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                // Show print dialog
                using (PrintDialog printDialog = new PrintDialog())
                {
                    printDialog.Document = printDocument;
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Show print preview
                        printPreviewDialog.ShowDialog();

                        // Uncomment this and comment the above line if you want to print directly
                        // printDocument.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Existing event handlers
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Implementation for cellphone textbox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a photo";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Implementation if needed
        }

        private void Gilles_Load(object sender, EventArgs e)
        {
            // Set up scrollbar
            this.AutoScroll = true;
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.AutoScroll = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}