﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    public class Participant
    {
        public string Cpr { get; set; }

        public int ActivityId { get; set; }
        public List<Activity> Activities { get; set; } 
    }
}
