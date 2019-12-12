using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MovieTimeDTO
    {
     public int MovieTimeID { get; set; }
    public int RoomID { get; set; }
	public int MovieID { get; set; }
	public DateTime StartTime { get; set; }
	public DateTime EndTime { get; set; }
    }
}
