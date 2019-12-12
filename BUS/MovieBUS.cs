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
    public class MovieBUS
    {
        public List<MovieDTO> GetMovieByDay(DateTime date)
        {
            try
            {
                MovieDAO movieDAO = new MovieDAO();
                return movieDAO.GetMovieByDay(date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetMoviesAvailable()
        {
            try
            {
                MovieDAO movieDAO = new MovieDAO();
                return movieDAO.GetMoviesAvailable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

