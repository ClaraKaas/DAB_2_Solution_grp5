using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    public class Does_Maintenance
    {
        public int Does_MaintenanceId { get; set; }


        public int FacilityId { get; set; }

        public Facility Facility { get; set; }

        public int MaintenanceId { get; set; }
        public MaintenanceLog MaintenanceLog { get; set; }

        public int PersId { get; set; }
        public Personnel Personnel { get; set; }
    }
}
