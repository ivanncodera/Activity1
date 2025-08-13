using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Mongado : Form
    {
        public Mongado()
        {
            InitializeComponent();
        }

        // Changed method name to match the form's name for consistency
        private void Mongado_Load(object sender, EventArgs e)
        {
            // NO ACTION YET
        }

        private void CURRICULUM_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Mask = "+63 000-000-0000";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // No action needed for now
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            // No action needed
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // No action needed
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // No action needed
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // No action needed
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No action needed
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = textBox14.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                listBox4.Items.Add($"•{input}");
                textBox14.Clear();
                textBox14.Focus();
            }
            else
            {
                MessageBox.Show("Please enter something!", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox8.Text.Trim();
            string position = textBox9.Text.Trim();
            string contact = maskedTextBox3.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill out all fields!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string combinedInfo = $"•Name: {name}, Position: {position}, Contact: {contact}";
            listBox2.Items.Add(combinedInfo);

            textBox8.Clear();
            textBox9.Clear();
            maskedTextBox3.Clear();
            textBox8.Focus();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string input = textBox7.Text.Trim();
            string year = maskedTextBox2.Text.Trim();

            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(year))
            {
                MessageBox.Show("Please fill out all fields!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string combinedInfo = $"•Name: {input}\tYear: {year}";
            listBox1.Items.Add(combinedInfo);

            textBox7.Clear();
            maskedTextBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string degree = textBox11.Text.Trim();
            string univ = textBox12.Text.Trim();
            string sy = textBox13.Text.Trim();

            if (string.IsNullOrEmpty(degree) || string.IsNullOrEmpty(univ) || string.IsNullOrEmpty(sy))
            {
                MessageBox.Show("Please fill out all fields!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string combinedInfo = $"•Name: {degree}, School: {univ}, S.Y: {sy}";
            listBox3.Items.Add(combinedInfo);

            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox11.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create and show CV preview form
            CVPreviewForm cvForm = new CVPreviewForm(this);
            cvForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        // Public properties to access form data from preview form
        public string FullName => textBox2.Text;
        public string JobTitle => textBox4.Text;
        public string Phone => maskedTextBox1.Text;
        public string Email => textBox1.Text;
        public string Address => textBox5.Text;
        public string Profile => textBox6.Text;
        public ListBox.ObjectCollection Education => listBox3.Items;
        public ListBox.ObjectCollection Experience => listBox1.Items;
        public ListBox.ObjectCollection Skills => listBox4.Items;
        public ListBox.ObjectCollection References => listBox2.Items;
        public Image? Photo => pictureBox1.Image;
    }

    // CV Preview Form
    public class CVPreviewForm : Form
    {
        private Mongado parentForm;
        private Panel cvPanel;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;

        public CVPreviewForm(Mongado parent)
        {
            parentForm = parent;
            InitializeComponent();
            InitializePrinting();
            GenerateCV();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(800, 1000);
            this.Text = "CV Preview";
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(248, 249, 250);
            this.AutoScroll = true;

            // Add print button
            Button printButton = new Button
            {
                Text = "Print Preview",
                Size = new Size(120, 30),
                Location = new Point(10, 10),
                BackColor = Color.FromArgb(255, 64, 129),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            printButton.Click += PrintButton_Click;
            this.Controls.Add(printButton);
        }

        private void InitializePrinting()
        {
            // Initialize PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Initialize PrintPreviewDialog
            printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                UseAntiAlias = true,
                ShowIcon = false,
                ClientSize = new Size(800, 600)
            };
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Show print preview dialog
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying print preview: {ex.Message}", "Print Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Get the graphics context
                Graphics g = e.Graphics;
                
                // Define print margins
                float leftMargin = e.MarginBounds.Left;
                float topMargin = e.MarginBounds.Top;
                float availableWidth = e.MarginBounds.Width;
                float availableHeight = e.MarginBounds.Height;

                // Calculate scaling to fit the page
                float scaleRatio = Math.Min(
                    availableWidth / cvPanel.Width,
                    availableHeight / cvPanel.Height);

                // Create a bitmap of the CV panel
                using (Bitmap bmp = new Bitmap(cvPanel.Width, cvPanel.Height))
                {
                    cvPanel.DrawToBitmap(bmp, new Rectangle(0, 0, cvPanel.Width, cvPanel.Height));
                    
                    // Calculate dimensions to maintain aspect ratio
                    int scaledWidth = (int)(cvPanel.Width * scaleRatio);
                    int scaledHeight = (int)(cvPanel.Height * scaleRatio);
                    
                    // Center the image on the page
                    float x = leftMargin + (availableWidth - scaledWidth) / 2;
                    float y = topMargin + (availableHeight - scaledHeight) / 2;
                    
                    // Draw the CV onto the print document
                    g.DrawImage(bmp, x, y, scaledWidth, scaledHeight);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing: {ex.Message}", "Print Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateCV()
        {
            // Create main CV panel
            cvPanel = new Panel
            {
                Size = new Size(750, 1200),
                Location = new Point(10, 50), // Move down to make room for print button
                BackColor = Color.White
            };

            Panel leftPanel = new Panel
            {
                Size = new Size(250, 1200),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(75, 44, 44)
            };

            // Photo
            if (parentForm.Photo != null)
            {
                PictureBox photo = new PictureBox
                {
                    Size = new Size(120, 120),
                    Location = new Point(65, 20),
                    Image = parentForm.Photo,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Create circular photo
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, photo.Width, photo.Height);
                photo.Region = new Region(path);

                leftPanel.Controls.Add(photo);
            }

            // Contact section
            Label contactHeader = new Label
            {
                Text = "CONTACT",
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(20, 160),
                Size = new Size(200, 25),
                BackColor = Color.Transparent
            };
            leftPanel.Controls.Add(contactHeader);

            Label phoneLabel = new Label
            {
                Text = parentForm.Phone,
                ForeColor = Color.White,
                Font = new Font("Arial", 9),
                Location = new Point(20, 190),
                Size = new Size(200, 20),
                BackColor = Color.Transparent
            };
            leftPanel.Controls.Add(phoneLabel);

            Label emailLabel = new Label
            {
                Text = parentForm.Email,
                ForeColor = Color.White,
                Font = new Font("Arial", 9),
                Location = new Point(20, 215),
                Size = new Size(200, 20),
                BackColor = Color.Transparent
            };
            leftPanel.Controls.Add(emailLabel);

            Label addressLabel = new Label
            {
                Text = parentForm.Address,
                ForeColor = Color.White,
                Font = new Font("Arial", 9),
                Location = new Point(20, 240),
                Size = new Size(200, 20),
                BackColor = Color.Transparent
            };
            leftPanel.Controls.Add(addressLabel);

            // Education section
            Label educationHeader = new Label
            {
                Text = "EDUCATION",
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(20, 290),
                Size = new Size(200, 25),
                BackColor = Color.Transparent
            };
            leftPanel.Controls.Add(educationHeader);

            int eduY = 320;
            foreach (string education in parentForm.Education)
            {
                Label eduLabel = new Label
                {
                    Text = education,
                    ForeColor = Color.White,
                    Font = new Font("Arial", 9),
                    Location = new Point(20, eduY),
                    Size = new Size(200, 40),
                    BackColor = Color.Transparent
                };
                leftPanel.Controls.Add(eduLabel);
                eduY += 45;
            }

            cvPanel.Controls.Add(leftPanel);

            // Right panel (white background)
            Panel rightPanel = new Panel
            {
                Size = new Size(500, 1200),
                Location = new Point(250, 0),
                BackColor = Color.FromArgb(253, 226, 228)
            };

            // Name and title
            Label nameLabel = new Label
            {
                Text = parentForm.FullName,
                ForeColor = Color.FromArgb(139, 101, 76),
                Font = new Font("Arial", 18, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(450, 30),
                BackColor = Color.Transparent
            };
            rightPanel.Controls.Add(nameLabel);

            Label titleLabel = new Label
            {
                Text = parentForm.JobTitle,
                ForeColor = Color.FromArgb(180, 120, 90),
                Font = new Font("Arial", 12),
                Location = new Point(20, 55),
                Size = new Size(450, 20),
                BackColor = Color.Transparent
            };
            rightPanel.Controls.Add(titleLabel);

            // Profile section
            Label profileHeader = new Label
            {
                Text = "PROFILE",
                ForeColor = Color.FromArgb(139, 101, 76),
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, 100),
                Size = new Size(450, 25),
                BackColor = Color.Transparent
            };
            rightPanel.Controls.Add(profileHeader);

            Label profileText = new Label
            {
                Text = parentForm.Profile,
                ForeColor = Color.Black,
                Font = new Font("Arial", 10),
                Location = new Point(20, 130),
                Size = new Size(450, 80),
                BackColor = Color.Transparent
            };
            rightPanel.Controls.Add(profileText);

            // Experience section
            Label experienceHeader = new Label
            {
                Text = "EXPERIENCE",
                ForeColor = Color.FromArgb(139, 101, 76),
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, 220),
                Size = new Size(450, 25),
                BackColor = Color.Transparent
            };
            rightPanel.Controls.Add(experienceHeader);

            int expY = 250;
            foreach (string experience in parentForm.Experience)
            {
                Label expLabel = new Label
                {
                    Text = experience,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 10),
                    Location = new Point(20, expY),
                    Size = new Size(450, 40),
                    BackColor = Color.Transparent
                };
                rightPanel.Controls.Add(expLabel);
                expY += 45;
            }

            // Skills section
            Label skillsHeader = new Label
            {
                Text = "SKILLS",
                ForeColor = Color.FromArgb(139, 101, 76),
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, expY + 20),
                Size = new Size(450, 25),
                BackColor = Color.Transparent
            };
            rightPanel.Controls.Add(skillsHeader);

            int skillY = expY + 50;
            foreach (string skill in parentForm.Skills)
            {
                Label skillLabel = new Label
                {
                    Text = skill,
                    ForeColor = Color.FromArgb(180, 120, 90),
                    Font = new Font("Arial", 10),
                    Location = new Point(20, skillY),
                    Size = new Size(450, 20),
                    BackColor = Color.Transparent
                };
                rightPanel.Controls.Add(skillLabel);
                skillY += 25;
            }

            // References section
            if (parentForm.References.Count > 0)
            {
                Label referencesHeader = new Label
                {
                    Text = "REFERENCES",
                    ForeColor = Color.FromArgb(139, 101, 76),
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Location = new Point(20, skillY + 20),
                    Size = new Size(450, 25),
                    BackColor = Color.Transparent
                };
                rightPanel.Controls.Add(referencesHeader);

                int refY = skillY + 50;
                foreach (string reference in parentForm.References)
                {
                    Label refLabel = new Label
                    {
                        Text = reference,
                        ForeColor = Color.Black,
                        Font = new Font("Arial", 9),
                        Location = new Point(20, refY),
                        Size = new Size(450, 40),
                        BackColor = Color.Transparent
                    };
                    rightPanel.Controls.Add(refLabel);
                    refY += 45;
                }
            }

            cvPanel.Controls.Add(rightPanel);
            this.Controls.Add(cvPanel);
        }
    }
}
