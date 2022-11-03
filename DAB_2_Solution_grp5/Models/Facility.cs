using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    public class Facility
    {
        public int FacilityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Type { get; set; }
        public string Description { get; set; }

        public string Bookable { get; set; }

        public string Items { get; set; }

        public List<Booking> Bookings { get; set; }
        public List<Does_Maintenance> Does_Maintenances { get; set; }


    }
}
