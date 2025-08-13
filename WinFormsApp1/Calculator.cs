using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        private double value = 0;
        private string operation = "";
        private bool operationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization when the form loads
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes in the display
        }

        private void btn(object sender, EventArgs e)
        {
            // Get clicked button
            Button button = (Button)sender;

            // If the textbox is 0 or an operation was just performed, clear it
            if (textBox1.Text == "0" || operationPerformed)
            {
                textBox1.Clear();
                operationPerformed = false;
            }

            // If the button is an operator
            if (button.Text == "+" || button.Text == "-" || button.Text == "*" || button.Text == "/")
            {
                // Store the current value and operation
                value = double.Parse(textBox1.Text);
                operation = button.Text;
                operationPerformed = true;
            }
            // If the button is a number or decimal point
            else
            {
                // Don't allow multiple decimal points
                if (button.Text == "." && textBox1.Text.Contains("."))
                    return;
                
                textBox1.Text += button.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Clear button
            textBox1.Text = "0";
            value = 0;
            operation = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Equals button
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    // Check for division by zero
                    if (double.Parse(textBox1.Text) != 0)
                    {
                        textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Error";
                    }
                    break;
                default:
                    break;
            }
            value = double.Parse(textBox1.Text);
            operation = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Close button
            this.Close();
        }
    }
}