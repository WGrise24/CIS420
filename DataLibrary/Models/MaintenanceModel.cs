using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class MaintenanceModel
    {
        public int MaintenanceId { get; set; }
        public string MachineName { get; set; }
        public string SerialNum { get; set; }
        public string Comments { get; set; }
    }
}
