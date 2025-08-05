namespace WinFormsApp1
{
    partial class Form2
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
            lblTitle = new Label();
            lblMembers = new Label();
            btnOpenForm1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 52, 70);
            lblTitle.Location = new Point(28, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(232, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Curriculum Vitae";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblMembers
            // 
            lblMembers.Anchor = AnchorStyles.Top;
            lblMembers.Font = new Font("Segoe UI", 14F);
            lblMembers.ForeColor = Color.FromArgb(70, 80, 105);
            lblMembers.Location = new Point(28, 111);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(121, 43);
            lblMembers.TabIndex = 1;
            lblMembers.Text = "Members: ";
            lblMembers.TextAlign = ContentAlignment.MiddleCenter;
            lblMembers.Click += lblMembers_Click;
            // 
            // btnOpenForm1
            // 
            btnOpenForm1.Anchor = AnchorStyles.None;
            btnOpenForm1.BackColor = Color.FromArgb(45, 52, 70);
            btnOpenForm1.Cursor = Cursors.Hand;
            btnOpenForm1.FlatAppearance.BorderSize = 0;
            btnOpenForm1.FlatStyle = FlatStyle.Flat;
            btnOpenForm1.Font = new Font("Segoe UI", 12F);
            btnOpenForm1.ForeColor = Color.White;
            btnOpenForm1.Location = new Point(658, 393);
            btnOpenForm1.Name = "btnOpenForm1";
            btnOpenForm1.Size = new Size(130, 45);
            btnOpenForm1.TabIndex = 2;
            btnOpenForm1.Text = "Next";
            btnOpenForm1.UseVisualStyleBackColor = false;
            btnOpenForm1.Click += btnOpenForm1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 52, 70);
            label1.Location = new Point(28, 61);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 3;
            label1.Text = "Activity 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_5_8_2025_75139_accountingandbusinesspartners_com;
            pictureBox1.Location = new Point(-7, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(869, 483);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(70, 80, 105);
            label2.Location = new Point(122, 173);
            label2.Name = "label2";
            label2.Size = new Size(296, 43);
            label2.TabIndex = 5;
            label2.Text = "Codera, Augusto Pablo Ivann";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(70, 80, 105);
            label3.Location = new Point(193, 229);
            label3.Name = "label3";
            label3.Size = new Size(271, 43);
            label3.TabIndex = 6;
            label3.Text = "Gilles, Erica Joy";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(70, 80, 105);
            label4.Location = new Point(248, 282);
            label4.Name = "label4";
            label4.Size = new Size(261, 43);
            label4.TabIndex = 7;
            label4.Text = "Mongado, Roselyn";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenForm1);
            Controls.Add(lblMembers);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMembers;
        private Button btnOpenForm1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}