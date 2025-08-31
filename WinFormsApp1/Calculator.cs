using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string currentOperation = "";
        private bool isNewCalculation = true;

        public Calculator()
        {
            InitializeComponent();
            BindButtonEvents();
        }

        private void BindButtonEvents()
        {
            // Number buttons
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;
            btnDecimal.Click += NumberButton_Click;

            // Operation buttons
            btnAdd.Click += OperationButton_Click;
            btnSubtract.Click += OperationButton_Click;
            btnMultiply.Click += OperationButton_Click;
            btnDivide.Click += OperationButton_Click;

            // Other buttons
            btnEquals.Click += BtnEquals_Click;
            btnClear.Click += BtnClear_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewCalculation)
            {
                lblDisplay.Text = "";
                isNewCalculation = false;
            }

            // Handle decimal point
            if (button.Text == "." && lblDisplay.Text.Contains("."))
                return;

            // Handle zero at the beginning
            if (lblDisplay.Text == "0" && button.Text != ".")
                lblDisplay.Text = button.Text;
            else
                lblDisplay.Text += button.Text;

            // Update appropriate number label
            if (string.IsNullOrEmpty(currentOperation))
                lblFirstNumber.Text = lblDisplay.Text;
            else
                lblSecondNumber.Text = lblDisplay.Text;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // If we're in the middle of an operation, calculate result first
            if (!string.IsNullOrEmpty(currentOperation) && !string.IsNullOrEmpty(lblSecondNumber.Text))
            {
                BtnEquals_Click(sender, e);
            }

            firstNumber = double.Parse(lblDisplay.Text);
            currentOperation = button.Text;
            lblOperation.Text = currentOperation;
            isNewCalculation = true;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOperation))
                return;

            secondNumber = double.Parse(lblDisplay.Text);
            double result = 0;

            switch (currentOperation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    if (secondNumber == 0)
                    {
                        lblDisplay.Text = "Error";
                        lblResult.Text = "Cannot divide by zero";
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }

            lblResult.Text = result.ToString();
            lblDisplay.Text = result.ToString();

            // Reset for next calculation
            firstNumber = result;
            isNewCalculation = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblFirstNumber.Text = "";
            lblOperation.Text = "";
            lblSecondNumber.Text = "";
            lblResult.Text = "";
            lblDisplay.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            currentOperation = "";
            isNewCalculation = true;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}