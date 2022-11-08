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
                /*var cit = new Citizen
                {
                    Name = "Clara",
                    Email = "clara@gmail.com",
                    CVR = "109876543",
                    Category = "Forretning",
                    PhoneNumber = "42345677"
                };
                var cit2 = new Citizen
                {
                    Name = "Heja",
                    Email = "Heja@gmail.com",
                    CVR = "098765432",
                    Category = "Forretning",
                    PhoneNumber = "42336789"
                };
                db.Citizens.Add(cit);
                db.Citizens.Add(cit2);
                db.SaveChanges();
            }*/





                Console.WriteLine("Start");

                System.Console.WriteLine("Should we seed data? Y/n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'Y')
                {
                    SeedData.SeedDatabase();
                }


                Console.WriteLine("\n" + "Vis Opgave(a) Opgave(b), Opgave(c)");
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'a' || consoleKeyInfo.KeyChar == 'b' || consoleKeyInfo.KeyChar == 'c')
                {
                    VaelgOpgave(db, consoleKeyInfo.KeyChar);
                }
                Console.WriteLine("\n" + "Slut");





            }
        }

            static void VaelgOpgave(MyDbContext db, char c)
            { 
                 switch (c)
                {
                    case 'a':
                        OpgaveA(db);
                        break;

                    case 'b':
                        OpgaveB(db);
                        break;

                    case 'c':
                        OpgaveC(db);
                        break;

                    
                }
            }

            static void OpgaveA(MyDbContext db)

            {
                foreach (var fac in db.Facilities)
                {
                    Console.WriteLine(fac.Name + " har addressen" + fac.Address);
                }
            }

            static void OpgaveB(MyDbContext db)

            {
                    var ListOfFacilitiesSorted = db.Facilities.OrderBy(x => x.Type);
                Console.WriteLine("\nListe af Faciliteter \n");
                foreach (var fac in ListOfFacilitiesSorted)
                {
                
                    Console.WriteLine(fac.Name + " " + fac.Address + " " + fac.Type);
                }
            }


        static void OpgaveC(MyDbContext db)
        {




            var bookedfacility = from Booking in db.Set<Booking>()
                                    join Facility in db.Set<Facility>() on Booking.Facility.Name + Booking equals Facility.Name
                                    join Citizen in db.Set<Citizen>() on Booking.Citizen.Namee equals Citizen.Namee
                                    join Activity in db.Set<Activity>() on Booking.Activity.Time equals Activity.Time

                                    select new { Facility.Name, Citizen.Namee, Activity.Time };











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

