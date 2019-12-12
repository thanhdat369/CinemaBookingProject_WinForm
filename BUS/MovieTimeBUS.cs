using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class MovieTimeBUS
    {
        MovieTimeDAO dao = new MovieTimeDAO();

        public bool InsertNewMovieTime(MovieTimeDTO movieTimeDTO)
        {
            if (!dao.Is_Conflict_Time(movieTimeDTO))
            {
                return dao.InsertNewMovieTime(movieTimeDTO);
            }
            else
            {
                throw new Exception("Conflict time");
            }

        }

        public List<MovieTimeDTO> GetMovieTimeByMovie(DateTime date, int MovieID)
        {
            return dao.GetMovieTimeByMovie(date, MovieID);
        }
    }
}
