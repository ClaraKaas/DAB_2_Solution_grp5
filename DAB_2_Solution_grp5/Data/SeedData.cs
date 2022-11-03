using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAB_2_Solution_grp5.Models;
using System.Diagnostics.Metrics;
using System.Net.Sockets;

namespace DAB_2_Solution_grp5.Data
{
    public class SeedData
    {


        public static void SeedDatabase()

        {
            var db = new MyDbContext();


            Console.WriteLine("Seeding!");



            Facility AarhusStrand= new Facility()
            {
                Name = "AarhusStrand"
            };


            Facility Navitas = new Facility()
            {
                Name = "Navitas"
            };
            db.Add(AarhusStrand);
            db.Add(Navitas);

            Activity Activity1 = new Activity()
            {
                ActivityId = ActivityId1.id,
                Time = DateTime.Now.Add(TimeSpan.FromHours(10)),
                Note = "jnjcxdzrtfyguhijokpszxrtfgyhuijokl",
                Participants = "15"


            };

            db.Add(Activity1);














        }
    }
