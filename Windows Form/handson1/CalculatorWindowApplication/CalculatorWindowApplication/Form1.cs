using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalculatorWindowApplication
{
    public partial class Form1 : Form
    {
       //double input1 = 0;
      //  double input2 = 0;
        double result=0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
            radioButton_add.Checked = true;
            operation = "+";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

       

        private void button_clear_Click(object sender, EventArgs e)
        {
            txtinput1.Text = "";
            txtinput2.Text = "";
            txtresult.Text = "";

        }

        private void radioButton_add_CheckedChanged(object sender, EventArgs e)
        {
            operation = "+";    
        }

        private void radioButton_subtract_CheckedChanged(object sender, EventArgs e)
        {
            operation="-";
        }

        private void radioButton_multiply_CheckedChanged(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void radioButton_division_CheckedChanged(object sender, EventArgs e)
        {
            operation = "/";
        }

        private void button_result_Click(object sender, EventArgs e)
        {

            string num1 = txtinput1.Text;
            string num2 = txtinput2.Text;

            string regex = @"^[0-9]+$";

            if (Regex.Match(num1, regex).Success && Regex.Match(num2, regex).Success)
            {
               int input1 = Convert.ToInt32(num1);
                int input2 = Convert.ToInt32(num2);
                switch (operation)
                {
                    case "+":
                        result = input1 + input2;
                        txtresult.Text = result.ToString();
                        break;
                    case "-":
                        result = input1 - input2;
                        txtresult.Text = result.ToString();
                        break;
                    case "*":
                        result = input1 * input2;
                        txtresult.Text = result.ToString();
                        break;
                    case "/":
                         if(input2!=0)
                        {
                            result = input1 / input2;
                            txtresult.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("input2 not be zero");
                        }
                        break;

                }

            }
            else
            {
                MessageBox.Show(" Please enter valid input for the operands ");
            }

        }
    }
}
