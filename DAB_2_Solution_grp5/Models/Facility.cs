using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        //public string Bookable { get; set; }

        //public string Items { get; set; }

        public List<Activity> Activities { get; set; } 


        public MaintenanceLog MaintenanceLog { get; set; } 
        


    }
}
