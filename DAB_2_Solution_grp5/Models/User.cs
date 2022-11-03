using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CVR { get; set; }
        public string Category { get; set; }
        public string PhoneNumber { get; set; }

        public List<Booking> Bookings { get; set; }
    
    }
}
