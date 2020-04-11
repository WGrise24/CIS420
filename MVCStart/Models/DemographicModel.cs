using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStart.Models
{
    public class DemographicModel
    {
       public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string RoomId { get; set; }
        public string UserAccount { get; set; } // what is this ? 
        public int Female { get; set; }
        public int Male { get; set; }
        public int Caucasian { get; set; }
        public int AfricanAmerican { get; set; }
        public int Other { get; set; }
    }
}