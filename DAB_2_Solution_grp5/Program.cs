﻿using System.Linq;
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

                Console.WriteLine("\n" + "Vis Opgave2_1(a) Opgave2_2(b), Opgave2_3(c)");
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
            }
        }

        static void Opgave2_1(MyDbContext db)
        {
            foreach (var fac in db.Facilities)
            {
                /*Console.WriteLine(fac.Name + " har addressen" + fac.Longitude + ", " + fac.Latitude);*/
            }
        }

        static void Opgave2_2(MyDbContext db)
        {
            var ListOfFacilitiesSorted = db.Facilities.OrderBy(x => x.Type);
            Console.WriteLine("\nListe af Faciliteter \n");
            foreach (var fac in ListOfFacilitiesSorted)
            {

                /*Console.WriteLine(fac.Name + " " + fac.Longitude + ", " + fac.Latitude + " " + fac.Type);*/
            }
        }

        static void Opgave2_3(MyDbContext db)
        {
            
                        var blist = db.Activities.ToList();
                        foreach(var bookings in blist)
                        {
                            Console.WriteLine( 
                                $"\n {db.Facilities.First(u => u.FacilityId == bookings.FacilityId).Name} | {db.Citizens.First(u => u.CitizenId == bookings.CitizenId).Namee} | {db.Activities.First(u => u.ActivityId == bookings.ActivityId).StartDate} {db.Activities.First(u => u.ActivityId == bookings.ActivityId).StartTime}  - {db.Activities.First(u => u.ActivityId == bookings.ActivityId).EndDate} " +
                                $" {db.Activities.First(u => u.ActivityId == bookings.ActivityId).EndTime}");
                        }
                        
            /*
            var Bookedfacility = from Booking in db.Set<Booking>()
                                 join Facility in db.Set<Facility>() on Booking.FacilityId equals Facility.FacilityId
                                 join Citizen in db.Set<Citizen>() on Booking.CitizenId equals Citizen.CitizenId
                                 join Activity in db.Set<Activity>() on Booking.ActivityId equals Activity.ActivityId

                                 select new { Booking, Facility, Citizen, Activity };

            foreach (var asss in Bookedfacility)
            {

                Console.WriteLine(" Room with Id  " + "\n" + .FacilityId
                                  + "is reserved from "
                                  + Citizen.Namee
                                  + " to "
                                  + .Activity.Time
                                  + "\n");

                Console.WriteLine("\n");


            }*/










            /*

                        static void OpgaveC(MyDbContext db)

                        {       
                                var ListOfFacilitiesSorted = db.Facilities.OrderBy(x => x.Type);

                        var n = db.Bookings
                            .Include(book => book.Facility.Name)
                            //.ThenInclude(fac => fac.Name)
                            .Include(book => book.Citizen.Name)
                            //.ThenInclude(cit => cit.Name)
                            .Include(book => book.Activity.Time)
                            //.ThenInclude(act => act.Time)
                            .ToList();

                            foreach (var list in n)
                            {
                                Console.WriteLine(list.Citizen.Name + list.Facility.Name + list.Activity.Time);
                            }
                        }

                        /*
                                    private static void ListAllFacilities(MyDbContext db)
                                    {
                                        var fac = db.Facilities.Include(b => b.FacilityId).ToList();


                                        {
                                            Console.WriteLine("Her er alle" + fac ) ;
                                        }
                                    }

                                    private static void ListAllCitizen(MyDbContext db)
                                    {
                                        foreach (var user in db.Citizens)
                                        {
                                            Console.WriteLine(user.CitizenId);
                                        }
                                    }

                                    private static void ListAllActivities(MyDbContext db)
                                    {
                                        foreach (var pc in db.Activities.Include(p => p.Bookings).ToList())
                                        {
                                            Console.WriteLine(pc);
                                        }

                    System.Console.WriteLine("\n" + "Show all products Y/n" );
                        consoleKeyInfo = Console.ReadKey();
                        if (consoleKeyInfo.KeyChar == 'Y')
                        {
                            ShowAllData(db, 'X');
                        }
                                    }*/
        }

    }
}


