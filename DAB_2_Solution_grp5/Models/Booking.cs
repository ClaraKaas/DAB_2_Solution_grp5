﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int facilityId { get; set; }
        public Facility Facility { get; set; }

    }
}
