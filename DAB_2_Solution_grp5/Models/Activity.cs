using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    internal class Activity
    {
        public int ActivityId { get; set; }
        public DateTime Time { get; set; }
        public string Note { get; set; }
        public int Participants { get; set; }
    }
}
