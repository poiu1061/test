using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCal
{
    public partial class Form1 : Form
    {
        private enum BaseNum { DEC, OCT, HEX, BIN };
        private BaseNum currentBase = BaseNum.DEC;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ClickNum(String number)
        {
            if (CurrentVal.Text == "0")
            {
                CurrentVal.Text = number;
            }
            else
            {
                CurrentVal.Text += number;
            }
            int parsedValue = Convert.ToInt32(CurrentVal.Text, GetBaseValue());
            ChangeNo(parsedValue);
        }

        public void ClickAlp(String alphabet)
        {
            if (CurrentVal.Text == "0")
            {
                CurrentVal.Text = alphabet;
            }
            else
            {
                CurrentVal.Text += alphabet;
            }
            int parsedValue = Convert.ToInt32(CurrentVal.Text, GetBaseValue());
            ChangeNo(parsedValue);
        }


        public void Operator(String oper)
        {
            CurrentVal.Text += oper;

        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            ClickNum("0");
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            ClickNum("1");
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            ClickNum("2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            ClickNum("3");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            ClickNum("4");
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            ClickNum("5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            ClickNum("6");
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            ClickNum("7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            ClickNum("8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            ClickNum("9");
        }

        private void Btn_A_Click(object sender, EventArgs e)
        {
            ClickAlp("A");
        }

        private void Btn_B_Click(object sender, EventArgs e)
        {
            ClickAlp("B");
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            ClickAlp("C");
        }

        private void Btn_D_Click(object sender, EventArgs e)
        {
            ClickAlp("D");
        }

        private void Btn_E_Click(object sender, EventArgs e)
        {
            ClickAlp("E");
        }

        private void Btn_F_Click(object sender, EventArgs e)
        {
            ClickAlp("F");
        }

        private void Btn_Rest_Click(object sender, EventArgs e)
        {
            Operator("%");
            PreVal.Text = CurrentVal.Text;
            CurrentVal.Text = "0";
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            Operator("/");
            PreVal.Text = CurrentVal.Text;
            CurrentVal.Text = "0";
        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            Operator("*");
            PreVal.Text = CurrentVal.Text;
            CurrentVal.Text = "0";
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            Operator("+");
            PreVal.Text = CurrentVal.Text;
            CurrentVal.Text = "0";

        }


        private void btn_Minus_Click(object sender, EventArgs e)
        {
            Operator("-");
            PreVal.Text = CurrentVal.Text;
            CurrentVal.Text = "0";
        }
        private void btn_Equal_Click(object sender, EventArgs e)
        {
            if (PreVal.Text.Contains("+"))
            {

                String num1 = PreVal.Text.Replace("+", "");
                String num2 = CurrentVal.Text;


                int result = Int32.Parse(num1) + Int32.Parse(num2);
                PreVal.Text = num1 + "+" + num2 + "=";
                CurrentVal.Text = result.ToString();
                ChangeNo(int.Parse(CurrentVal.Text));
            }
            else if (PreVal.Text.Contains("-"))
            {
                String num1 = PreVal.Text.Replace("-", "");
                String num2 = CurrentVal.Text;


                int result = Int32.Parse(num1) - Int32.Parse(num2);
                PreVal.Text = num1 + "-" + num2 + "=";
                CurrentVal.Text = result.ToString();
                ChangeNo(int.Parse(CurrentVal.Text));
            }
            else if (PreVal.Text.Contains("*"))
            {
                String num1 = PreVal.Text.Replace("*", "");
                String num2 = CurrentVal.Text;


                int result = Int32.Parse(num1) * Int32.Parse(num2);
                PreVal.Text = num1 + "*" + num2 + "=";
                CurrentVal.Text = result.ToString();
                ChangeNo(int.Parse(CurrentVal.Text));
            }

            else if (PreVal.Text.Contains("/"))
            {
                String num1 = PreVal.Text.Replace("/", "");
                String num2 = CurrentVal.Text;


                int result = Int32.Parse(num1) / Int32.Parse(num2);
                PreVal.Text = num1 + "/" + num2 + "=";
                CurrentVal.Text = result.ToString();
                ChangeNo(int.Parse(CurrentVal.Text));
            }
            else if (PreVal.Text.Contains("%"))
            {
                String num1 = PreVal.Text.Replace("%", "");
                String num2 = CurrentVal.Text;


                int result = Int32.Parse(num1) % Int32.Parse(num2);
                PreVal.Text = num1 + "%" + num2 + "=";
                CurrentVal.Text = result.ToString();
                ChangeNo(int.Parse(CurrentVal.Text));
            }
        }

        private void Btn_CE_Click(object sender, EventArgs e)
        {
            CurrentVal.Text = "0";
            PreVal.Text = "0";
        }

        private void Btn_Erase_Click(object sender, EventArgs e)
        {
            if (CurrentVal.Text.Length >= 1)
            {
                CurrentVal.Text= CurrentVal.Text.Substring(0, CurrentVal.Text.Length-1);
            }
            else
            {
                CurrentVal.Text = "0";
            }
        }

        private void ChangeNo(int num)
        {
            HexNum.Text = Convert.ToString(num, 16);
            DecNum.Text = Convert.ToString(num, 10);
            OctNum.Text = Convert.ToString(num, 8);
            BinNum.Text = Convert.ToString(num, 2);
        }

        private void Btn_Hex_Click(object sender, EventArgs e)
        {
            currentBase = BaseNum.HEX;
            Btn_A.Enabled = true;
            Btn_B.Enabled = true;
            Btn_C.Enabled = true;
            Btn_D.Enabled = true;
            Btn_E.Enabled = true;
            Btn_F.Enabled = true;
        }

        private void Btn_Dec_Click(object sender, EventArgs e)
        {
            currentBase = BaseNum.DEC;
            Btn_A.Enabled = false;
            Btn_B.Enabled = false;
            Btn_C.Enabled = false;
            Btn_D.Enabled = false;
            Btn_E.Enabled = false;
            Btn_F.Enabled = false;
        }

        private void Btn_Oct_Click(object sender, EventArgs e)
        {
            currentBase = BaseNum.OCT;
            Btn_A.Enabled = false;
            Btn_B.Enabled = false;
            Btn_C.Enabled = false;
            Btn_D.Enabled = false;
            Btn_E.Enabled = false;
            Btn_F.Enabled = false;
            Btn_8.Enabled = false;
            Btn_9.Enabled = false;
        }

        private void Btn_Bin_Click(object sender, EventArgs e)
        {
            currentBase = BaseNum.BIN;
            Btn_A.Enabled = false;
            Btn_B.Enabled = false;
            Btn_C.Enabled = false;
            Btn_D.Enabled = false;
            Btn_E.Enabled = false;
            Btn_F.Enabled = false;
            for (int i = 2; i < 10; i++)
            {
                Controls["Btn_" + i].Enabled = false;
            }
        }

        private void Btn_ShiftLeft_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(CurrentVal.Text);
                int result = value << 1;

                PreVal.Text = $"{value} << 1 =";
                CurrentVal.Text = result.ToString();

                ChangeNo(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("잘못된 입력입니다.");
            }
        }

        private void Btn_ShiftRight_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(CurrentVal.Text);
                int result = value >> 1;

                PreVal.Text = $"{value} >> 1 =";
                CurrentVal.Text = result.ToString();

                ChangeNo(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("잘못된 입력입니다.");
            }
        }

        private int GetBaseValue()
        {
            switch (currentBase)
            {
                case BaseNum.BIN: return 2;
                case BaseNum.OCT: return 8;
                case BaseNum.HEX: return 16;
                default: return 10;
            }
        }


    }
}
