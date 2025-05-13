using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strNum = display.Text += "1";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "2";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "3";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "4";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "5";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "6";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "7";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "8";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "9";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "0";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string strNum = display.Text +="+";
            String num = display.Text;
            display2.Text = num;
            display.Text = "0";

           
        }

        private void display2_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (display2.Text.Contains("+")){
                string num1 = display2.Text.Replace("+","");
                string num2 = display.Text;
               

                int num = Int32.Parse(num1) + Int32.Parse(num2);
                display2.Text = num1+  "+" + num2 + "=";
                display.Text = num.ToString();
            }

            else if (display2.Text.Contains("-"))
            {
                string num1 = display2.Text.Replace("-", "");
                string num2 = display.Text;


                int num = Int32.Parse(num1) - Int32.Parse(num2);
                display2.Text = num1 + "-" + num2 + "=";
                display.Text = num.ToString();
            }
            else if (display2.Text.Contains("*"))
            {
                string num1 = display2.Text.Replace("*", "");
                string num2 = display.Text;


                int num = Int32.Parse(num1) * Int32.Parse(num2);
                display2.Text = num1 + "*" + num2 + "=";
                display.Text = num.ToString();
            }

            else if (display2.Text.Contains("/"))
            {
                string num1 = display2.Text.Replace("/", "");
                string num2 = display.Text;


                double num = (double)Int32.Parse(num1) / Int32.Parse(num2);
                display2.Text = num1 + "/" + num2 + "=";
                display.Text = num.ToString();
            }

            else if (display2.Text.Contains("%"))
            {
                string num1 = display2.Text.Replace("%", "");
                string num2 = display.Text;


                double num = (double)Int32.Parse(num1) % Int32.Parse(num2);
                display2.Text = num1 + "%" + num2 + "=";
                display.Text = num.ToString();
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "-";
            String num = display.Text;
            display2.Text = num;
            display.Text = "0";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "*";
            String num = display.Text;
            display2.Text = num;
            display.Text = "0";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            string strNum = display.Text += "/";
            String num = display.Text;
            display2.Text = num;
            display.Text = "0";
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            display.Text = "0";
            display2.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 1)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
            else
            {
                display.Text = "0";
            }
        }

        private void res_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += "%";
            String num = display.Text;
            display2.Text = num;
            display.Text = "0";
        }
    }
}
