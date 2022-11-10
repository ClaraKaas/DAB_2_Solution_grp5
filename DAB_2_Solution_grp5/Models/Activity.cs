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
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Note { get; set; }
        public int Participants { get; set; }

        public int CitizenId { get; set; } 
        public Citizen Citizen { get; set; } 
        public int FacilityId { get; set; } 
        public Facility Facility { get; set; } 
    }
}
