using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class MovieTimeDAO
    {
        private SqlConnection conn = new SqlConnection(ConnectionString.ConnectionStr);
        public bool InsertNewMovieTime(MovieTimeDTO dto)
        {
            bool check = false;
            try
            {
                String sql =
                  "Insert into MovieTime(MovieID,RoomID,StartTime,EndTime) values (@MovieID, @RoomID, @StartTime, @EndTime)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MovieID", dto.MovieID);
                cmd.Parameters.AddWithValue("@RoomID", dto.RoomID);
                cmd.Parameters.AddWithValue("@StartTime", dto.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", dto.EndTime);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                check = cmd.ExecuteNonQuery() > 0;
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
            return check;
        }

        public bool Is_Conflict_Time(MovieTimeDTO dto)
        {
            bool check = false;
            try
            {
                String sql = "CHECK_CONFLICT_TIME";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoomID", dto.RoomID);
                cmd.Parameters.AddWithValue("@StartTime", dto.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", dto.EndTime);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                check = dr.HasRows;
                if (dr != null) dr.Close();
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
            return check;
        }

        public List<MovieTimeDTO> GetMovieTimeByMovie(DateTime date,int MovieID)
        {
            List<MovieTimeDTO> ListMovie = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String sql = "GET_TIME_OF_MOVIE_PROC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Time", date);
                cmd.Parameters.AddWithValue("@MovieID", MovieID);
                SqlDataReader reader = cmd.ExecuteReader();
                ListMovie = new List<MovieTimeDTO>();
                while (reader.Read())
                {
                    int MovieTimeID = reader.GetInt32(reader.GetOrdinal("MovieTimeID"));
                    DateTime StartTime = reader.GetDateTime(reader.GetOrdinal("StartTime"));
                    DateTime EndTime = reader.GetDateTime(reader.GetOrdinal("EndTime"));
                    MovieTimeDTO dTO = new MovieTimeDTO()
                    {
                        MovieID = MovieID,
                        MovieTimeID = MovieTimeID,
                        StartTime = StartTime,
                        EndTime = EndTime
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
    }
}
