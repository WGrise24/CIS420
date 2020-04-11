using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class LockersModel
    {
        public int LockerNum { get; set; }
        public Guid UserId { get; set; }
        public DateTime LockerPayDate { get; set; }
        public int RoomId { get; set; }
        public bool Gender { get; set; }
    }
}
