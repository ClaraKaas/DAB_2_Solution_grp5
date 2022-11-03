using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    public class MaintenanceLog
    {
        public int MaintenanceId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public List<Does_Maintenance> Does_Maintenances { get; set; }

    }
}
