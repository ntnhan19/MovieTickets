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
    public partial class BookTheatersFrm : Form
    {
        DBMovieTicket movieTicketDB = new DBMovieTicket();
        public BookTheatersFrm(int movieID)
        {
            InitializeComponent();
            LoadMovieDetails(movieID);
            LoadCinemaData();
            LoadShowTimes(movieID); 
        }

        private void LoadShowTimes(int movieID)
        {
            

        }

        private void LoadCinemaData()
        {
            var cinemas = movieTicketDB.Cinemas.ToList();
            cmbRapChieu.DataSource = cinemas;
            cmbRapChieu.DisplayMember = "CinemaName";
            cmbRapChieu.ValueMember = "CinemaID";
        }

        private void LoadMovieDetails(int movieID)
        {
            
        }

        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BookSeatsFrm datGheFrm = new BookSeatsFrm();
            datGheFrm.Show();

            this.Hide();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            ShowingMoviesFrm phimDangChieuFrm = new ShowingMoviesFrm();
            phimDangChieuFrm.Show();

            this.Hide();
        }
    }
}
