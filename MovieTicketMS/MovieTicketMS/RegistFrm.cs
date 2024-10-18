using MovieTicketMS.MovieTicket;
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
        DBMovieTicket movieTicketDB = new DBMovieTicket();
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

        //Hàm xử lý label X đóng form
        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Hàm xử lý nút Register
        private void Regis_btnRegister_Click(object sender, EventArgs e)
        {
            //Nếu ô bị trống sẽ hiện thông báo 
            if (Regis_txtUserName.Text == "" || Regis_txtPass.Text == "" || Regis_txtCfirPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Nếu ô mật khẩu không khớp với ô xác nhận mật khẩu sẽ hiện thông báo
            if (Regis_txtPass.Text != Regis_txtCfirPass.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp, vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Nếu ô mật khẩu < 8 ký tự sẽ hiện thông báo
            if (Regis_txtPass.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự");
                return;
            }

            DBMovieTicket movieTicketDB = new DBMovieTicket();

            var existingUser = movieTicketDB.Users
                .Where(u => u.UserName.ToLower() == Regis_txtUserName.Text.Trim().ToLower())
                .FirstOrDefault();

            //Kiểm tra UserName đã có chưa
            //Nếu có rồi sẽ hiện thông báo đã tồn tại
            if(existingUser != null)
            {
                MessageBox.Show($"UserName {Regis_txtUserName.Text.Trim()} đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }


            //Nếu chưa có sẽ tiến hành tạo mới User
            User usernew = new User
            {
                UserName = Regis_txtUserName.Text.Trim(),
                Password = Regis_txtPass.Text,
                DateRegis = DateTime.Now,
                    
            };
            movieTicketDB.Users.Add(usernew);
            movieTicketDB.SaveChanges();
            MessageBox.Show("Đăng ký thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginFrm loginFr = new LoginFrm();
            loginFr.Show();

            this.Hide();
        }


        //Hàm xử lý nút Sign In khi click vào sẽ hiện form Log In
        private void Regis_btnSignin_Click(object sender, EventArgs e)
        {
            LoginFrm loginFr = new LoginFrm();
            loginFr.Show();

            this.Hide();
        }
    }
}
