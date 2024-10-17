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
    public partial class BookSeatsFrm : Form
    {
        public BookSeatsFrm()
        {
            InitializeComponent();
        }

        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            BookTheatersFrm chonRap_TG = new BookTheatersFrm();
            chonRap_TG.Show();

            this.Hide();
        }

        private void btnSeats_Click(object sender, EventArgs e)
        {
            Button btnSeats = (Button)sender;

            if (btnSeats.BackColor == Color.WhiteSmoke)
            {
                btnSeats.BackColor = Color.Yellow;
            }
            else if (btnSeats.BackColor == Color.FromArgb(255, 192, 128))
            {
                btnSeats.BackColor = Color.Yellow;
            }
            else if (btnSeats.BackColor == Color.LightCoral)
            {
                btnSeats.BackColor = Color.Yellow;
            }
        }
    }
}
