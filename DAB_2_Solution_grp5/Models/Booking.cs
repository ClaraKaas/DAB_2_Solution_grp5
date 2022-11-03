using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    internal class Booking
    {
        public int BookingID { get; set; }

        public int ActivityID { get; set; }
        public Activity Activity { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int facilityID { get; set; }
        public Facility Facility { get; set; }

    }
}
