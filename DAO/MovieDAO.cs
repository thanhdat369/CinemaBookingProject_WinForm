using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class MovieDAO
    {
        private SqlConnection conn = new SqlConnection(ConnectionString.ConnectionStr);


        public List<MovieDTO> GetMovieByDay(DateTime date)
        {
            List<MovieDTO> ListMovie = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String sql = "GET_MOVIE_BY_DAY_PROC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Time", date);
                SqlDataReader reader = cmd.ExecuteReader();
                ListMovie = new List<MovieDTO>();
                while (reader.Read())
                {
                    int MovieID = reader.GetInt32(reader.GetOrdinal("MovieID"));
                    string MovieName = reader.GetString(reader.GetOrdinal("MovieName"));
                    string MovieDescription = reader.GetString(reader.GetOrdinal("MovieDescription"));
                    int duration = reader.GetInt32(reader.GetOrdinal("MovieDuration"));
                    string ImgLink = reader.GetString(reader.GetOrdinal("ImageLink"));
                    MovieDTO dTO = new MovieDTO()
                    {
                        MovieID = MovieID,
                        MovieName = MovieName,
                        MovieDescription = MovieDescription,
                        MovieDuration = duration,
                        ImageLink = ImgLink
                    };
                    ListMovie.Add(dTO);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return ListMovie;
        }

        public DataTable GetMoviesAvailable()
        {
            DataTable dt = null;
            try
            {
                String sql = "Select MovieID,MovieName,MovieDescription,MovieDuration,isAvailable,ImageLink from Movie where IsAvailable = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                da.Fill(dt);
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }

    }
}
