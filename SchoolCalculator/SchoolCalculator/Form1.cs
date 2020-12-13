using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCalculator
{
    public partial class Form1 : Form
    {
        //Entry point
        double valueResult = 0;
        string operation = "";
        bool operationPerformedCorrectly = false;


        public Form1()
        {
            InitializeComponent();
        }

        //Functions for buttons for numbers and ","
        private void button_click(object sender, EventArgs e)
        {
            if ((ResultBox.Text=="0") || (operationPerformedCorrectly))
                ResultBox.Clear();

            operationPerformedCorrectly = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!ResultBox.Text.Contains("."))
                    ResultBox.Text = ResultBox.Text + button.Text;
            }
            else
            ResultBox.Text = ResultBox.Text + button.Text;
        }

        //Functions for buttons for "+" , "-" , "x" and "/"
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (valueResult!= 0)
            {
                equalButton.PerformClick();
                operation = button.Text;
                showOperationLabel.Text = valueResult + " " + operation;
                operationPerformedCorrectly = true;
            }
            else
            {
                operation = button.Text;
                valueResult = double.Parse(ResultBox.Text);
                showOperationLabel.Text = valueResult + " " + operation;
                operationPerformedCorrectly = true;
            }
            
        }

        //Function for button "CE"
        private void clear_click(object sender, EventArgs e)
        {

            ResultBox.Text = "0";
        }

        //Function for button "C"
        private void c_click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            valueResult = 0;
        }

        //Function for button "="
        private void equal_click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    ResultBox.Text = (valueResult + double.Parse(ResultBox.Text)).ToString();
                    break;

                case "-":
                    ResultBox.Text = (valueResult - double.Parse(ResultBox.Text)).ToString();
                    break;

                case "x":
                    ResultBox.Text = (valueResult * double.Parse(ResultBox.Text)).ToString();
                    break;

                case "/":
                    ResultBox.Text = (valueResult / double.Parse(ResultBox.Text)).ToString();
                    break;

                default:
                    break;
            }
            valueResult = Double.Parse(ResultBox.Text);
            showOperationLabel.Text = "";
        }
        


    }
}
