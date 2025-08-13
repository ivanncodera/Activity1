namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            btnCalculator = new Button();
            button1 = new Button();
            btnMongado = new Button();
            btnGilles = new Button();
            btnNavigateToCodera = new Button();
            panelLogo = new Panel();
            labelLogo = new Label();
            panelContent = new Panel();
            pictureBox1 = new PictureBox();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(45, 52, 70);
            panelSideMenu.Controls.Add(btnCalculator);
            panelSideMenu.Controls.Add(button1);
            panelSideMenu.Controls.Add(btnMongado);
            panelSideMenu.Controls.Add(btnGilles);
            panelSideMenu.Controls.Add(btnNavigateToCodera);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(220, 450);
            panelSideMenu.TabIndex = 0;
            // 
            // btnCalculator
            // 
            btnCalculator.BackColor = Color.FromArgb(45, 52, 70);
            btnCalculator.Cursor = Cursors.Hand;
            btnCalculator.Dock = DockStyle.Top;
            btnCalculator.FlatStyle = FlatStyle.Flat;
            btnCalculator.Font = new Font("Segoe UI", 11F);
            btnCalculator.ForeColor = Color.White;
            btnCalculator.Location = new Point(0, 230);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(220, 50);
            btnCalculator.TabIndex = 4;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = false;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnMongado
            // 
            btnMongado.BackColor = Color.FromArgb(45, 52, 70);
            btnMongado.Cursor = Cursors.Hand;
            btnMongado.Dock = DockStyle.Top;
            btnMongado.FlatStyle = FlatStyle.Flat;
            btnMongado.Font = new Font("Segoe UI", 11F);
            btnMongado.ForeColor = Color.White;
            btnMongado.Location = new Point(0, 180);
            btnMongado.Name = "btnMongado";
            btnMongado.Size = new Size(220, 50);
            btnMongado.TabIndex = 3;
            btnMongado.Text = "Go to Mongado";
            btnMongado.UseVisualStyleBackColor = false;
            btnMongado.Click += btnMongado_Click;
            // 
            // btnGilles
            // 
            btnGilles.BackColor = Color.FromArgb(45, 52, 70);
            btnGilles.Cursor = Cursors.Hand;
            btnGilles.Dock = DockStyle.Top;
            btnGilles.FlatStyle = FlatStyle.Flat;
            btnGilles.Font = new Font("Segoe UI", 11F);
            btnGilles.ForeColor = Color.White;
            btnGilles.Location = new Point(0, 130);
            btnGilles.Name = "btnGilles";
            btnGilles.Size = new Size(220, 50);
            btnGilles.TabIndex = 2;
            btnGilles.Text = "Go to Gilles";
            btnGilles.UseVisualStyleBackColor = false;
            btnGilles.Click += btnGilles_Click;
            // 
            // btnNavigateToCodera
            // 
            btnNavigateToCodera.BackColor = Color.FromArgb(45, 52, 70);
            btnNavigateToCodera.Cursor = Cursors.Hand;
            btnNavigateToCodera.Dock = DockStyle.Top;
            btnNavigateToCodera.FlatStyle = FlatStyle.Flat;
            btnNavigateToCodera.Font = new Font("Segoe UI", 11F);
            btnNavigateToCodera.ForeColor = Color.White;
            btnNavigateToCodera.Location = new Point(0, 80);
            btnNavigateToCodera.Name = "btnNavigateToCodera";
            btnNavigateToCodera.Size = new Size(220, 50);
            btnNavigateToCodera.TabIndex = 1;
            btnNavigateToCodera.Text = "Go to Codera";
            btnNavigateToCodera.UseVisualStyleBackColor = false;
            btnNavigateToCodera.Click += GoToForm2_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(35, 40, 55);
            panelLogo.Controls.Add(labelLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            labelLogo.Dock = DockStyle.Fill;
            labelLogo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            labelLogo.ForeColor = Color.White;
            labelLogo.Location = new Point(0, 0);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(220, 80);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "Activities";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            labelLogo.Click += labelLogo_Click;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = Color.White;
            panelContent.BackgroundImage = Properties.Resources.Screenshot_5_8_2025_75139_accountingandbusinesspartners_com;
            panelContent.Controls.Add(pictureBox1);
            panelContent.Controls.Add(panelHeader);
            panelContent.Location = new Point(220, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(580, 450);
            panelContent.TabIndex = 1;
            panelContent.Paint += panelContent_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(250, 250, 250);
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(580, 60);
            panelHeader.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.White;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F);
            labelTitle.ForeColor = Color.FromArgb(45, 52, 70);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(578, 58);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Welcome";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Activity 1";
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnMongado;
        private Button btnGilles;
        private Button btnNavigateToCodera;
        private Panel panelLogo;
        private Label labelLogo;
        private Panel panelContent;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panelHeader;
        private Label labelTitle;
        private Button btnCalculator;
    }
}
