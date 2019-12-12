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

namespace CinemaProject.CinemaUser
{
    public partial class BookingButton : UserControl
    {
        private MovieTimeDTO movieTimeDTO; 
        public BookingButton(MovieTimeDTO dto)
        {
            InitializeComponent();
            this.movieTimeDTO = dto;
            String startTime = dto.StartTime.ToString("HH:mm");
            this.btnBook.Text = startTime;
        }

        private void BookingButton_Load(object sender, EventArgs e)
        {

        }
    }
}
