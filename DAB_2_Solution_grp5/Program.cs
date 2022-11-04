using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using DAB_2_Solution_grp5.Data;
using DAB_2_Solution_grp5.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace DAB_2_Solution_grp5.Data
{
    class Program
    {
        static void Main()
        {
            /*
            using(var db = new MyDbContext())
            {
                
                foreach (var pc in db.Users.ToList())
                {
                    Console.WriteLine(pc);
                }
                



                    var us = new User
                {
                    Name = "Clara",
                    Email = "clara@gmail.com",
                    CVR = "109876543",
                    Category = "Forretning",
                    PhoneNumber = "42345677"
                };
                var us2 = new User
                {
                Name = "Heja",
                Email = "Heja@gmail.com",
                CVR = "098765432",
                Category = "Forretning",
                PhoneNumber = "42336789"
                };
                db.Users.Add(us);
                db.Users.Add(us2);
                db.RemoveRange(us);
                db.SaveChanges();
            }*/


            MyDbContext db = new MyDbContext();

            

            Console.WriteLine("Start");

            System.Console.WriteLine("Should we seed data? Y/n");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.KeyChar == 'Y')
            {
                SeedData.SeedDatabase();
            }
            Console.WriteLine("1");
            var facility1 = db.Facilities.ToList();
            Console.WriteLine("2");
            foreach (var i in facility1)
            {
                Console.WriteLine(string.Join(System.Environment.NewLine, facility1));
            }
                Console.WriteLine("3");
            //    foreach (var facility in facilitylist)   
            //Console.WriteLine(facility.FacilityId);

            System.Console.WriteLine("\n" + "Show all products Y/n" );
            consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.KeyChar == 'Y')
            {
                ShowAllData(db, 'X');
            }
            System.Console.WriteLine("\n" + "List all Facilities(F), Profile(U), Activities(A)");
            consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.KeyChar == 'F' || consoleKeyInfo.KeyChar == 'A' || consoleKeyInfo.KeyChar == 'U')
            {
                ShowAllData(db, consoleKeyInfo.KeyChar);
            }
            Console.WriteLine("\n" + "Slut");


            

            
        }


        private static void ShowAllData(MyDbContext db, char c)
        { 
             switch (c)
            {
                case 'X':
                    ListAllFacilities(db);
                    ListAllProfile(db);
                    ListAllActivities(db);
                    break;

                case 'F':
                    ListAllFacilities(db);
                    break;

                case 'U':
                    ListAllProfile(db);
                    break;

                case 'A':
                    ListAllActivities(db);
                    break;
            }
        }
        private static void ListAllFacilities(MyDbContext db)
        {
            var fac = db.Facilities.Include(b => b.FacilityId).ToList();

            
            {
                Console.WriteLine("Her er alle" + fac ) ;
            }
        }

        private static void ListAllProfile(MyDbContext db)
        {
            foreach (var user in db.Users)
            {
                Console.WriteLine(user.ProfileId);
            }
        }

        private static void ListAllActivities(MyDbContext db)
        {
            foreach (var pc in db.Activities.Include(p => p.Bookings).ToList())
            {
                Console.WriteLine(pc);
            }
        }

    }
}
