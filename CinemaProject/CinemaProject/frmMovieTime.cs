using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace CinemaProject
{
    public partial class frmMovieTime : Form
    {
        private int duration = 0;
        private MovieTimeBUS movieTimeBUS = new MovieTimeBUS();
        public frmMovieTime()
        {
            InitializeComponent();
            InitComponent();
        }

        private void InitComponent()
        {
            MovieBUS movieBus = new MovieBUS();
            DataTable dtMovie = movieBus.GetMoviesAvailable();
            this.cmbMovie.DataSource = dtMovie;
            this.cmbMovie.DisplayMember = "MovieName";

            RoomBUS roomBus = new RoomBUS();
            DataTable dtRoom = roomBus.GetRoomAvailable();
            this.cmbRoom.DataSource = dtRoom;
            this.cmbRoom.DisplayMember = "RoomName";

            this.dtpkDate.MinDate = DateTime.Now.Date;
            this.dtpkStartTime.Value = DateTime.Now;
        }

        private void CmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMovie.SelectedIndex != -1)
            {
                DataRow data = ((DataRowView)cmbMovie.SelectedItem).Row;
                duration = Convert.ToInt32(data["MovieDuration"]);
                this.dtpkEndTime.Value = dtpkStartTime.Value.AddMinutes((double)duration);
            }
        }

        private MovieTimeDTO GetMovieTimeDTO()
        {
            MovieTimeDTO movieTimeDTO = null;
            bool check = true;
            if (cmbMovie.SelectedIndex == -1 || cmbRoom.SelectedIndex == -1)
                check = false;
            if (check)
            {
                DataRow dataMovieRow = ((DataRowView)cmbMovie.SelectedItem).Row;
                int idMovie = Convert.ToInt32(dataMovieRow["MovieID"]);

                DataRow dataRoomRow = ((DataRowView)cmbRoom.SelectedItem).Row;
                int idRoom = Convert.ToInt32(dataRoomRow["RoomID"]);

                DateTime StartTime = this.dtpkStartTime.Value;
                DateTime EndTime = this.dtpkEndTime.Value;

                movieTimeDTO = new MovieTimeDTO()
                {
                    MovieID = idMovie,
                    RoomID = idRoom,
                    StartTime = StartTime,
                    EndTime = EndTime
                };
            }
            else
            {
                MessageBox.Show("Please choose input correct");
            }
            return movieTimeDTO;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MovieTimeDTO movieTimeDTO = GetMovieTimeDTO();
            try
            {
                if (movieTimeDTO != null)
                {
                    bool checkInsert = movieTimeBUS.InsertNewMovieTime(movieTimeDTO);
                    if (checkInsert)
                    {
                        MessageBox.Show("Add Success");
                    }
                    else
                    {
                        MessageBox.Show("Add Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Conflict time"))
                {
                    MessageBox.Show($"Conflict time in room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DtpkDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime myDateTime = dtpkDate.Value.Date
                + this.dtpkStartTime.Value.TimeOfDay;
            this.dtpkStartTime.Value = myDateTime;
            this.dtpkEndTime.Value = myDateTime.AddMinutes((double)duration);
        }
    }

}
