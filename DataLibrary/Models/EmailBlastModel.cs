using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class EmailBlastModel
    {
        public DateTime EmailDate { get; set; }
        public string UserEmail { get; set; }
        public string ManagerEmail { get; set; }
    }
}
