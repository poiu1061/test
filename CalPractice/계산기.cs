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
    public partial class 계산기 : Form
    {
        public 계산기()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*string strNum = display.Text += "1";
            int num = Int32.Parse(strNum);
            display.Text = num.ToString();  
            */
            ClickNum("1");
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "2";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickNum("2");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "3";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickNum("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "4";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickNum("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "5";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickNum("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "6";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickNum("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "7";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickNum("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "8";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();'
            ClickNum("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "9";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickNum("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "0";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickNum("0");
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "0";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickAlp("A");
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "0";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickAlp("B");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "0";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickAlp("C");
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "0";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickAlp("D");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "0";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickAlp("E");
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            //string strNum = display.Text += "0";
            //int num = Int32.Parse(strNum);
            //display.Text = num.ToString();
            ClickAlp("F");
        }

        private void add_Click(object sender, EventArgs e)
        {
            string strNum = display.Text +="+";
            String num = display.Text;
            display2.Text += num;
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
                ChangeNo(int.Parse(display.Text));
                display2.Text = display.Text;
            }

            else if (display2.Text.Contains("-"))
            {
                string num1 = display2.Text.Replace("-", "");
                string num2 = display.Text;


                int num = Int32.Parse(num1) - Int32.Parse(num2);
                display2.Text = num1 + "-" + num2 + "=";
                display.Text = num.ToString();
                ChangeNo(int.Parse(display.Text));
            }
            else if (display2.Text.Contains("*"))
            {
                string num1 = display2.Text.Replace("*", "");
                string num2 = display.Text;


                int num = Int32.Parse(num1) * Int32.Parse(num2);
                display2.Text = num1 + "*" + num2 + "=";
                display.Text = num.ToString();
                ChangeNo(int.Parse(display.Text));

            }

            else if (display2.Text.Contains("/"))
            {
                string num1 = display2.Text.Replace("/", "");
                string num2 = display.Text;


                double num = (double)Int32.Parse(num1) / Int32.Parse(num2);
                display2.Text = num1 + "/" + num2 + "=";
                display.Text = num.ToString();
                ChangeNo(int.Parse(display.Text));

            }

            else if (display2.Text.Contains("%"))
            {
                string num1 = display2.Text.Replace("%", "");
                string num2 = display.Text;


                double num = (double)Int32.Parse(num1) % Int32.Parse(num2);
                display2.Text = num1 + "%" + num2 + "=";
                display.Text = num.ToString();
                ChangeNo(int.Parse(display.Text));

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

        private void ClickNum(string number)
        {
            if (display.Text == "0")
            {
                display.Text = number;
            }
            else
            {
                display.Text += number;
            }
            ChangeNo(int.Parse(display.Text));
        }

        private void ClickAlp(string alp)
        {
            if (display.Text == "0")
            {
                display.Text = alp;
            }
            else
            {
                display.Text += alp;
            }
            ChangeNo(int.Parse(display.Text));
        }

        private void ChangeNo(int num)
        {
            HexNum.Text = Convert.ToString(num, 16); 
            DecNum.Text = Convert.ToString(num, 10);
            OctNum.Text = Convert.ToString(num, 8); 
            BinNum.Text = Convert.ToString(num, 2);
        }

        private void HEX_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;

            int Value = int.Parse(display.Text);
            display.Text = Convert.ToString(Value, 16).ToUpper();

        }
        


        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void DEC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;
            buttonF.Enabled = false;
        }

        private void OCT_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;
            buttonF.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void BIN_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;
            buttonF.Enabled = false;
            for(int i = 2; i < 10; i++)
            {
                Controls["button" + i].Enabled = false;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            float a = 1.34f;

            Double b = (double)a;
           
        }
    }
}
