using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    public class Activity
    {
        
        public int ActivityId { get; set; }
        public DateTime Time { get; set; }
        public string Note { get; set; }
        public int Participants { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
