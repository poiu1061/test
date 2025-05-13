using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPassword = password.Text;

            if (userId.Equals("admin") && userPassword.Equals("1234"))
            {
                MessageBox.Show("로그인에 성공하였습니다.");
                // Proceed to the calculator functionality
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.");
            }
        }
    }
}
