using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace CV_Rose
{
    public partial class mongado : Form
    {
        public mongado()
        {
            InitializeComponent();
        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSchool.Text) && !string.IsNullOrWhiteSpace(txtYears.Text))
            {
                listEducation.Items.Add($"{txtSchool.Text} ({txtYears.Text})");
                txtSchool.Clear();
                txtYears.Clear();
            }
        }

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLanguage.Text))
            {
                listLanguages.Items.Add($"•{txtLanguage.Text}");
                txtLanguage.Clear();
            }
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSkill.Text))
            {
                listSkills.Items.Add($"•{txtSkill.Text}");
                txtSkill.Clear();
            }
        }

        private void btnAddReference_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRefName.Text))
            {
                string reference = $"{txtRefName.Text}";
                if (!string.IsNullOrWhiteSpace(txtRefPosition.Text))
                    reference += $"\n{txtRefPosition.Text}";
                if (!string.IsNullOrWhiteSpace(txtRefContact.Text))
                    reference += $"\ncontact no.: {txtRefContact.Text}";
                if (!string.IsNullOrWhiteSpace(txtRefEmail.Text))
                    reference += $"\nEmail: {txtRefEmail.Text}";

                listReferences.Items.Add(reference);
                txtRefName.Clear();
                txtRefPosition.Clear();
                txtRefContact.Clear();
                txtRefEmail.Clear();
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                        pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
            }
        }

        private void btnGenerateCV_Click(object sender, EventArgs e)
        {
            // Create a new form to display the CV preview
            CVPreviewForm previewForm = new CVPreviewForm(this);
            previewForm.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields
            txtFullName.Clear();
            txtJobTitle.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtProfile.Clear();
            listEducation.Items.Clear();
            listLanguages.Items.Clear();
            listSkills.Items.Clear();
            listReferences.Items.Clear();
            pictureBoxPhoto.Image = null;
        }

        // Public properties to access form data from preview form
        public string FullName => txtFullName.Text;
        public string JobTitle => txtJobTitle.Text;
        public string Phone => txtPhone.Text;
        public string Email => txtEmail.Text;
        public string Address => txtAddress.Text;
        public string Profile => txtProfile.Text;
        public ListBox.ObjectCollection Education => listEducation.Items;
        public ListBox.ObjectCollection Languages => listLanguages.Items;
        public ListBox.ObjectCollection Skills => listSkills.Items;
        public ListBox.ObjectCollection References => listReferences.Items;
        public Image? Photo => pictureBoxPhoto.Image;
    }

    // CV Preview Form
    public partial class CVPreviewForm : Form
    {
        private mongado parentForm;

        public CVPreviewForm(mongado parent)
        {
            parentForm = parent;
            InitializeComponent();
            GenerateCV();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(800, 1000);
            this.Text = "CV Preview";
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;
            this.AutoScroll = true;
        }

        private void GenerateCV()
        {
            this.Controls.Clear();

            Panel cvPanel = new Panel
            {
                Size = new Size(750, 1200),
                Location = new Point(10, 10),
                BackColor = Color.White
            };

            // Left panel (brown background)
            Panel leftPanel = new Panel
            {
                Size = new Size(250, 1200),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(139, 101, 76)
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
                BackColor = Color.White
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

            // Languages section
            Label languagesHeader = new Label
            {
                Text = "LANGUAGES",
                ForeColor = Color.FromArgb(139, 101, 76),
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, 230),
                Size = new Size(450, 25),
                BackColor = Color.Transparent
            };
            rightPanel.Controls.Add(languagesHeader);

            int langY = 260;
            foreach (string language in parentForm.Languages)
            {
                Label langLabel = new Label
                {
                    Text = language,
                    ForeColor = Color.FromArgb(180, 120, 90),
                    Font = new Font("Arial", 10),
                    Location = new Point(20, langY),
                    Size = new Size(450, 20),
                    BackColor = Color.Transparent
                };
                rightPanel.Controls.Add(langLabel);
                langY += 25;
            }

            // Skills section
            Label skillsHeader = new Label
            {
                Text = "SKILLS",
                ForeColor = Color.FromArgb(139, 101, 76),
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, langY + 20),
                Size = new Size(450, 25),
                BackColor = Color.Transparent
            };
            rightPanel.Controls.Add(skillsHeader);

            int skillY = langY + 50;
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
                    Text = "REFERENCE",
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
                        Size = new Size(450, 80),
                        BackColor = Color.Transparent
                    };
                    rightPanel.Controls.Add(refLabel);
                    refY += 85;
                }
            }

            cvPanel.Controls.Add(rightPanel);
            this.Controls.Add(cvPanel);
        }
    }
}
