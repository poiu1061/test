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
        private bool IsResult = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        public void Operator(string oper)
        {
            PreVal.Text += CurrentVal.Text + oper;
            CurrentVal.Text = "0";
        }

        public void ClickNum(string number)
        {
            if (CurrentVal.Text == "0" || IsResult)
            {
                CurrentVal.Text = number;
                IsResult = false;
            }
            else
            {
                CurrentVal.Text += number;
            }
            int parsedValue = Convert.ToInt32(CurrentVal.Text, GetBaseValue());
            ChangeNo(parsedValue);
        }

        public void ClickAlp(string alphabet)
        {
            if (CurrentVal.Text == "0" || IsResult)
            {
                CurrentVal.Text = alphabet;
                IsResult = false;
            }
            else
            {
                CurrentVal.Text += alphabet;
            }
            int parsedValue = Convert.ToInt32(CurrentVal.Text, GetBaseValue());
            ChangeNo(parsedValue);
        }

        // 숫자 버튼들
        private void Btn_0_Click(object sender, EventArgs e) => ClickNum("0");
        private void Btn_1_Click(object sender, EventArgs e) => ClickNum("1");
        private void Btn_2_Click(object sender, EventArgs e) => ClickNum("2");
        private void Btn_3_Click(object sender, EventArgs e) => ClickNum("3");
        private void Btn_4_Click(object sender, EventArgs e) => ClickNum("4");
        private void Btn_5_Click(object sender, EventArgs e) => ClickNum("5");
        private void Btn_6_Click(object sender, EventArgs e) => ClickNum("6");
        private void Btn_7_Click(object sender, EventArgs e) => ClickNum("7");
        private void Btn_8_Click(object sender, EventArgs e) => ClickNum("8");
        private void Btn_9_Click(object sender, EventArgs e) => ClickNum("9");

        // A~F 버튼들 (16진수용)
        private void Btn_A_Click(object sender, EventArgs e) => ClickAlp("A");
        private void Btn_B_Click(object sender, EventArgs e) => ClickAlp("B");
        private void Btn_C_Click(object sender, EventArgs e) => ClickAlp("C");
        private void Btn_D_Click(object sender, EventArgs e) => ClickAlp("D");
        private void Btn_E_Click(object sender, EventArgs e) => ClickAlp("E");
        private void Btn_F_Click(object sender, EventArgs e) => ClickAlp("F");

        // 연산자 버튼들
        private void Btn_Rest_Click(object sender, EventArgs e) => Operator("%");
        private void btn_Div_Click(object sender, EventArgs e) => Operator("/");
        private void btn_Mul_Click(object sender, EventArgs e) => Operator("*");
        private void btn_Plus_Click(object sender, EventArgs e) => Operator("+");
        private void btn_Minus_Click(object sender, EventArgs e) => Operator("-");

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = PreVal.Text + CurrentVal.Text;//연산자
                int baseVal = GetBaseValue();//진수
                string decExpression = ConvertToDecimalExpression(expression, baseVal);// 진수에 맞는 연산자변환

                var result = new DataTable().Compute(decExpression, "");
                int intResult = Convert.ToInt32(result);
                PreVal.Text = expression + "=";

                if (currentBase == BaseNum.BIN)
                    CurrentVal.Text = Convert.ToString(intResult, 2);
                else if (currentBase == BaseNum.OCT)
                    CurrentVal.Text = Convert.ToString(intResult, 8);
                else if (currentBase == BaseNum.HEX)
                    CurrentVal.Text = Convert.ToString(intResult, 16).ToUpper();
                else
                    CurrentVal.Text = intResult.ToString();

                ChangeNo(intResult);
                IsResult = true;
            }
            catch
            {
                MessageBox.Show("수식 오류 또는 지원하지 않는 입력입니다.");
            }
        }

        private void Btn_CE_Click(object sender, EventArgs e)
        {
            CurrentVal.Text = "0";
            PreVal.Text = "";
            IsResult = false;
        }

        private void Btn_Erase_Click(object sender, EventArgs e)
        {
            if (CurrentVal.Text.Length > 1)
                CurrentVal.Text = CurrentVal.Text.Substring(0, CurrentVal.Text.Length - 1);
            else
                CurrentVal.Text = "0";
        }

        private void ChangeNo(int num)
        {
            HexNum.Text = Convert.ToString(num, 16).ToUpper();
            DecNum.Text = Convert.ToString(num, 10);
            OctNum.Text = Convert.ToString(num, 8);
            BinNum.Text = Convert.ToString(num, 2);
        }

        // 진법 전환 버튼들
        private void Btn_Hex_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(CurrentVal.Text, GetBaseValue());
            currentBase = BaseNum.HEX;
            ResetButton();
            Btn_A.Enabled = Btn_B.Enabled = Btn_C.Enabled = Btn_D.Enabled = Btn_E.Enabled = Btn_F.Enabled = true;
            CurrentVal.Text = Convert.ToString(value, 16).ToUpper();
        }

        private void Btn_Dec_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(CurrentVal.Text, GetBaseValue());
            currentBase = BaseNum.DEC;
            ResetButton();
            Btn_A.Enabled = Btn_B.Enabled = Btn_C.Enabled = Btn_D.Enabled = Btn_E.Enabled = Btn_F.Enabled = false;
            CurrentVal.Text = Convert.ToString(value, 10);
        }

        private void Btn_Oct_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(CurrentVal.Text, GetBaseValue());
            currentBase = BaseNum.OCT;
            ResetButton();
            Btn_A.Enabled = Btn_B.Enabled = Btn_C.Enabled = Btn_D.Enabled = Btn_E.Enabled = Btn_F.Enabled = false;
            Btn_8.Enabled = Btn_9.Enabled = false;
            CurrentVal.Text = Convert.ToString(value, 8);
        }

        private void Btn_Bin_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(CurrentVal.Text, GetBaseValue());
            currentBase = BaseNum.BIN;
            ResetButton();
            Btn_A.Enabled = Btn_B.Enabled = Btn_C.Enabled = Btn_D.Enabled = Btn_E.Enabled = Btn_F.Enabled = false;
            for (int i = 2; i < 10; i++)
                Controls["Btn_" + i].Enabled = false;
            CurrentVal.Text = Convert.ToString(value, 2);
        }

        private void Btn_ShiftLeft_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(CurrentVal.Text, 2);
                int result = value << 1;
                PreVal.Text = $"{value} << 1 =";
                CurrentVal.Text = Convert.ToString(result, 2);
                ChangeNo(result);
            }
            catch { MessageBox.Show("잘못된 입력입니다."); }
        }

        private void Btn_ShiftRight_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(CurrentVal.Text, 2);
                int result = value >> 1;
                PreVal.Text = $"{value} >> 1 =";
                CurrentVal.Text = Convert.ToString(result, 2);
                ChangeNo(result);
            }
            catch { MessageBox.Show("잘못된 입력입니다."); }
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

        private void ResetButton()
        {
            Btn_A.Enabled = Btn_B.Enabled = Btn_C.Enabled = Btn_D.Enabled = Btn_E.Enabled = Btn_F.Enabled = false;
            for (int i = 0; i <= 9; i++)
                Controls["Btn_" + i].Enabled = true;
        }

        private string ConvertToDecimalExpression(string expression, int baseVal)
        {
            if (baseVal == 10) return expression;

            StringBuilder result = new StringBuilder();
            string num = "";

            foreach (char ch in expression)
            {
                if (char.IsDigit(ch) || (baseVal == 16 && "ABCDEF".Contains(char.ToUpper(ch))))
                {
                    num += ch;
                }
                else
                {
                    if (!string.IsNullOrEmpty(num))
                    {
                        int decVal = Convert.ToInt32(num, baseVal);
                        result.Append(decVal);
                        num = "";
                    }
                    result.Append(ch);
                }
            }

            if (!string.IsNullOrEmpty(num))
            {
                int decVal = Convert.ToInt32(num, baseVal);
                result.Append(decVal);
            }

            return result.ToString();
        }
    }
}
