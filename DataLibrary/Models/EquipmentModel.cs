using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class EquipmentModel
    {
        public int SerialNum { get; set; }
        public int RoomId { get; set; }
        public bool EquipmentType { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
