using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string currentOperation = "";
        private bool isNewCalculation = true;

        private readonly Dictionary<string, Func<double, double, double>> operations = new()
        {
            { "+", (x, y) => x + y },
            { "-", (x, y) => x - y },
            { "×", (x, y) => x * y },
            { "÷", (x, y) => x / y }
        };

        public Calculator()
        {
            InitializeComponent();
            BindButtonEvents();
        }

        private void BindButtonEvents()
        {
            Button[] numberButtons = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnDecimal };
            foreach (var btn in numberButtons)
                btn.Click += NumberButton_Click;
            Button[] operationButtons = { btnAdd, btnSubtract, btnMultiply, btnDivide };
            foreach (var btn in operationButtons)
                btn.Click += OperationButton_Click;
            btnEquals.Click += BtnEquals_Click;
            btnClear.Click += BtnClear_Click;
            btnBackspace.Click += BtnBackspace_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button button) return;
            if (isNewCalculation)
            {
                lblDisplay.Text = "";
                isNewCalculation = false;
            }
            if (button.Text == "." && lblDisplay.Text.Contains('.'))
                return;
            lblDisplay.Text = lblDisplay.Text == "0" && button.Text != "." 
                ? button.Text 
                : lblDisplay.Text + button.Text;
            if (string.IsNullOrEmpty(currentOperation))
                lblFirstNumber.Text = lblDisplay.Text;
            else
                lblSecondNumber.Text = lblDisplay.Text;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button button) return;
            if (!string.IsNullOrEmpty(currentOperation) && !string.IsNullOrEmpty(lblSecondNumber.Text))
                BtnEquals_Click(sender, e);
            if (lblDisplay.Text == "Error")
                return;
            if (double.TryParse(lblDisplay.Text, out double value))
            {
                firstNumber = value;
                currentOperation = button.Text;
                lblOperation.Text = currentOperation;
                isNewCalculation = true;
            }
            else
                DisplayError("Invalid number");
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOperation) || lblDisplay.Text == "Error")
                return;
            if (!double.TryParse(lblDisplay.Text, out double value))
            {
                DisplayError("Invalid number");
                return;
            }
            
            secondNumber = value;

            try
            {
                if (currentOperation == "÷" && secondNumber == 0)
                {
                    DisplayError("Cannot divide by zero");
                    return;
                }
                double result = operations[currentOperation](firstNumber, secondNumber);
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    DisplayError("Result out of range");
                    return;
                }
                lblResult.Text = result.ToString();
                lblDisplay.Text = result.ToString();
                firstNumber = result;
                isNewCalculation = true;
            }
            catch
            {
                DisplayError("Calculation error");
            }
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

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "Error" || isNewCalculation)
                return;
            lblDisplay.Text = lblDisplay.Text.Length switch
            {
                1 => "0",
                2 when lblDisplay.Text[0] == '-' => "0",
                _ => lblDisplay.Text[..^1]
            };
            if (string.IsNullOrEmpty(currentOperation))
                lblFirstNumber.Text = lblDisplay.Text;
            else
                lblSecondNumber.Text = lblDisplay.Text;

            if (lblDisplay.Text is "." or "-" or "-.")
                lblDisplay.Text = "0";
        }

        private void DisplayError(string message)
        {
            lblDisplay.Text = "Error";
            lblResult.Text = message;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}