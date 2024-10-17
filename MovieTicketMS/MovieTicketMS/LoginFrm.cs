using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketMS
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        //Hàm xử lý nút check show Password
        private void Login_chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            Login_txtPass.PasswordChar = Login_chkShowPass.Checked ? '\0' : '*';
        }

        //Hàm xử lý label X
        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Hàm xử lý nút Sign Up khi click vào sẽ hiện form Register
        private void Login_btnSignup_Click(object sender, EventArgs e)
        {
            RegistFrm registerFr = new RegistFrm();
            registerFr.Show();

            this.Hide();
        }

        private void Login_btnLogin_Click(object sender, EventArgs e)
        {
            if (Login_txtUserName.Text == "" || Login_txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
