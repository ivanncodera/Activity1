
namespace CVbuilderRose
{
    partial class PanelMain
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
            panel1 = new Panel();
            CURRICULUM = new Label();
            PanelContainer = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            panel5 = new Panel();
            listBox4 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            textBox14 = new TextBox();
            label16 = new Label();
            label14 = new Label();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            label9 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            maskedTextBox3 = new MaskedTextBox();
            button8 = new Button();
            listBox2 = new ListBox();
            label15 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label10 = new Label();
            button2 = new Button();
            label11 = new Label();
            panel3 = new Panel();
            label17 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            button10 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            textBox7 = new TextBox();
            label7 = new Label();
            panel4 = new Panel();
            button9 = new Button();
            listBox3 = new ListBox();
            button4 = new Button();
            textBox13 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(75, 44, 44);
            panel1.Controls.Add(CURRICULUM);
            panel1.Location = new Point(-120, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 37);
            panel1.TabIndex = 0;
            // 
            // CURRICULUM
            // 
            CURRICULUM.AutoSize = true;
            CURRICULUM.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CURRICULUM.ForeColor = Color.FromArgb(253, 226, 228);
            CURRICULUM.Location = new Point(278, 9);
            CURRICULUM.Name = "CURRICULUM";
            CURRICULUM.Size = new Size(169, 13);
            CURRICULUM.TabIndex = 0;
            CURRICULUM.Text = "CURRICULUM VITAE BUILDER";
            CURRICULUM.Click += CURRICULUM_Click;
            // 
            // PanelContainer
            // 
            PanelContainer.BackColor = Color.FromArgb(253, 226, 228);
            PanelContainer.Controls.Add(maskedTextBox1);
            PanelContainer.Controls.Add(pictureBox1);
            PanelContainer.Controls.Add(button7);
            PanelContainer.Controls.Add(panel5);
            PanelContainer.Controls.Add(label14);
            PanelContainer.Controls.Add(textBox12);
            PanelContainer.Controls.Add(textBox11);
            PanelContainer.Controls.Add(label9);
            PanelContainer.Controls.Add(label6);
            PanelContainer.Controls.Add(textBox6);
            PanelContainer.Controls.Add(label5);
            PanelContainer.Controls.Add(textBox5);
            PanelContainer.Controls.Add(label4);
            PanelContainer.Controls.Add(textBox4);
            PanelContainer.Controls.Add(label3);
            PanelContainer.Controls.Add(label2);
            PanelContainer.Controls.Add(textBox2);
            PanelContainer.Controls.Add(label1);
            PanelContainer.Controls.Add(textBox1);
            PanelContainer.Controls.Add(button1);
            PanelContainer.Controls.Add(panel2);
            PanelContainer.Controls.Add(panel3);
            PanelContainer.Controls.Add(panel4);
            PanelContainer.Location = new Point(0, 31);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(514, 721);
            PanelContainer.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 198);
            maskedTextBox1.Mask = "+63 000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(173, 23);
            maskedTextBox1.TabIndex = 55;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(41, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 98);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(233, 141, 172);
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(42, 116);
            button7.Name = "button7";
            button7.Size = new Size(99, 23);
            button7.TabIndex = 52;
            button7.Text = "Upload Photo";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(listBox4);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(textBox14);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(12, 553);
            panel5.Name = "panel5";
            panel5.Size = new Size(173, 153);
            panel5.TabIndex = 50;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(13, 85);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(148, 49);
            listBox4.TabIndex = 50;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(233, 141, 172);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(118, 56);
            button5.Name = "button5";
            button5.Size = new Size(43, 23);
            button5.TabIndex = 48;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkRed;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(93, 56);
            button6.Name = "button6";
            button6.Size = new Size(19, 23);
            button6.TabIndex = 51;
            button6.Text = "x";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(13, 27);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(148, 23);
            textBox14.TabIndex = 51;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 9);
            label16.Name = "label16";
            label16.Size = new Size(33, 15);
            label16.TabIndex = 47;
            label16.Text = "Skills";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(56, 421);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 45;
            label14.Text = "School Year";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(25, 351);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(148, 23);
            textBox12.TabIndex = 42;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(25, 307);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(148, 23);
            textBox11.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(76, 333);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 32;
            label9.Text = "Degree";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 157);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 27;
            label6.Text = "Profile";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(203, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(299, 23);
            textBox6.TabIndex = 26;
            textBox6.Text = "Enter your self description...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 262);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 25;
            label5.Text = "Home Address";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 239);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 23);
            textBox5.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 180);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 23;
            label4.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(203, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(299, 23);
            textBox4.TabIndex = 22;
            textBox4.Text = "Enter your job ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 221);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 21;
            label3.Text = "Contact Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 19;
            label2.Text = "Job Title";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 23);
            textBox2.TabIndex = 18;
            textBox2.Text = "Surname, Firstname, Middlename";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 38);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 17;
            label1.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 16;
            textBox1.Text = "rose@gmail.com";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 64, 129);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(424, 677);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 15;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(maskedTextBox3);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(203, 327);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 336);
            panel2.TabIndex = 47;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(13, 114);
            maskedTextBox3.Mask = "+63 000-000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(269, 23);
            maskedTextBox3.TabIndex = 56;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkRed;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(214, 157);
            button8.Name = "button8";
            button8.Size = new Size(19, 23);
            button8.TabIndex = 52;
            button8.Text = "x";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(14, 186);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(268, 139);
            listBox2.TabIndex = 49;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(118, 52);
            label15.Name = "label15";
            label15.Size = new Size(61, 15);
            label15.TabIndex = 46;
            label15.Text = "Full Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 8);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 31;
            label8.Text = "References";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(13, 26);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(268, 23);
            textBox8.TabIndex = 30;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(13, 70);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(268, 23);
            textBox9.TabIndex = 33;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(118, 96);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 34;
            label10.Text = "Position";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(233, 141, 172);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(236, 157);
            button2.Name = "button2";
            button2.Size = new Size(43, 23);
            button2.TabIndex = 37;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(95, 140);
            label11.Name = "label11";
            label11.Size = new Size(96, 15);
            label11.TabIndex = 36;
            label11.Text = "Contact Number";
            // 
            // panel3
            // 
            panel3.Controls.Add(label17);
            panel3.Controls.Add(maskedTextBox2);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(listBox1);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(204, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 146);
            panel3.TabIndex = 48;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(13, 61);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 56;
            label17.Text = "Year";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(48, 58);
            maskedTextBox2.Mask = "0000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(183, 23);
            maskedTextBox2.TabIndex = 55;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkRed;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(238, 87);
            button10.Name = "button10";
            button10.Size = new Size(19, 23);
            button10.TabIndex = 54;
            button10.Text = "x";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 49);
            listBox1.TabIndex = 48;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(233, 141, 172);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(238, 58);
            button3.Name = "button3";
            button3.Size = new Size(43, 23);
            button3.TabIndex = 47;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(13, 23);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(265, 23);
            textBox7.TabIndex = 28;
            textBox7.Text = "Enter your company...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 5);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 29;
            label7.Text = "Experience";
            // 
            // panel4
            // 
            panel4.Controls.Add(button9);
            panel4.Controls.Add(listBox3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(textBox13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(12, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(173, 267);
            panel4.TabIndex = 49;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkRed;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(93, 154);
            button9.Name = "button9";
            button9.Size = new Size(19, 23);
            button9.TabIndex = 53;
            button9.Text = "x";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(13, 187);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(148, 64);
            listBox3.TabIndex = 49;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(233, 141, 172);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(118, 154);
            button4.Name = "button4";
            button4.Size = new Size(43, 23);
            button4.TabIndex = 47;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(13, 114);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(148, 23);
            textBox13.TabIndex = 44;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 8);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 41;
            label12.Text = "Education";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 96);
            label13.Name = "label13";
            label13.Size = new Size(94, 15);
            label13.TabIndex = 43;
            label13.Text = "University Name";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // PanelMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(526, 357);
            Controls.Add(PanelContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PanelMain";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelContainer.ResumeLayout(false);
            PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // NO ACTION YET
        }

        private void btsref_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Panel panel1;
        private Label CURRICULUM;
        private Panel PanelContainer;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox7;
        private Button button2;
        private Label label11;
        private Label label10;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox12;
        private TextBox textBox11;
        private Label label13;
        private Label label15;
        private Label label14;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private Panel panel5;
        private Button button5;
        private TextBox textBox14;
        private Label label16;
        private TextBox textBox13;
        private Panel panel4;
        private Button button4;
        private Label label12;
        private Button button6;
        private ListBox listBox2;
        private ListBox listBox1;
        private ListBox listBox4;
        private ListBox listBox3;
        private PictureBox pictureBox1;
        private Button button7;
        private OpenFileDialog openFileDialog1;
        private Button button8;
        private Button button10;
        private Button button9;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label17;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
    }
}
