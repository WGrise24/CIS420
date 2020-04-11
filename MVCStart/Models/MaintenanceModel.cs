using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStart.Models
{
    public class MaintenanceModel
    {
        public int MaintenanceId { get; set; }
        public string MachineName { get; set; }
        public string SerialNum { get; set; }
        public string Comments { get; set; }

        //public int MaintenenceID { get; set; }
        //public int UofLNum { get; set; }
        //public string MachineName { get; set; }
        //public string SerialNumber { get; set; }
        //public string Upholstery { get; set; }
        //public string WeightStacks { get; set; }
        //public string NutsBolts { get; set; }
        //public string AdjusterPins { get; set; }
        //public string GuideRods { get; set; }
        //public string HandleFootPlates { get; set; }
        //public string Comments { get; set; }
    }
}