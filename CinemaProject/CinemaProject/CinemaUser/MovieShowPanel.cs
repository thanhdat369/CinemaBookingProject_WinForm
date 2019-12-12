using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace CinemaProject.CinemaUser
{
    public partial class MovieShowPanel : UserControl
    {
        public DateTime dateTime { get; set; }
        private MovieDTO movieDTO; 
        public MovieShowPanel(MovieDTO dto,DateTime date)
        {
            InitializeComponent();
            this.lblNameContext.Text = dto.MovieName;
            this.lblDescriptionContext.Text = dto.MovieDescription;
            this.lblDurationContext.Text = dto.MovieDuration.ToString();
            this.pictrureBoxFilm.ImageLocation = dto.ImageLink;
            this.movieDTO = dto;
            this.dateTime = date;
            LoadComponent();
        }

        private void LoadComponent()
        {
            MovieTimeBUS movieTimeBUS = new MovieTimeBUS();
            List<MovieTimeDTO> movieTimes = movieTimeBUS.GetMovieTimeByMovie(dateTime,movieDTO.MovieID);

            foreach(MovieTimeDTO dto in movieTimes)
            {
                BookingButton bk = new BookingButton(dto);
                this.flowPanelBooking.Controls.Add(bk);
            }
            MessageBox.Show(movieTimes.Count.ToString());
        }

    }
}
