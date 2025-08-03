namespace WinFormsApp1
{
    partial class Codera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            tabControl = new TabControl();
            tabPersonal = new TabPage();
            panel1 = new Panel();
            btnUploadPhoto = new Button();
            pictureBoxPhoto = new PictureBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblPersonalInfo = new Label();
            tabEducation = new TabPage();
            panel2 = new Panel();
            btnAddEducation = new Button();
            txtGradYear = new TextBox();
            lblGradYear = new Label();
            txtDegree = new TextBox();
            lblDegree = new Label();
            txtInstitution = new TextBox();
            lblInstitution = new Label();
            lblEducation = new Label();
            listViewEducation = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tabExperience = new TabPage();
            panel3 = new Panel();
            btnAddExperience = new Button();
            txtJobDescription = new TextBox();
            lblJobDescription = new Label();
            txtEndDate = new TextBox();
            lblEndDate = new Label();
            txtStartDate = new TextBox();
            lblStartDate = new Label();
            txtPosition = new TextBox();
            lblPosition = new Label();
            txtCompany = new TextBox();
            lblCompany = new Label();
            lblWorkExperience = new Label();
            listViewExperience = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            tabSkills = new TabPage();
            panel4 = new Panel();
            btnAddSkill = new Button();
            cmbProficiency = new ComboBox();
            lblProficiency = new Label();
            txtSkill = new TextBox();
            lblSkill = new Label();
            lblSkills = new Label();
            listViewSkills = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            headerPanel = new Panel();
            lblTitle = new Label();
            footerPanel = new Panel();
            btnGenerateCV = new Button();
            btnClear = new Button();
            mainPanel.SuspendLayout();
            tabControl.SuspendLayout();
            tabPersonal.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            tabEducation.SuspendLayout();
            panel2.SuspendLayout();
            tabExperience.SuspendLayout();
            panel3.SuspendLayout();
            tabSkills.SuspendLayout();
            panel4.SuspendLayout();
            headerPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(tabControl);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Controls.Add(footerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(700, 354);
            mainPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPersonal);
            tabControl.Controls.Add(tabEducation);
            tabControl.Controls.Add(tabExperience);
            tabControl.Controls.Add(tabSkills);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.Location = new Point(0, 45);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(700, 264);
            tabControl.TabIndex = 0;
            // 
            // tabPersonal
            // 
            tabPersonal.Controls.Add(panel1);
            tabPersonal.Location = new Point(4, 26);
            tabPersonal.Margin = new Padding(3, 2, 3, 2);
            tabPersonal.Name = "tabPersonal";
            tabPersonal.Padding = new Padding(3, 2, 3, 2);
            tabPersonal.Size = new Size(692, 234);
            tabPersonal.TabIndex = 0;
            tabPersonal.Text = "Personal Information";
            tabPersonal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUploadPhoto);
            panel1.Controls.Add(pictureBoxPhoto);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(lblPersonalInfo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 230);
            panel1.TabIndex = 0;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.BackColor = Color.FromArgb(45, 52, 70);
            btnUploadPhoto.FlatStyle = FlatStyle.Flat;
            btnUploadPhoto.ForeColor = Color.White;
            btnUploadPhoto.Location = new Point(545, 163);
            btnUploadPhoto.Margin = new Padding(3, 2, 3, 2);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(105, 26);
            btnUploadPhoto.TabIndex = 4;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.BackColor = Color.WhiteSmoke;
            pictureBoxPhoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPhoto.Location = new Point(545, 46);
            pictureBoxPhoto.Margin = new Padding(3, 2, 3, 2);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(105, 113);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.TabIndex = 9;
            pictureBoxPhoto.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(129, 132);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 25);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(35, 134);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(129, 102);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(350, 25);
            txtPhone.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(35, 104);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(51, 19);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(129, 72);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 25);
            txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(35, 74);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(61, 19);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(129, 42);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 25);
            txtFullName.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.Location = new Point(35, 44);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(73, 19);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPersonalInfo.Location = new Point(35, 11);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(172, 21);
            lblPersonalInfo.TabIndex = 0;
            lblPersonalInfo.Text = "Personal Information";
            // 
            // tabEducation
            // 
            tabEducation.Controls.Add(panel2);
            tabEducation.Location = new Point(4, 26);
            tabEducation.Margin = new Padding(3, 2, 3, 2);
            tabEducation.Name = "tabEducation";
            tabEducation.Padding = new Padding(3, 2, 3, 2);
            tabEducation.Size = new Size(692, 234);
            tabEducation.TabIndex = 1;
            tabEducation.Text = "Education";
            tabEducation.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddEducation);
            panel2.Controls.Add(txtGradYear);
            panel2.Controls.Add(lblGradYear);
            panel2.Controls.Add(txtDegree);
            panel2.Controls.Add(lblDegree);
            panel2.Controls.Add(txtInstitution);
            panel2.Controls.Add(lblInstitution);
            panel2.Controls.Add(lblEducation);
            panel2.Controls.Add(listViewEducation);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 230);
            panel2.TabIndex = 0;
            // 
            // btnAddEducation
            // 
            btnAddEducation.BackColor = Color.FromArgb(45, 52, 70);
            btnAddEducation.FlatStyle = FlatStyle.Flat;
            btnAddEducation.ForeColor = Color.White;
            btnAddEducation.Location = new Point(374, 100);
            btnAddEducation.Margin = new Padding(3, 2, 3, 2);
            btnAddEducation.Name = "btnAddEducation";
            btnAddEducation.Size = new Size(105, 25);
            btnAddEducation.TabIndex = 3;
            btnAddEducation.Text = "Add";
            btnAddEducation.UseVisualStyleBackColor = false;
            btnAddEducation.Click += btnAddEducation_Click;
            // 
            // txtGradYear
            // 
            txtGradYear.Font = new Font("Segoe UI", 10F);
            txtGradYear.Location = new Point(129, 100);
            txtGradYear.Margin = new Padding(3, 2, 3, 2);
            txtGradYear.Name = "txtGradYear";
            txtGradYear.Size = new Size(219, 25);
            txtGradYear.TabIndex = 2;
            // 
            // lblGradYear
            // 
            lblGradYear.AutoSize = true;
            lblGradYear.Font = new Font("Segoe UI", 10F);
            lblGradYear.Location = new Point(35, 103);
            lblGradYear.Name = "lblGradYear";
            lblGradYear.Size = new Size(72, 19);
            lblGradYear.TabIndex = 7;
            lblGradYear.Text = "Grad Year:";
            // 
            // txtDegree
            // 
            txtDegree.Font = new Font("Segoe UI", 10F);
            txtDegree.Location = new Point(129, 72);
            txtDegree.Margin = new Padding(3, 2, 3, 2);
            txtDegree.Name = "txtDegree";
            txtDegree.Size = new Size(350, 25);
            txtDegree.TabIndex = 1;
            // 
            // lblDegree
            // 
            lblDegree.AutoSize = true;
            lblDegree.Font = new Font("Segoe UI", 10F);
            lblDegree.Location = new Point(35, 74);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new Size(56, 19);
            lblDegree.TabIndex = 5;
            lblDegree.Text = "Degree:";
            // 
            // txtInstitution
            // 
            txtInstitution.Font = new Font("Segoe UI", 10F);
            txtInstitution.Location = new Point(129, 42);
            txtInstitution.Margin = new Padding(3, 2, 3, 2);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.Size = new Size(350, 25);
            txtInstitution.TabIndex = 0;
            // 
            // lblInstitution
            // 
            lblInstitution.AutoSize = true;
            lblInstitution.Font = new Font("Segoe UI", 10F);
            lblInstitution.Location = new Point(35, 44);
            lblInstitution.Name = "lblInstitution";
            lblInstitution.Size = new Size(75, 19);
            lblInstitution.TabIndex = 3;
            lblInstitution.Text = "Institution:";
            // 
            // lblEducation
            // 
            lblEducation.AutoSize = true;
            lblEducation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEducation.Location = new Point(35, 11);
            lblEducation.Name = "lblEducation";
            lblEducation.Size = new Size(87, 21);
            lblEducation.TabIndex = 1;
            lblEducation.Text = "Education";
            // 
            // listViewEducation
            // 
            listViewEducation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewEducation.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewEducation.FullRowSelect = true;
            listViewEducation.GridLines = true;
            listViewEducation.Location = new Point(35, 134);
            listViewEducation.Margin = new Padding(3, 2, 3, 2);
            listViewEducation.MultiSelect = false;
            listViewEducation.Name = "listViewEducation";
            listViewEducation.Size = new Size(614, 85);
            listViewEducation.TabIndex = 4;
            listViewEducation.UseCompatibleStateImageBehavior = false;
            listViewEducation.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Institution";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Degree";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Graduation Year";
            columnHeader3.Width = 100;
            // 
            // tabExperience
            // 
            tabExperience.Controls.Add(panel3);
            tabExperience.Location = new Point(4, 26);
            tabExperience.Margin = new Padding(3, 2, 3, 2);
            tabExperience.Name = "tabExperience";
            tabExperience.Size = new Size(692, 234);
            tabExperience.TabIndex = 2;
            tabExperience.Text = "Work Experience";
            tabExperience.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAddExperience);
            panel3.Controls.Add(txtJobDescription);
            panel3.Controls.Add(lblJobDescription);
            panel3.Controls.Add(txtEndDate);
            panel3.Controls.Add(lblEndDate);
            panel3.Controls.Add(txtStartDate);
            panel3.Controls.Add(lblStartDate);
            panel3.Controls.Add(txtPosition);
            panel3.Controls.Add(lblPosition);
            panel3.Controls.Add(txtCompany);
            panel3.Controls.Add(lblCompany);
            panel3.Controls.Add(lblWorkExperience);
            panel3.Controls.Add(listViewExperience);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(692, 234);
            panel3.TabIndex = 0;
            // 
            // btnAddExperience
            // 
            btnAddExperience.BackColor = Color.FromArgb(45, 52, 70);
            btnAddExperience.FlatStyle = FlatStyle.Flat;
            btnAddExperience.ForeColor = Color.White;
            btnAddExperience.Location = new Point(557, 100);
            btnAddExperience.Margin = new Padding(3, 2, 3, 2);
            btnAddExperience.Name = "btnAddExperience";
            btnAddExperience.Size = new Size(105, 25);
            btnAddExperience.TabIndex = 5;
            btnAddExperience.Text = "Add";
            btnAddExperience.UseVisualStyleBackColor = false;
            btnAddExperience.Click += btnAddExperience_Click;
            // 
            // txtJobDescription
            // 
            txtJobDescription.Font = new Font("Segoe UI", 10F);
            txtJobDescription.Location = new Point(129, 100);
            txtJobDescription.Margin = new Padding(3, 2, 3, 2);
            txtJobDescription.Name = "txtJobDescription";
            txtJobDescription.Size = new Size(415, 25);
            txtJobDescription.TabIndex = 4;
            // 
            // lblJobDescription
            // 
            lblJobDescription.AutoSize = true;
            lblJobDescription.Font = new Font("Segoe UI", 10F);
            lblJobDescription.Location = new Point(35, 103);
            lblJobDescription.Name = "lblJobDescription";
            lblJobDescription.Size = new Size(81, 19);
            lblJobDescription.TabIndex = 11;
            lblJobDescription.Text = "Description:";
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Segoe UI", 10F);
            txtEndDate.Location = new Point(372, 73);
            txtEndDate.Margin = new Padding(3, 2, 3, 2);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(132, 25);
            txtEndDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F);
            lblEndDate.Location = new Point(301, 75);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(68, 19);
            lblEndDate.TabIndex = 9;
            lblEndDate.Text = "End Date:";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Segoe UI", 10F);
            txtStartDate.Location = new Point(129, 73);
            txtStartDate.Margin = new Padding(3, 2, 3, 2);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(132, 25);
            txtStartDate.TabIndex = 2;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F);
            lblStartDate.Location = new Point(35, 75);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(74, 19);
            lblStartDate.TabIndex = 7;
            lblStartDate.Text = "Start Date:";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 10F);
            txtPosition.Location = new Point(372, 43);
            txtPosition.Margin = new Padding(3, 2, 3, 2);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(291, 25);
            txtPosition.TabIndex = 1;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10F);
            lblPosition.Location = new Point(301, 45);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(60, 19);
            lblPosition.TabIndex = 5;
            lblPosition.Text = "Position:";
            // 
            // txtCompany
            // 
            txtCompany.Font = new Font("Segoe UI", 10F);
            txtCompany.Location = new Point(129, 43);
            txtCompany.Margin = new Padding(3, 2, 3, 2);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(158, 25);
            txtCompany.TabIndex = 0;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 10F);
            lblCompany.Location = new Point(35, 45);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(71, 19);
            lblCompany.TabIndex = 3;
            lblCompany.Text = "Company:";
            // 
            // lblWorkExperience
            // 
            lblWorkExperience.AutoSize = true;
            lblWorkExperience.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWorkExperience.Location = new Point(35, 11);
            lblWorkExperience.Name = "lblWorkExperience";
            lblWorkExperience.Size = new Size(139, 21);
            lblWorkExperience.TabIndex = 2;
            lblWorkExperience.Text = "Work Experience";
            // 
            // listViewExperience
            // 
            listViewExperience.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewExperience.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewExperience.FullRowSelect = true;
            listViewExperience.GridLines = true;
            listViewExperience.Location = new Point(35, 134);
            listViewExperience.Margin = new Padding(3, 2, 3, 2);
            listViewExperience.MultiSelect = false;
            listViewExperience.Name = "listViewExperience";
            listViewExperience.Size = new Size(627, 85);
            listViewExperience.TabIndex = 6;
            listViewExperience.UseCompatibleStateImageBehavior = false;
            listViewExperience.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Company";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Position";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Duration";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Description";
            columnHeader7.Width = 300;
            // 
            // tabSkills
            // 
            tabSkills.Controls.Add(panel4);
            tabSkills.Location = new Point(4, 26);
            tabSkills.Margin = new Padding(3, 2, 3, 2);
            tabSkills.Name = "tabSkills";
            tabSkills.Size = new Size(692, 234);
            tabSkills.TabIndex = 3;
            tabSkills.Text = "Skills";
            tabSkills.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAddSkill);
            panel4.Controls.Add(cmbProficiency);
            panel4.Controls.Add(lblProficiency);
            panel4.Controls.Add(txtSkill);
            panel4.Controls.Add(lblSkill);
            panel4.Controls.Add(lblSkills);
            panel4.Controls.Add(listViewSkills);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(692, 234);
            panel4.TabIndex = 0;
            // 
            // btnAddSkill
            // 
            btnAddSkill.BackColor = Color.FromArgb(45, 52, 70);
            btnAddSkill.FlatStyle = FlatStyle.Flat;
            btnAddSkill.ForeColor = Color.White;
            btnAddSkill.Location = new Point(557, 42);
            btnAddSkill.Margin = new Padding(3, 2, 3, 2);
            btnAddSkill.Name = "btnAddSkill";
            btnAddSkill.Size = new Size(105, 25);
            btnAddSkill.TabIndex = 2;
            btnAddSkill.Text = "Add";
            btnAddSkill.UseVisualStyleBackColor = false;
            btnAddSkill.Click += btnAddSkill_Click;
            // 
            // cmbProficiency
            // 
            cmbProficiency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProficiency.Font = new Font("Segoe UI", 10F);
            cmbProficiency.FormattingEnabled = true;
            cmbProficiency.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Expert" });
            cmbProficiency.Location = new Point(427, 42);
            cmbProficiency.Margin = new Padding(3, 2, 3, 2);
            cmbProficiency.Name = "cmbProficiency";
            cmbProficiency.Size = new Size(117, 25);
            cmbProficiency.TabIndex = 1;
            // 
            // lblProficiency
            // 
            lblProficiency.AutoSize = true;
            lblProficiency.Font = new Font("Segoe UI", 10F);
            lblProficiency.Location = new Point(352, 44);
            lblProficiency.Name = "lblProficiency";
            lblProficiency.Size = new Size(77, 19);
            lblProficiency.TabIndex = 5;
            lblProficiency.Text = "Proficiency:";
            // 
            // txtSkill
            // 
            txtSkill.Font = new Font("Segoe UI", 10F);
            txtSkill.Location = new Point(129, 42);
            txtSkill.Margin = new Padding(3, 2, 3, 2);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(210, 25);
            txtSkill.TabIndex = 0;
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Font = new Font("Segoe UI", 10F);
            lblSkill.Location = new Point(35, 44);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(35, 19);
            lblSkill.TabIndex = 3;
            lblSkill.Text = "Skill:";
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSkills.Location = new Point(35, 11);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(50, 21);
            lblSkills.TabIndex = 2;
            lblSkills.Text = "Skills";
            // 
            // listViewSkills
            // 
            listViewSkills.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewSkills.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9 });
            listViewSkills.FullRowSelect = true;
            listViewSkills.GridLines = true;
            listViewSkills.Location = new Point(35, 75);
            listViewSkills.Margin = new Padding(3, 2, 3, 2);
            listViewSkills.MultiSelect = false;
            listViewSkills.Name = "listViewSkills";
            listViewSkills.Size = new Size(627, 146);
            listViewSkills.TabIndex = 3;
            listViewSkills.UseCompatibleStateImageBehavior = false;
            listViewSkills.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Skill";
            columnHeader8.Width = 400;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Proficiency";
            columnHeader9.Width = 200;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(45, 52, 70);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 2, 3, 2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(700, 45);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CV Builder";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(btnGenerateCV);
            footerPanel.Controls.Add(btnClear);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 309);
            footerPanel.Margin = new Padding(3, 2, 3, 2);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(700, 45);
            footerPanel.TabIndex = 2;
            // 
            // btnGenerateCV
            // 
            btnGenerateCV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerateCV.BackColor = Color.FromArgb(45, 52, 70);
            btnGenerateCV.FlatStyle = FlatStyle.Flat;
            btnGenerateCV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateCV.ForeColor = Color.White;
            btnGenerateCV.Location = new Point(557, 10);
            btnGenerateCV.Margin = new Padding(3, 2, 3, 2);
            btnGenerateCV.Name = "btnGenerateCV";
            btnGenerateCV.Size = new Size(132, 26);
            btnGenerateCV.TabIndex = 1;
            btnGenerateCV.Text = "Generate CV";
            btnGenerateCV.UseVisualStyleBackColor = false;
            btnGenerateCV.Click += btnGenerateCV_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.FromArgb(45, 52, 70);
            btnClear.Location = new Point(420, 10);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 26);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Codera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 354);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Codera";
            Text = "CV Builder";
            Load += Codera_Load;
            mainPanel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPersonal.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            tabEducation.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabExperience.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabSkills.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            headerPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private TabControl tabControl;
        private TabPage tabPersonal;
        private TabPage tabEducation;
        private TabPage tabExperience;
        private TabPage tabSkills;
        private Panel headerPanel;
        private Label lblTitle;
        private Panel footerPanel;
        private Button btnGenerateCV;
        private Button btnClear;
        private Panel panel1;
        private Label lblPersonalInfo;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtFullName;
        private Label lblFullName;
        private PictureBox pictureBoxPhoto;
        private Button btnUploadPhoto;
        private Panel panel2;
        private Label lblEducation;
        private ListView listViewEducation;
        private TextBox txtGradYear;
        private Label lblGradYear;
        private TextBox txtDegree;
        private Label lblDegree;
        private TextBox txtInstitution;
        private Label lblInstitution;
        private Button btnAddEducation;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel3;
        private Label lblWorkExperience;
        private ListView listViewExperience;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private TextBox txtPosition;
        private Label lblPosition;
        private TextBox txtCompany;
        private Label lblCompany;
        private TextBox txtEndDate;
        private Label lblEndDate;
        private TextBox txtStartDate;
        private Label lblStartDate;
        private Button btnAddExperience;
        private TextBox txtJobDescription;
        private Label lblJobDescription;
        private Panel panel4;
        private Label lblSkills;
        private TextBox txtSkill;
        private Label lblSkill;
        private ComboBox cmbProficiency;
        private Label lblProficiency;
        private Button btnAddSkill;
        private ListView listViewSkills;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}