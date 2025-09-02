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
            contentPanel = new Panel();
            lblPersonalInfo = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            pictureBoxPhoto = new PictureBox();
            btnUploadPhoto = new Button();
            lblEducation = new Label();
            lblInstitution = new Label();
            txtInstitution = new TextBox();
            lblDegree = new Label();
            txtDegree = new TextBox();
            lblGradYear = new Label();
            txtGradYear = new TextBox();
            btnAddEducation = new Button();
            listViewEducation = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lblWorkExperience = new Label();
            lblCompany = new Label();
            txtCompany = new TextBox();
            lblPosition = new Label();
            txtPosition = new TextBox();
            lblStartDate = new Label();
            txtStartDate = new TextBox();
            lblEndDate = new Label();
            txtEndDate = new TextBox();
            lblJobDescription = new Label();
            txtJobDescription = new TextBox();
            btnAddExperience = new Button();
            listViewExperience = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lblSkills = new Label();
            lblSkill = new Label();
            txtSkill = new TextBox();
            lblProficiency = new Label();
            cmbProficiency = new ComboBox();
            btnAddSkill = new Button();
            listViewSkills = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            headerPanel = new Panel();
            btnBack = new Button();
            lblTitle = new Label();
            footerPanel = new Panel();
            btnGenerateCV = new Button();
            btnClear = new Button();
            mainPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            headerPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Controls.Add(footerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(746, 880);
            mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.Controls.Add(lblPersonalInfo);
            contentPanel.Controls.Add(lblFullName);
            contentPanel.Controls.Add(txtFullName);
            contentPanel.Controls.Add(lblAddress);
            contentPanel.Controls.Add(txtAddress);
            contentPanel.Controls.Add(lblPhone);
            contentPanel.Controls.Add(txtPhone);
            contentPanel.Controls.Add(lblEmail);
            contentPanel.Controls.Add(txtEmail);
            contentPanel.Controls.Add(pictureBoxPhoto);
            contentPanel.Controls.Add(btnUploadPhoto);
            contentPanel.Controls.Add(lblEducation);
            contentPanel.Controls.Add(lblInstitution);
            contentPanel.Controls.Add(txtInstitution);
            contentPanel.Controls.Add(lblDegree);
            contentPanel.Controls.Add(txtDegree);
            contentPanel.Controls.Add(lblGradYear);
            contentPanel.Controls.Add(txtGradYear);
            contentPanel.Controls.Add(btnAddEducation);
            contentPanel.Controls.Add(listViewEducation);
            contentPanel.Controls.Add(lblWorkExperience);
            contentPanel.Controls.Add(lblCompany);
            contentPanel.Controls.Add(txtCompany);
            contentPanel.Controls.Add(lblPosition);
            contentPanel.Controls.Add(txtPosition);
            contentPanel.Controls.Add(lblStartDate);
            contentPanel.Controls.Add(txtStartDate);
            contentPanel.Controls.Add(lblEndDate);
            contentPanel.Controls.Add(txtEndDate);
            contentPanel.Controls.Add(lblJobDescription);
            contentPanel.Controls.Add(txtJobDescription);
            contentPanel.Controls.Add(btnAddExperience);
            contentPanel.Controls.Add(listViewExperience);
            contentPanel.Controls.Add(lblSkills);
            contentPanel.Controls.Add(lblSkill);
            contentPanel.Controls.Add(txtSkill);
            contentPanel.Controls.Add(lblProficiency);
            contentPanel.Controls.Add(cmbProficiency);
            contentPanel.Controls.Add(btnAddSkill);
            contentPanel.Controls.Add(listViewSkills);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 45);
            contentPanel.Margin = new Padding(3, 2, 3, 2);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20);
            contentPanel.Size = new Size(746, 790);
            contentPanel.TabIndex = 0;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPersonalInfo.Location = new Point(20, 20);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(172, 21);
            lblPersonalInfo.TabIndex = 0;
            lblPersonalInfo.Text = "Personal Information";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.Location = new Point(20, 55);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(73, 19);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(110, 53);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 25);
            txtFullName.TabIndex = 0;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(20, 85);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(61, 19);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(110, 83);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 25);
            txtAddress.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(20, 115);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(51, 19);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(110, 113);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(350, 25);
            txtPhone.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(20, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(110, 143);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 25);
            txtEmail.TabIndex = 3;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.BackColor = Color.WhiteSmoke;
            pictureBoxPhoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPhoto.Location = new Point(603, 51);
            pictureBoxPhoto.Margin = new Padding(3, 2, 3, 2);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(120, 113);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.TabIndex = 9;
            pictureBoxPhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.BackColor = Color.FromArgb(45, 52, 70);
            btnUploadPhoto.FlatStyle = FlatStyle.Flat;
            btnUploadPhoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadPhoto.ForeColor = Color.White;
            btnUploadPhoto.Location = new Point(603, 184);
            btnUploadPhoto.Margin = new Padding(3, 2, 3, 2);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(120, 26);
            btnUploadPhoto.TabIndex = 4;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // lblEducation
            // 
            lblEducation.AutoSize = true;
            lblEducation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEducation.Location = new Point(20, 210);
            lblEducation.Name = "lblEducation";
            lblEducation.Size = new Size(87, 21);
            lblEducation.TabIndex = 11;
            lblEducation.Text = "Education";
            // 
            // lblInstitution
            // 
            lblInstitution.AutoSize = true;
            lblInstitution.Font = new Font("Segoe UI", 10F);
            lblInstitution.Location = new Point(20, 245);
            lblInstitution.Name = "lblInstitution";
            lblInstitution.Size = new Size(75, 19);
            lblInstitution.TabIndex = 12;
            lblInstitution.Text = "Institution:";
            // 
            // txtInstitution
            // 
            txtInstitution.Font = new Font("Segoe UI", 10F);
            txtInstitution.Location = new Point(110, 243);
            txtInstitution.Margin = new Padding(3, 2, 3, 2);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.Size = new Size(250, 25);
            txtInstitution.TabIndex = 5;
            // 
            // lblDegree
            // 
            lblDegree.AutoSize = true;
            lblDegree.Font = new Font("Segoe UI", 10F);
            lblDegree.Location = new Point(370, 245);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new Size(56, 19);
            lblDegree.TabIndex = 14;
            lblDegree.Text = "Degree:";
            // 
            // txtDegree
            // 
            txtDegree.Font = new Font("Segoe UI", 10F);
            txtDegree.Location = new Point(430, 243);
            txtDegree.Margin = new Padding(3, 2, 3, 2);
            txtDegree.Name = "txtDegree";
            txtDegree.Size = new Size(293, 25);
            txtDegree.TabIndex = 6;
            // 
            // lblGradYear
            // 
            lblGradYear.AutoSize = true;
            lblGradYear.Font = new Font("Segoe UI", 10F);
            lblGradYear.Location = new Point(20, 275);
            lblGradYear.Name = "lblGradYear";
            lblGradYear.Size = new Size(72, 19);
            lblGradYear.TabIndex = 16;
            lblGradYear.Text = "Grad Year:";
            // 
            // txtGradYear
            // 
            txtGradYear.Font = new Font("Segoe UI", 10F);
            txtGradYear.Location = new Point(110, 273);
            txtGradYear.Margin = new Padding(3, 2, 3, 2);
            txtGradYear.Name = "txtGradYear";
            txtGradYear.Size = new Size(100, 25);
            txtGradYear.TabIndex = 7;
            // 
            // btnAddEducation
            // 
            btnAddEducation.BackColor = Color.FromArgb(45, 52, 70);
            btnAddEducation.FlatStyle = FlatStyle.Flat;
            btnAddEducation.ForeColor = Color.White;
            btnAddEducation.Location = new Point(430, 273);
            btnAddEducation.Margin = new Padding(3, 2, 3, 2);
            btnAddEducation.Name = "btnAddEducation";
            btnAddEducation.Size = new Size(105, 25);
            btnAddEducation.TabIndex = 8;
            btnAddEducation.Text = "Add";
            btnAddEducation.UseVisualStyleBackColor = false;
            btnAddEducation.Click += btnAddEducation_Click;
            // 
            // listViewEducation
            // 
            listViewEducation.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewEducation.FullRowSelect = true;
            listViewEducation.GridLines = true;
            listViewEducation.Location = new Point(20, 302);
            listViewEducation.Margin = new Padding(3, 2, 3, 2);
            listViewEducation.MultiSelect = false;
            listViewEducation.Name = "listViewEducation";
            listViewEducation.Size = new Size(707, 80);
            listViewEducation.TabIndex = 9;
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
            columnHeader3.Text = "Grad Year";
            columnHeader3.Width = 100;
            // 
            // lblWorkExperience
            // 
            lblWorkExperience.AutoSize = true;
            lblWorkExperience.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWorkExperience.Location = new Point(20, 400);
            lblWorkExperience.Name = "lblWorkExperience";
            lblWorkExperience.Size = new Size(139, 21);
            lblWorkExperience.TabIndex = 20;
            lblWorkExperience.Text = "Work Experience";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 10F);
            lblCompany.Location = new Point(20, 435);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(71, 19);
            lblCompany.TabIndex = 21;
            lblCompany.Text = "Company:";
            // 
            // txtCompany
            // 
            txtCompany.Font = new Font("Segoe UI", 10F);
            txtCompany.Location = new Point(110, 433);
            txtCompany.Margin = new Padding(3, 2, 3, 2);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(158, 25);
            txtCompany.TabIndex = 10;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10F);
            lblPosition.Location = new Point(280, 435);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(60, 19);
            lblPosition.TabIndex = 23;
            lblPosition.Text = "Position:";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 10F);
            txtPosition.Location = new Point(350, 433);
            txtPosition.Margin = new Padding(3, 2, 3, 2);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(377, 25);
            txtPosition.TabIndex = 11;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F);
            lblStartDate.Location = new Point(20, 465);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(74, 19);
            lblStartDate.TabIndex = 25;
            lblStartDate.Text = "Start Date:";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Segoe UI", 10F);
            txtStartDate.Location = new Point(110, 463);
            txtStartDate.Margin = new Padding(3, 2, 3, 2);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(132, 25);
            txtStartDate.TabIndex = 12;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F);
            lblEndDate.Location = new Point(280, 465);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(68, 19);
            lblEndDate.TabIndex = 27;
            lblEndDate.Text = "End Date:";
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Segoe UI", 10F);
            txtEndDate.Location = new Point(350, 463);
            txtEndDate.Margin = new Padding(3, 2, 3, 2);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(132, 25);
            txtEndDate.TabIndex = 13;
            txtEndDate.TextChanged += txtEndDate_TextChanged_1;
            // 
            // lblJobDescription
            // 
            lblJobDescription.AutoSize = true;
            lblJobDescription.Font = new Font("Segoe UI", 10F);
            lblJobDescription.Location = new Point(20, 495);
            lblJobDescription.Name = "lblJobDescription";
            lblJobDescription.Size = new Size(81, 19);
            lblJobDescription.TabIndex = 29;
            lblJobDescription.Text = "Description:";
            // 
            // txtJobDescription
            // 
            txtJobDescription.Font = new Font("Segoe UI", 10F);
            txtJobDescription.Location = new Point(110, 495);
            txtJobDescription.Margin = new Padding(3, 2, 3, 2);
            txtJobDescription.Name = "txtJobDescription";
            txtJobDescription.Size = new Size(521, 25);
            txtJobDescription.TabIndex = 14;
            // 
            // btnAddExperience
            // 
            btnAddExperience.BackColor = Color.FromArgb(45, 52, 70);
            btnAddExperience.FlatStyle = FlatStyle.Flat;
            btnAddExperience.ForeColor = Color.White;
            btnAddExperience.Location = new Point(637, 495);
            btnAddExperience.Margin = new Padding(3, 2, 3, 2);
            btnAddExperience.Name = "btnAddExperience";
            btnAddExperience.Size = new Size(90, 25);
            btnAddExperience.TabIndex = 15;
            btnAddExperience.Text = "Add";
            btnAddExperience.UseVisualStyleBackColor = false;
            btnAddExperience.Click += btnAddExperience_Click;
            // 
            // listViewExperience
            // 
            listViewExperience.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewExperience.FullRowSelect = true;
            listViewExperience.GridLines = true;
            listViewExperience.Location = new Point(20, 525);
            listViewExperience.Margin = new Padding(3, 2, 3, 2);
            listViewExperience.MultiSelect = false;
            listViewExperience.Name = "listViewExperience";
            listViewExperience.Size = new Size(707, 80);
            listViewExperience.TabIndex = 16;
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
            columnHeader6.Width = 170;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Description";
            columnHeader7.Width = 255;
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSkills.Location = new Point(20, 620);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(50, 21);
            lblSkills.TabIndex = 33;
            lblSkills.Text = "Skills";
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Font = new Font("Segoe UI", 10F);
            lblSkill.Location = new Point(20, 655);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(35, 19);
            lblSkill.TabIndex = 34;
            lblSkill.Text = "Skill:";
            // 
            // txtSkill
            // 
            txtSkill.Font = new Font("Segoe UI", 10F);
            txtSkill.Location = new Point(110, 653);
            txtSkill.Margin = new Padding(3, 2, 3, 2);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(250, 25);
            txtSkill.TabIndex = 17;
            // 
            // lblProficiency
            // 
            lblProficiency.AutoSize = true;
            lblProficiency.Font = new Font("Segoe UI", 10F);
            lblProficiency.Location = new Point(370, 655);
            lblProficiency.Name = "lblProficiency";
            lblProficiency.Size = new Size(77, 19);
            lblProficiency.TabIndex = 36;
            lblProficiency.Text = "Proficiency:";
            // 
            // cmbProficiency
            // 
            cmbProficiency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProficiency.Font = new Font("Segoe UI", 10F);
            cmbProficiency.FormattingEnabled = true;
            cmbProficiency.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Expert" });
            cmbProficiency.Location = new Point(450, 653);
            cmbProficiency.Margin = new Padding(3, 2, 3, 2);
            cmbProficiency.Name = "cmbProficiency";
            cmbProficiency.Size = new Size(181, 25);
            cmbProficiency.TabIndex = 18;
            // 
            // btnAddSkill
            // 
            btnAddSkill.BackColor = Color.FromArgb(45, 52, 70);
            btnAddSkill.FlatStyle = FlatStyle.Flat;
            btnAddSkill.ForeColor = Color.White;
            btnAddSkill.Location = new Point(637, 652);
            btnAddSkill.Margin = new Padding(3, 2, 3, 2);
            btnAddSkill.Name = "btnAddSkill";
            btnAddSkill.Size = new Size(90, 25);
            btnAddSkill.TabIndex = 19;
            btnAddSkill.Text = "Add";
            btnAddSkill.UseVisualStyleBackColor = false;
            btnAddSkill.Click += btnAddSkill_Click;
            // 
            // listViewSkills
            // 
            listViewSkills.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9 });
            listViewSkills.FullRowSelect = true;
            listViewSkills.GridLines = true;
            listViewSkills.Location = new Point(20, 685);
            listViewSkills.Margin = new Padding(3, 2, 3, 2);
            listViewSkills.MultiSelect = false;
            listViewSkills.Name = "listViewSkills";
            listViewSkills.Size = new Size(707, 80);
            listViewSkills.TabIndex = 20;
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
            columnHeader9.Width = 310;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(45, 52, 70);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 2, 3, 2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(746, 45);
            headerPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(45, 52, 70);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(11, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 30);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(746, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CV BUILDER";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(btnGenerateCV);
            footerPanel.Controls.Add(btnClear);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 835);
            footerPanel.Margin = new Padding(3, 2, 3, 2);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(746, 45);
            footerPanel.TabIndex = 2;
            // 
            // btnGenerateCV
            // 
            btnGenerateCV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerateCV.BackColor = Color.FromArgb(45, 52, 70);
            btnGenerateCV.FlatStyle = FlatStyle.Flat;
            btnGenerateCV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateCV.ForeColor = Color.White;
            btnGenerateCV.Location = new Point(603, 10);
            btnGenerateCV.Margin = new Padding(3, 2, 3, 2);
            btnGenerateCV.Name = "btnGenerateCV";
            btnGenerateCV.Size = new Size(132, 26);
            btnGenerateCV.TabIndex = 22;
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
            btnClear.Location = new Point(466, 10);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 26);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Codera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 880);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Codera";
            Text = "CV Builder";
            Load += Codera_Load;
            mainPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            headerPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel contentPanel;
        private Panel headerPanel;
        private Label lblTitle;
        private Panel footerPanel;
        private Button btnGenerateCV;
        private Button btnClear;
        private Button btnBack;

        // Personal Info
        private Label lblPersonalInfo;
        private TextBox txtFullName;
        private Label lblFullName;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private PictureBox pictureBoxPhoto;
        private Button btnUploadPhoto;

        // Education
        private Label lblEducation;
        private TextBox txtInstitution;
        private Label lblInstitution;
        private TextBox txtDegree;
        private Label lblDegree;
        private TextBox txtGradYear;
        private Label lblGradYear;
        private Button btnAddEducation;
        private ListView listViewEducation;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;

        // Experience
        private Label lblWorkExperience;
        private TextBox txtCompany;
        private Label lblCompany;
        private TextBox txtPosition;
        private Label lblPosition;
        private TextBox txtStartDate;
        private Label lblStartDate;
        private TextBox txtEndDate;
        private Label lblEndDate;
        private TextBox txtJobDescription;
        private Label lblJobDescription;
        private Button btnAddExperience;
        private ListView listViewExperience;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;

        // Skills
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