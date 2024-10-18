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
    public partial class ShowingMoviesFrm : Form
    {
        DBMovieTicket movieTicketDB = new DBMovieTicket();
        public ShowingMoviesFrm()
        {
            InitializeComponent();
        }

        private void ShowingMoviesFrm_Load(object sender, EventArgs e)
        {
            List<Movy> movies = movieTicketDB.Movies.ToList();
        }

        private void tstrDangNhap_Click(object sender, EventArgs e)
        {
            LoginFrm loginFr = new LoginFrm();
            loginFr.Show();

            this.Hide();
        }

        //Hàm xử lý nút đặt ngay sẽ hiện ra form chọn rạp và thời gian
        private void btnDatNgay_Click(object sender, EventArgs e)
        {
            BookTheatersFrm chonRap_TG = new BookTheatersFrm();
            chonRap_TG.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
