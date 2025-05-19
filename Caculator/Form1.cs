using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool operation_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 1;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 2;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 3;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 4;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 5;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 6;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 7;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 8;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 9;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += ".";
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += ;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 1;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 1;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 1;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string strNum = AftNum.Text += 1;
            int num = Int32.Parse(strNum);
            AftNum.Text = num.ToString();
        }

        private void buttonCle_Click(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {

        }

        private void buttonRest_Click(object sender, EventArgs e)
        {

        }

        private void buttonCan_Click(object sender, EventArgs e)
        {

        }

        private void PMC_Click(object sender, EventArgs e)
        {

        }

        private void PreNum_Click(object sender, EventArgs e)
        {

        }
    }
}
