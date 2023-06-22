using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operatorSign = string.Empty;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        //private void button15_Click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    textBox_result.Text = button.Text;

        //    //textBox_result.Text = string.Empty;
        //    //textBox_result.Text
        //}

        private void Click(object sender, EventArgs e)
        {
            if((textBox_result.Text == "0") || (isOperationPerformed))
                textBox_result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox_result.Text.Contains("."))
                {
                    textBox_result.Text += button.Text;
                }
            }
            else
            {
                textBox_result.Text += button.Text;
            }
            //textBox_result.Text += button.Text;
        }

        private void Operator_button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorSign = button.Text;
            result = Double.Parse(textBox_result.Text);
            currentDisplay.Text = result + " " + operatorSign;
            isOperationPerformed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Length > 0)
            {
                textBox_result.Text = textBox_result.Text.Substring(0, textBox_result.Text.Length - 1);
            }
            else
            {
                textBox_result.Text = "0";
            }
            //textBox_result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            result = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (operatorSign)
            {
                case "+":
                    textBox_result.Text = (result + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (result - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (result * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (result / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox_result.Text);
            currentDisplay.Text = "";
        }           
    }
}
