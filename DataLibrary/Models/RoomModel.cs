using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class RoomModel
    {
        public int RoomId { get; set; }
        public string Location { get; set; }
        public bool ReserveStatus { get; set; }
    }
}
