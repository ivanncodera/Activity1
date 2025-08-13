using System;
using System.Data;
using System.Windows.Forms;

namespace RoseCalcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();

            Button button = (Button)sender;
            string buttonText = button.Text;
            {
                if (char.IsDigit(buttonText[0]) || buttonText == "+" || buttonText == "-" || buttonText == "*" || buttonText == "/" || buttonText == ".")
                {
                    if (buttonText == ".")
                    {
                        string[] parts = textBox1.Text.Split(new char[] { '+', '-', '*', '/' });
                        string lastPart = parts[parts.Length - 1];

                        if (lastPart.Contains("."))
                        {
                            return;
                        }
                    }

                    textBox1.Text += buttonText;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string equation = textBox1.Text;
                var result = new DataTable().Compute(equation, null);
                textBox1.Text = result.ToString();
            }
            catch
            {

                MessageBox.Show("Error: Invalid equation ");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
