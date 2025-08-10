namespace CV_Rose
{
    partial class mongado
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
            panelFooter = new Panel();
            btnClear = new Button();
            btnGenerateCV = new Button();
            panelHeader = new Panel();
            label1 = new Label();
            panelMain = new Panel();
            panelContent = new Panel();
            grpReferences = new GroupBox();
            listReferences = new ListBox();
            btnAddReference = new Button();
            txtRefEmail = new TextBox();
            label21 = new Label();
            txtRefContact = new TextBox();
            label20 = new Label();
            txtRefPosition = new TextBox();
            label19 = new Label();
            txtRefName = new TextBox();
            label18 = new Label();
            grpSkillsLanguages = new GroupBox();
            listLanguages = new ListBox();
            listSkills = new ListBox();
            btnAddLanguage = new Button();
            txtLanguage = new TextBox();
            label17 = new Label();
            btnAddSkill = new Button();
            txtSkill = new TextBox();
            label16 = new Label();
            grpEducation = new GroupBox();
            listEducation = new ListBox();
            btnAddEducation = new Button();
            txtYears = new TextBox();
            label15 = new Label();
            txtSchool = new TextBox();
            label14 = new Label();
            grpProfile = new GroupBox();
            txtProfile = new TextBox();
            label13 = new Label();
            grpPersonalInfo = new GroupBox();
            txtAddress = new TextBox();
            label12 = new Label();
            txtEmail = new TextBox();
            label11 = new Label();
            txtPhone = new TextBox();
            label10 = new Label();
            txtJobTitle = new TextBox();
            label9 = new Label();
            txtFullName = new TextBox();
            label8 = new Label();
            grpPhoto = new GroupBox();
            btnSelectPhoto = new Button();
            pictureBoxPhoto = new PictureBox();
            panelFooter.SuspendLayout();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelContent.SuspendLayout();
            grpReferences.SuspendLayout();
            grpSkillsLanguages.SuspendLayout();
            grpEducation.SuspendLayout();
            grpProfile.SuspendLayout();
            grpPersonalInfo.SuspendLayout();
            grpPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(248, 249, 250);
            panelFooter.Controls.Add(btnClear);
            panelFooter.Controls.Add(btnGenerateCV);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 948);
            panelFooter.Margin = new Padding(3, 4, 3, 4);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(34, 27, 34, 27);
            panelFooter.Size = new Size(1029, 107);
            panelFooter.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(220, 53, 69);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(206, 27);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 47);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenerateCV
            // 
            btnGenerateCV.BackColor = Color.FromArgb(40, 167, 69);
            btnGenerateCV.FlatAppearance.BorderSize = 0;
            btnGenerateCV.FlatStyle = FlatStyle.Flat;
            btnGenerateCV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateCV.ForeColor = Color.White;
            btnGenerateCV.Location = new Point(34, 27);
            btnGenerateCV.Margin = new Padding(3, 4, 3, 4);
            btnGenerateCV.Name = "btnGenerateCV";
            btnGenerateCV.Size = new Size(149, 47);
            btnGenerateCV.TabIndex = 0;
            btnGenerateCV.Text = "Generate CV";
            btnGenerateCV.UseVisualStyleBackColor = false;
            btnGenerateCV.Click += btnGenerateCV_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 58, 64);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(23, 20, 23, 20);
            panelHeader.Size = new Size(1029, 80);
            panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(167, 41);
            label1.TabIndex = 0;
            label1.Text = "CV Builder";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelContent);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 120);
            panelMain.Size = new Size(1029, 868);
            panelMain.TabIndex = 2;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(248, 249, 250);
            panelContent.Controls.Add(grpReferences);
            panelContent.Controls.Add(grpSkillsLanguages);
            panelContent.Controls.Add(grpEducation);
            panelContent.Controls.Add(grpProfile);
            panelContent.Controls.Add(grpPersonalInfo);
            panelContent.Controls.Add(grpPhoto);
            panelContent.Location = new Point(34, 13);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 2000);
            panelContent.TabIndex = 0;
            // 
            // grpReferences
            // 
            grpReferences.BackColor = Color.White;
            grpReferences.Controls.Add(listReferences);
            grpReferences.Controls.Add(btnAddReference);
            grpReferences.Controls.Add(txtRefEmail);
            grpReferences.Controls.Add(label21);
            grpReferences.Controls.Add(txtRefContact);
            grpReferences.Controls.Add(label20);
            grpReferences.Controls.Add(txtRefPosition);
            grpReferences.Controls.Add(label19);
            grpReferences.Controls.Add(txtRefName);
            grpReferences.Controls.Add(label18);
            grpReferences.FlatStyle = FlatStyle.Flat;
            grpReferences.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpReferences.ForeColor = Color.FromArgb(73, 80, 87);
            grpReferences.Location = new Point(0, 1520);
            grpReferences.Margin = new Padding(0, 0, 0, 33);
            grpReferences.Name = "grpReferences";
            grpReferences.Padding = new Padding(23, 20, 23, 27);
            grpReferences.Size = new Size(754, 347);
            grpReferences.TabIndex = 5;
            grpReferences.TabStop = false;
            grpReferences.Text = "References";
            // 
            // listReferences
            // 
            listReferences.BackColor = Color.White;
            listReferences.BorderStyle = BorderStyle.FixedSingle;
            listReferences.Font = new Font("Segoe UI", 9F);
            listReferences.FormattingEnabled = true;
            listReferences.Location = new Point(23, 233);
            listReferences.Margin = new Padding(3, 4, 3, 4);
            listReferences.Name = "listReferences";
            listReferences.Size = new Size(708, 82);
            listReferences.TabIndex = 9;
            // 
            // btnAddReference
            // 
            btnAddReference.BackColor = Color.FromArgb(108, 117, 125);
            btnAddReference.FlatAppearance.BorderSize = 0;
            btnAddReference.FlatStyle = FlatStyle.Flat;
            btnAddReference.Font = new Font("Segoe UI", 8.5F);
            btnAddReference.ForeColor = Color.White;
            btnAddReference.Location = new Point(389, 187);
            btnAddReference.Margin = new Padding(3, 4, 3, 4);
            btnAddReference.Name = "btnAddReference";
            btnAddReference.Size = new Size(69, 33);
            btnAddReference.TabIndex = 8;
            btnAddReference.Text = "Add";
            btnAddReference.UseVisualStyleBackColor = false;
            btnAddReference.Click += btnAddReference_Click;
            // 
            // txtRefEmail
            // 
            txtRefEmail.BackColor = Color.White;
            txtRefEmail.BorderStyle = BorderStyle.FixedSingle;
            txtRefEmail.Font = new Font("Segoe UI", 9F);
            txtRefEmail.Location = new Point(23, 189);
            txtRefEmail.Margin = new Padding(3, 4, 3, 4);
            txtRefEmail.Name = "txtRefEmail";
            txtRefEmail.Size = new Size(343, 27);
            txtRefEmail.TabIndex = 7;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 8.5F);
            label21.ForeColor = Color.FromArgb(108, 117, 125);
            label21.Location = new Point(23, 147);
            label21.Name = "label21";
            label21.Size = new Size(343, 33);
            label21.TabIndex = 6;
            label21.Text = "Email:";
            label21.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtRefContact
            // 
            txtRefContact.BackColor = Color.White;
            txtRefContact.BorderStyle = BorderStyle.FixedSingle;
            txtRefContact.Font = new Font("Segoe UI", 9F);
            txtRefContact.Location = new Point(389, 113);
            txtRefContact.Margin = new Padding(3, 4, 3, 4);
            txtRefContact.Name = "txtRefContact";
            txtRefContact.Size = new Size(137, 27);
            txtRefContact.TabIndex = 5;
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 8.5F);
            label20.ForeColor = Color.FromArgb(108, 117, 125);
            label20.Location = new Point(389, 67);
            label20.Name = "label20";
            label20.Size = new Size(137, 33);
            label20.TabIndex = 4;
            label20.Text = "Contact:";
            label20.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtRefPosition
            // 
            txtRefPosition.BackColor = Color.White;
            txtRefPosition.BorderStyle = BorderStyle.FixedSingle;
            txtRefPosition.Font = new Font("Segoe UI", 9F);
            txtRefPosition.Location = new Point(206, 113);
            txtRefPosition.Margin = new Padding(3, 4, 3, 4);
            txtRefPosition.Name = "txtRefPosition";
            txtRefPosition.Size = new Size(171, 27);
            txtRefPosition.TabIndex = 3;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 8.5F);
            label19.ForeColor = Color.FromArgb(108, 117, 125);
            label19.Location = new Point(206, 67);
            label19.Name = "label19";
            label19.Size = new Size(171, 33);
            label19.TabIndex = 2;
            label19.Text = "Position:";
            label19.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtRefName
            // 
            txtRefName.BackColor = Color.White;
            txtRefName.BorderStyle = BorderStyle.FixedSingle;
            txtRefName.Font = new Font("Segoe UI", 9F);
            txtRefName.Location = new Point(23, 113);
            txtRefName.Margin = new Padding(3, 4, 3, 4);
            txtRefName.Name = "txtRefName";
            txtRefName.Size = new Size(171, 27);
            txtRefName.TabIndex = 1;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 8.5F);
            label18.ForeColor = Color.FromArgb(108, 117, 125);
            label18.Location = new Point(23, 67);
            label18.Name = "label18";
            label18.Size = new Size(171, 33);
            label18.TabIndex = 0;
            label18.Text = "Name:";
            label18.TextAlign = ContentAlignment.BottomLeft;
            // 
            // grpSkillsLanguages
            // 
            grpSkillsLanguages.BackColor = Color.White;
            grpSkillsLanguages.Controls.Add(listLanguages);
            grpSkillsLanguages.Controls.Add(listSkills);
            grpSkillsLanguages.Controls.Add(btnAddLanguage);
            grpSkillsLanguages.Controls.Add(txtLanguage);
            grpSkillsLanguages.Controls.Add(label17);
            grpSkillsLanguages.Controls.Add(btnAddSkill);
            grpSkillsLanguages.Controls.Add(txtSkill);
            grpSkillsLanguages.Controls.Add(label16);
            grpSkillsLanguages.FlatStyle = FlatStyle.Flat;
            grpSkillsLanguages.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpSkillsLanguages.ForeColor = Color.FromArgb(73, 80, 87);
            grpSkillsLanguages.Location = new Point(0, 1187);
            grpSkillsLanguages.Margin = new Padding(0, 0, 0, 33);
            grpSkillsLanguages.Name = "grpSkillsLanguages";
            grpSkillsLanguages.Padding = new Padding(23, 20, 23, 27);
            grpSkillsLanguages.Size = new Size(754, 300);
            grpSkillsLanguages.TabIndex = 4;
            grpSkillsLanguages.TabStop = false;
            grpSkillsLanguages.Text = "Skills & Languages";
            // 
            // listLanguages
            // 
            listLanguages.BackColor = Color.White;
            listLanguages.BorderStyle = BorderStyle.FixedSingle;
            listLanguages.Font = new Font("Segoe UI", 9F);
            listLanguages.FormattingEnabled = true;
            listLanguages.Location = new Point(389, 167);
            listLanguages.Margin = new Padding(3, 4, 3, 4);
            listLanguages.Name = "listLanguages";
            listLanguages.Size = new Size(320, 102);
            listLanguages.TabIndex = 7;
            // 
            // listSkills
            // 
            listSkills.BackColor = Color.White;
            listSkills.BorderStyle = BorderStyle.FixedSingle;
            listSkills.Font = new Font("Segoe UI", 9F);
            listSkills.FormattingEnabled = true;
            listSkills.Location = new Point(23, 167);
            listSkills.Margin = new Padding(3, 4, 3, 4);
            listSkills.Name = "listSkills";
            listSkills.Size = new Size(320, 102);
            listSkills.TabIndex = 6;
            // 
            // btnAddLanguage
            // 
            btnAddLanguage.BackColor = Color.FromArgb(108, 117, 125);
            btnAddLanguage.FlatAppearance.BorderSize = 0;
            btnAddLanguage.FlatStyle = FlatStyle.Flat;
            btnAddLanguage.Font = new Font("Segoe UI", 8.5F);
            btnAddLanguage.ForeColor = Color.White;
            btnAddLanguage.Location = new Point(651, 111);
            btnAddLanguage.Margin = new Padding(3, 4, 3, 4);
            btnAddLanguage.Name = "btnAddLanguage";
            btnAddLanguage.Size = new Size(57, 33);
            btnAddLanguage.TabIndex = 5;
            btnAddLanguage.Text = "Add";
            btnAddLanguage.UseVisualStyleBackColor = false;
            btnAddLanguage.Click += btnAddLanguage_Click;
            // 
            // txtLanguage
            // 
            txtLanguage.BackColor = Color.White;
            txtLanguage.BorderStyle = BorderStyle.FixedSingle;
            txtLanguage.Font = new Font("Segoe UI", 9F);
            txtLanguage.Location = new Point(389, 113);
            txtLanguage.Margin = new Padding(3, 4, 3, 4);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(251, 27);
            txtLanguage.TabIndex = 4;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 8.5F);
            label17.ForeColor = Color.FromArgb(108, 117, 125);
            label17.Location = new Point(389, 67);
            label17.Name = "label17";
            label17.Size = new Size(251, 33);
            label17.TabIndex = 3;
            label17.Text = "Language:";
            label17.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnAddSkill
            // 
            btnAddSkill.BackColor = Color.FromArgb(108, 117, 125);
            btnAddSkill.FlatAppearance.BorderSize = 0;
            btnAddSkill.FlatStyle = FlatStyle.Flat;
            btnAddSkill.Font = new Font("Segoe UI", 8.5F);
            btnAddSkill.ForeColor = Color.White;
            btnAddSkill.Location = new Point(286, 111);
            btnAddSkill.Margin = new Padding(3, 4, 3, 4);
            btnAddSkill.Name = "btnAddSkill";
            btnAddSkill.Size = new Size(57, 33);
            btnAddSkill.TabIndex = 2;
            btnAddSkill.Text = "Add";
            btnAddSkill.UseVisualStyleBackColor = false;
            btnAddSkill.Click += btnAddSkill_Click;
            // 
            // txtSkill
            // 
            txtSkill.BackColor = Color.White;
            txtSkill.BorderStyle = BorderStyle.FixedSingle;
            txtSkill.Font = new Font("Segoe UI", 9F);
            txtSkill.Location = new Point(23, 113);
            txtSkill.Margin = new Padding(3, 4, 3, 4);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(251, 27);
            txtSkill.TabIndex = 1;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 8.5F);
            label16.ForeColor = Color.FromArgb(108, 117, 125);
            label16.Location = new Point(23, 67);
            label16.Name = "label16";
            label16.Size = new Size(251, 33);
            label16.TabIndex = 0;
            label16.Text = "Skill:";
            label16.TextAlign = ContentAlignment.BottomLeft;
            // 
            // grpEducation
            // 
            grpEducation.BackColor = Color.White;
            grpEducation.Controls.Add(listEducation);
            grpEducation.Controls.Add(btnAddEducation);
            grpEducation.Controls.Add(txtYears);
            grpEducation.Controls.Add(label15);
            grpEducation.Controls.Add(txtSchool);
            grpEducation.Controls.Add(label14);
            grpEducation.FlatStyle = FlatStyle.Flat;
            grpEducation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEducation.ForeColor = Color.FromArgb(73, 80, 87);
            grpEducation.Location = new Point(0, 853);
            grpEducation.Margin = new Padding(0, 0, 0, 33);
            grpEducation.Name = "grpEducation";
            grpEducation.Padding = new Padding(23, 20, 23, 27);
            grpEducation.Size = new Size(754, 300);
            grpEducation.TabIndex = 3;
            grpEducation.TabStop = false;
            grpEducation.Text = "Education";
            // 
            // listEducation
            // 
            listEducation.BackColor = Color.White;
            listEducation.BorderStyle = BorderStyle.FixedSingle;
            listEducation.Font = new Font("Segoe UI", 9F);
            listEducation.FormattingEnabled = true;
            listEducation.Location = new Point(23, 167);
            listEducation.Margin = new Padding(3, 4, 3, 4);
            listEducation.Name = "listEducation";
            listEducation.Size = new Size(708, 102);
            listEducation.TabIndex = 5;
            // 
            // btnAddEducation
            // 
            btnAddEducation.BackColor = Color.FromArgb(108, 117, 125);
            btnAddEducation.FlatAppearance.BorderSize = 0;
            btnAddEducation.FlatStyle = FlatStyle.Flat;
            btnAddEducation.Font = new Font("Segoe UI", 8.5F);
            btnAddEducation.ForeColor = Color.White;
            btnAddEducation.Location = new Point(663, 111);
            btnAddEducation.Margin = new Padding(3, 4, 3, 4);
            btnAddEducation.Name = "btnAddEducation";
            btnAddEducation.Size = new Size(69, 33);
            btnAddEducation.TabIndex = 4;
            btnAddEducation.Text = "Add";
            btnAddEducation.UseVisualStyleBackColor = false;
            btnAddEducation.Click += btnAddEducation_Click;
            // 
            // txtYears
            // 
            txtYears.BackColor = Color.White;
            txtYears.BorderStyle = BorderStyle.FixedSingle;
            txtYears.Font = new Font("Segoe UI", 9F);
            txtYears.Location = new Point(514, 113);
            txtYears.Margin = new Padding(3, 4, 3, 4);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(137, 27);
            txtYears.TabIndex = 3;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 8.5F);
            label15.ForeColor = Color.FromArgb(108, 117, 125);
            label15.Location = new Point(514, 67);
            label15.Name = "label15";
            label15.Size = new Size(137, 33);
            label15.TabIndex = 2;
            label15.Text = "Years:";
            label15.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtSchool
            // 
            txtSchool.BackColor = Color.White;
            txtSchool.BorderStyle = BorderStyle.FixedSingle;
            txtSchool.Font = new Font("Segoe UI", 9F);
            txtSchool.Location = new Point(23, 113);
            txtSchool.Margin = new Padding(3, 4, 3, 4);
            txtSchool.Name = "txtSchool";
            txtSchool.Size = new Size(480, 27);
            txtSchool.TabIndex = 1;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 8.5F);
            label14.ForeColor = Color.FromArgb(108, 117, 125);
            label14.Location = new Point(23, 67);
            label14.Name = "label14";
            label14.Size = new Size(480, 33);
            label14.TabIndex = 0;
            label14.Text = "School/University:";
            label14.TextAlign = ContentAlignment.BottomLeft;
            // 
            // grpProfile
            // 
            grpProfile.BackColor = Color.White;
            grpProfile.Controls.Add(txtProfile);
            grpProfile.Controls.Add(label13);
            grpProfile.FlatStyle = FlatStyle.Flat;
            grpProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpProfile.ForeColor = Color.FromArgb(73, 80, 87);
            grpProfile.Location = new Point(0, 573);
            grpProfile.Margin = new Padding(0, 0, 0, 33);
            grpProfile.Name = "grpProfile";
            grpProfile.Padding = new Padding(23, 20, 23, 27);
            grpProfile.Size = new Size(754, 247);
            grpProfile.TabIndex = 2;
            grpProfile.TabStop = false;
            grpProfile.Text = "Profile Summary";
            // 
            // txtProfile
            // 
            txtProfile.BackColor = Color.White;
            txtProfile.BorderStyle = BorderStyle.FixedSingle;
            txtProfile.Font = new Font("Segoe UI", 9F);
            txtProfile.Location = new Point(23, 107);
            txtProfile.Margin = new Padding(3, 4, 3, 4);
            txtProfile.Multiline = true;
            txtProfile.Name = "txtProfile";
            txtProfile.ScrollBars = ScrollBars.Vertical;
            txtProfile.Size = new Size(708, 119);
            txtProfile.TabIndex = 1;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 8.5F);
            label13.ForeColor = Color.FromArgb(108, 117, 125);
            label13.Location = new Point(23, 60);
            label13.Name = "label13";
            label13.Size = new Size(709, 33);
            label13.TabIndex = 0;
            label13.Text = "Profile Summary:";
            label13.TextAlign = ContentAlignment.BottomLeft;
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.BackColor = Color.White;
            grpPersonalInfo.Controls.Add(txtAddress);
            grpPersonalInfo.Controls.Add(label12);
            grpPersonalInfo.Controls.Add(txtEmail);
            grpPersonalInfo.Controls.Add(label11);
            grpPersonalInfo.Controls.Add(txtPhone);
            grpPersonalInfo.Controls.Add(label10);
            grpPersonalInfo.Controls.Add(txtJobTitle);
            grpPersonalInfo.Controls.Add(label9);
            grpPersonalInfo.Controls.Add(txtFullName);
            grpPersonalInfo.Controls.Add(label8);
            grpPersonalInfo.FlatStyle = FlatStyle.Flat;
            grpPersonalInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPersonalInfo.ForeColor = Color.FromArgb(73, 80, 87);
            grpPersonalInfo.Location = new Point(0, 253);
            grpPersonalInfo.Margin = new Padding(0, 0, 0, 33);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Padding = new Padding(23, 20, 23, 27);
            grpPersonalInfo.Size = new Size(754, 287);
            grpPersonalInfo.TabIndex = 1;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Personal Information";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(23, 240);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(708, 27);
            txtAddress.TabIndex = 9;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 8.5F);
            label12.ForeColor = Color.FromArgb(108, 117, 125);
            label12.Location = new Point(23, 193);
            label12.Name = "label12";
            label12.Size = new Size(709, 33);
            label12.TabIndex = 8;
            label12.Text = "Address:";
            label12.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(286, 160);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(445, 27);
            txtEmail.TabIndex = 7;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 8.5F);
            label11.ForeColor = Color.FromArgb(108, 117, 125);
            label11.Location = new Point(286, 113);
            label11.Name = "label11";
            label11.Size = new Size(446, 33);
            label11.TabIndex = 6;
            label11.Text = "Email:";
            label11.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 9F);
            txtPhone.Location = new Point(23, 160);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(251, 27);
            txtPhone.TabIndex = 5;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 8.5F);
            label10.ForeColor = Color.FromArgb(108, 117, 125);
            label10.Location = new Point(23, 113);
            label10.Name = "label10";
            label10.Size = new Size(251, 33);
            label10.TabIndex = 4;
            label10.Text = "Phone:";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtJobTitle
            // 
            txtJobTitle.BackColor = Color.White;
            txtJobTitle.BorderStyle = BorderStyle.FixedSingle;
            txtJobTitle.Font = new Font("Segoe UI", 9F);
            txtJobTitle.Location = new Point(389, 73);
            txtJobTitle.Margin = new Padding(3, 4, 3, 4);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(343, 27);
            txtJobTitle.TabIndex = 3;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 8.5F);
            label9.ForeColor = Color.FromArgb(108, 117, 125);
            label9.Location = new Point(389, 27);
            label9.Name = "label9";
            label9.Size = new Size(343, 33);
            label9.TabIndex = 2;
            label9.Text = "Job Title:";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 9F);
            txtFullName.Location = new Point(23, 73);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(343, 27);
            txtFullName.TabIndex = 1;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 8.5F);
            label8.ForeColor = Color.FromArgb(108, 117, 125);
            label8.Location = new Point(23, 27);
            label8.Name = "label8";
            label8.Size = new Size(343, 33);
            label8.TabIndex = 0;
            label8.Text = "Full Name:";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // grpPhoto
            // 
            grpPhoto.BackColor = Color.White;
            grpPhoto.Controls.Add(btnSelectPhoto);
            grpPhoto.Controls.Add(pictureBoxPhoto);
            grpPhoto.FlatStyle = FlatStyle.Flat;
            grpPhoto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPhoto.ForeColor = Color.FromArgb(73, 80, 87);
            grpPhoto.Location = new Point(0, 27);
            grpPhoto.Margin = new Padding(0, 0, 0, 33);
            grpPhoto.Name = "grpPhoto";
            grpPhoto.Padding = new Padding(23, 20, 23, 27);
            grpPhoto.Size = new Size(754, 193);
            grpPhoto.TabIndex = 0;
            grpPhoto.TabStop = false;
            grpPhoto.Text = "Photo";
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.BackColor = Color.FromArgb(108, 117, 125);
            btnSelectPhoto.FlatAppearance.BorderSize = 0;
            btnSelectPhoto.FlatStyle = FlatStyle.Flat;
            btnSelectPhoto.Font = new Font("Segoe UI", 8.5F);
            btnSelectPhoto.ForeColor = Color.White;
            btnSelectPhoto.Location = new Point(171, 93);
            btnSelectPhoto.Margin = new Padding(3, 4, 3, 4);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(137, 40);
            btnSelectPhoto.TabIndex = 1;
            btnSelectPhoto.Text = "Select Photo";
            btnSelectPhoto.UseVisualStyleBackColor = false;
            btnSelectPhoto.Click += btnSelectPhoto_Click;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.BackColor = Color.FromArgb(233, 236, 239);
            pictureBoxPhoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPhoto.Location = new Point(23, 47);
            pictureBoxPhoto.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(125, 133);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // mongado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1029, 1055);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 784);
            Name = "mongado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CV Builder - Simple & Professional";
            panelFooter.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            grpReferences.ResumeLayout(false);
            grpReferences.PerformLayout();
            grpSkillsLanguages.ResumeLayout(false);
            grpSkillsLanguages.PerformLayout();
            grpEducation.ResumeLayout(false);
            grpEducation.PerformLayout();
            grpProfile.ResumeLayout(false);
            grpProfile.PerformLayout();
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            grpPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerateCV;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.GroupBox grpReferences;
        private System.Windows.Forms.ListBox listReferences;
        private System.Windows.Forms.Button btnAddReference;
        private System.Windows.Forms.TextBox txtRefEmail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRefContact;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtRefPosition;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtRefName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grpSkillsLanguages;
        private System.Windows.Forms.ListBox listLanguages;
        private System.Windows.Forms.ListBox listSkills;
        private System.Windows.Forms.Button btnAddLanguage;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpEducation;
        private System.Windows.Forms.ListBox listEducation;
        private System.Windows.Forms.Button btnAddEducation;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpPhoto;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
    }
}
