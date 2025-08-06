using System;
using System.Windows.Forms;

namespace CV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeOvalPictureBox();
        }

        private void InitializeOvalPictureBox()
        {
            // Ensure the image file path is valid and has an extension
            string imagePath = "Mypic.jpg"; // Replace with the correct file name and extension

            OvalPictureBox ovalPictureBox = new OvalPictureBox();
            ovalPictureBox.Size = new System.Drawing.Size(150, 150);
            ovalPictureBox.Location = new System.Drawing.Point(50, 50);
            ovalPictureBox.BackColor = System.Drawing.Color.LightBlue;
            ovalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                ovalPictureBox.Image = System.Drawing.Image.FromFile(imagePath);
            }
            catch (System.IO.FileNotFoundException)
            {
            }

            this.Controls.Add(ovalPictureBox);
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
