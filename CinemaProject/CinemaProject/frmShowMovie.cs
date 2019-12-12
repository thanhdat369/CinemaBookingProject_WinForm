using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using CinemaProject.CinemaUser;
using DTO;

namespace CinemaProject
{
    public partial class frmShowMovie : Form
    {
        MovieBUS movieBUS = new MovieBUS();
        DateTime dateTime;
        public frmShowMovie()
        {
            InitializeComponent();
            dateTime = dtpkMain.Value = DateTime.Now;
            dtpkMain.MinDate = dateTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<MovieDTO> movies = movieBUS.GetMovieByDay(dateTime);
            foreach(MovieDTO mv in movies)
            {
                MovieShowPanel movieShow = new MovieShowPanel(mv,dateTime);
                this.flowLayoutPanel.Controls.Add(movieShow);
            }
        }
    }
}
