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
        public ShowingMoviesFrm()
        {
            InitializeComponent();
        }

        private void tstrDangNhap_Click(object sender, EventArgs e)
        {
            LoginFrm loginFr = new LoginFrm();
            loginFr.Show();

            this.Hide();
        }

        private void btnDatNgay_Click(object sender, EventArgs e)
        {
            BookTheatersFrm chonRap_TG = new BookTheatersFrm();
            chonRap_TG.Show();

            this.Hide();
        }
    }
}
