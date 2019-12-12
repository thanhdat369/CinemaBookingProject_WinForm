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
    public class RoomDAO
    {
        private SqlConnection conn = new SqlConnection(ConnectionString.ConnectionStr);
        public DataTable GetAllRoomAvailable()
        {
            DataTable dt = null;
            try
            {
                String sql = "SELECT RoomID,RoomName,RoomDescription FROM Room Where IsAvailable = 1";
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
