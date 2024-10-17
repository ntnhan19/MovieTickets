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
    public partial class RegistFrm : Form
    {
        public RegistFrm()
        {
            InitializeComponent();
        }

        //Hàm xử lý nút check Show Password
        private void Regis_chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            Regis_txtPass.PasswordChar = Regis_chkShowPass.Checked ? '\0' : '*';
            Regis_txtCfirPass.PasswordChar = Regis_chkShowPass.Checked ? '\0' : '*';
        }

        //Hàm xử lý label X
        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Regis_btnRegister_Click(object sender, EventArgs e)
        {
            if (Regis_txtUserName.Text == "" || Regis_txtPass.Text == "" || Regis_txtCfirPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regis_txtPass.Text != Regis_txtCfirPass.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp, vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regis_txtPass.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự");
            }
        }


        //Hàm xử lý nút Sign In khi click vào sẽ hiện form Log In
        private void Regis_btnSignin_Click(object sender, EventArgs e)
        {
            LoginFrm loginFr = new LoginFrm();
            loginFr.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
