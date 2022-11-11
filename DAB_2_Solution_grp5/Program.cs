using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using DAB_2_Solution_grp5.Data;
using DAB_2_Solution_grp5.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Net.Sockets;

namespace DAB_2_Solution_grp5.Data
{
    class Program
    {
        static void Main()
        {
            MyDbContext db = new MyDbContext();

            {
                Console.WriteLine("Start");

                Console.WriteLine("Should we seed data? Y/n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'Y')
                {
                    SeedData.SeedDatabase();
                }

                Console.WriteLine("\n" + "Vis Opgave2_1(a) Opgave2_2(b), Opgave2_3(c), Opgave3_2(d)");
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'a' || consoleKeyInfo.KeyChar == 'b' || consoleKeyInfo.KeyChar == 'c')
                {
                    VaelgOpgave(db, consoleKeyInfo.KeyChar);
                }

                else
                {
                    return;
                }
                Console.WriteLine("\n" + "Slut");
                }
        }

        static void VaelgOpgave(MyDbContext db, char c)
        {
            switch (c)
            {
                case 'a':
                    Opgave2_1(db);
                    break;

                case 'b':
                    Opgave2_2(db);
                    break;

                case 'c':
                    Opgave2_3(db);
                    break;
                case 'd':
                    Opgave3_2(db);
                    break;
            }
        }

        static void Opgave2_1(MyDbContext db)
        {
            foreach (var fac in db.Facilities)
            {
                Console.WriteLine(fac.Name + " har addressen" + fac.Longitude + ", " + fac.Latitude);
            }
        }

        static void Opgave2_2(MyDbContext db)
        {
            var ListOfFacilitiesSorted = db.Facilities.OrderBy(x => x.Type);
            Console.WriteLine("\nListe af Faciliteter \n");
            foreach (var fac in ListOfFacilitiesSorted)
            {

                Console.WriteLine(fac.Name + " " + fac.Longitude + ", " + fac.Latitude + " " + fac.Type);
            }
        }

        static void Opgave2_3(MyDbContext db)
        {
            
            var alist = db.Activities.ToList();
            foreach(var activity in alist)
            {
                Console.WriteLine( 
                    $"\n {db.Facilities.First(u => u.FacilityId == activity.FacilityId).Name} | " +
                    $"{db.Citizens.First(u => u.CitizenId == activity.CitizenId).Namee} | " +
                    $"{db.Activities.First(u => u.ActivityId == activity.ActivityId).StartDate} " +
                    $"{db.Activities.First(u => u.ActivityId == activity.ActivityId).StartTime} - " +
                    $"{db.Activities.First(u => u.ActivityId == activity.ActivityId).EndDate} " +
                    $"{db.Activities.First(u => u.ActivityId == activity.ActivityId).EndTime}");
            }
                        
            
        }

        static void Opgave3_2(MyDbContext db)
        {
            var bList = db.Activities.Include(a => a.Participants);
            foreach (var activity in bList)
            {
                Console.WriteLine($"{activity.ActivityId}");
                var temp = activity.Participants;
                //Console.WriteLine(temp[0].cpr);
                foreach (var activityParticipant in temp)
                {
                    Console.WriteLine($"{activityParticipant.Cpr}");
                }

            }


            /*
            var plist = db.Participants.ToList();
            foreach (var part in plist)
            {
                Console.WriteLine(
                    $"\n {db.Activities.First(u => u.ActivityId == part.ActivityId).ActivityId} | " +
                    part.Cpr  );
            }*/

        }
    }
}


