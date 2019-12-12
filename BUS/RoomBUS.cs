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
    public class RoomBUS
    {
        private RoomDAO dao = new RoomDAO();
        public DataTable GetRoomAvailable()
        {
            return dao.GetAllRoomAvailable();
        }
    }
}
