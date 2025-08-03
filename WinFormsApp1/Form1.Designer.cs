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
            btnMongado = new Button();
            btnGilles = new Button();
            btnNavigateToCodera = new Button();
            panelLogo = new Panel();
            labelLogo = new Label();
            panelContent = new Panel();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(45, 52, 70);
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
            // btnMongado
            // 
            btnMongado.BackColor = Color.FromArgb(45, 52, 70);
            btnMongado.Cursor = Cursors.Hand;
            btnMongado.Dock = DockStyle.Top;
            btnMongado.FlatAppearance.BorderSize = 0;
            btnMongado.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 80, 105);
            btnMongado.FlatStyle = FlatStyle.Flat;
            btnMongado.Font = new Font("Segoe UI", 11F);
            btnMongado.ForeColor = Color.White;
            btnMongado.ImageAlign = ContentAlignment.MiddleLeft;
            btnMongado.Location = new Point(0, 180);
            btnMongado.Name = "btnMongado";
            btnMongado.Padding = new Padding(15, 0, 0, 0);
            btnMongado.Size = new Size(220, 50);
            btnMongado.TabIndex = 3;
            btnMongado.Text = "Go to Mongado";
            btnMongado.TextAlign = ContentAlignment.MiddleLeft;
            btnMongado.UseVisualStyleBackColor = false;
            btnMongado.Click += btnMongado_Click;
            // 
            // btnGilles
            // 
            btnGilles.BackColor = Color.FromArgb(45, 52, 70);
            btnGilles.Cursor = Cursors.Hand;
            btnGilles.Dock = DockStyle.Top;
            btnGilles.FlatAppearance.BorderSize = 0;
            btnGilles.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 80, 105);
            btnGilles.FlatStyle = FlatStyle.Flat;
            btnGilles.Font = new Font("Segoe UI", 11F);
            btnGilles.ForeColor = Color.White;
            btnGilles.ImageAlign = ContentAlignment.MiddleLeft;
            btnGilles.Location = new Point(0, 130);
            btnGilles.Name = "btnGilles";
            btnGilles.Padding = new Padding(15, 0, 0, 0);
            btnGilles.Size = new Size(220, 50);
            btnGilles.TabIndex = 2;
            btnGilles.Text = "Go to Gilles";
            btnGilles.TextAlign = ContentAlignment.MiddleLeft;
            btnGilles.UseVisualStyleBackColor = false;
            btnGilles.Click += btnGilles_Click;
            // 
            // btnNavigateToCodera
            // 
            btnNavigateToCodera.BackColor = Color.FromArgb(45, 52, 70);
            btnNavigateToCodera.Cursor = Cursors.Hand;
            btnNavigateToCodera.Dock = DockStyle.Top;
            btnNavigateToCodera.FlatAppearance.BorderSize = 0;
            btnNavigateToCodera.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 80, 105);
            btnNavigateToCodera.FlatStyle = FlatStyle.Flat;
            btnNavigateToCodera.Font = new Font("Segoe UI", 11F);
            btnNavigateToCodera.ForeColor = Color.White;
            btnNavigateToCodera.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavigateToCodera.Location = new Point(0, 80);
            btnNavigateToCodera.Name = "btnNavigateToCodera";
            btnNavigateToCodera.Padding = new Padding(15, 0, 0, 0);
            btnNavigateToCodera.Size = new Size(220, 50);
            btnNavigateToCodera.TabIndex = 1;
            btnNavigateToCodera.Text = "Go to Codera";
            btnNavigateToCodera.TextAlign = ContentAlignment.MiddleLeft;
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
            labelLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelLogo.ForeColor = Color.White;
            labelLogo.Location = new Point(0, 0);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(220, 80);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "Activity 1";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(pictureBox1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(580, 450);
            panelContent.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(panelSideMenu);
            Name = "Form1";
            Text = "Activity 1";
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
