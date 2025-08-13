using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace RoseCalcu
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Location = new Point(12, 52);
            button1.Name = "button1";
            button1.Size = new Size(53, 41);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Location = new Point(71, 52);
            button2.Name = "button2";
            button2.Size = new Size(53, 41);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btn;
            // 
            // button3
            // 
            button3.BackColor = Color.Pink;
            button3.Location = new Point(130, 52);
            button3.Name = "button3";
            button3.Size = new Size(53, 41);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn;
            // 
            // button4
            // 
            button4.BackColor = Color.Pink;
            button4.Location = new Point(12, 99);
            button4.Name = "button4";
            button4.Size = new Size(53, 41);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btn;
            // 
            // button5
            // 
            button5.BackColor = Color.Pink;
            button5.Location = new Point(71, 99);
            button5.Name = "button5";
            button5.Size = new Size(53, 41);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btn;
            // 
            // button6
            // 
            button6.BackColor = Color.Pink;
            button6.Location = new Point(130, 99);
            button6.Name = "button6";
            button6.Size = new Size(53, 41);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btn;
            // 
            // button7
            // 
            button7.BackColor = Color.Pink;
            button7.Location = new Point(12, 146);
            button7.Name = "button7";
            button7.Size = new Size(53, 41);
            button7.TabIndex = 7;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btn;
            // 
            // button8
            // 
            button8.BackColor = Color.Pink;
            button8.Location = new Point(71, 146);
            button8.Name = "button8";
            button8.Size = new Size(53, 41);
            button8.TabIndex = 8;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btn;
            // 
            // button9
            // 
            button9.BackColor = Color.Pink;
            button9.Location = new Point(130, 146);
            button9.Name = "button9";
            button9.Size = new Size(53, 41);
            button9.TabIndex = 9;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = false;
            button9.Click += btn;
            // 
            // button10
            // 
            button10.Location = new Point(12, 202);
            button10.Name = "button10";
            button10.Size = new Size(53, 41);
            button10.TabIndex = 10;
            button10.Text = "Clear";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Pink;
            button11.Location = new Point(71, 202);
            button11.Name = "button11";
            button11.Size = new Size(53, 41);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += btn;
            // 
            // button12
            // 
            button12.BackColor = Color.Red;
            button12.Location = new Point(12, 249);
            button12.Name = "button12";
            button12.Size = new Size(171, 21);
            button12.TabIndex = 12;
            button12.Text = "Close";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(189, 52);
            button13.Name = "button13";
            button13.Size = new Size(41, 34);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btn;
            // 
            // button14
            // 
            button14.Location = new Point(189, 92);
            button14.Name = "button14";
            button14.Size = new Size(41, 34);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btn;
            // 
            // button15
            // 
            button15.Location = new Point(189, 132);
            button15.Name = "button15";
            button15.Size = new Size(41, 34);
            button15.TabIndex = 15;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btn;
            // 
            // button16
            // 
            button16.Location = new Point(189, 172);
            button16.Name = "button16";
            button16.Size = new Size(41, 34);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += btn;
            // 
            // button17
            // 
            button17.Location = new Point(189, 212);
            button17.Name = "button17";
            button17.Size = new Size(41, 58);
            button17.TabIndex = 17;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(130, 202);
            button18.Name = "button18";
            button18.Size = new Size(53, 41);
            button18.TabIndex = 18;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = true;
            button18.Click += btn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 278);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
    }
}
