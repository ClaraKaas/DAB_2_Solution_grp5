using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAB_2_Solution_grp5.Models;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Net;

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
                FacilityID = 1234567,
                Name = "AarhusStrand",
                Address = "Strand 9",
                Type = "Privat",
                Description = "God plads",
                Bookable = "Ja",
                Items = "offentlig toillet"

            };

            Facility Navitas = new Facility()
            {
                FacilityID = 35899387,
                Name = "Navitas",
                Address = "Møllevej 15",
                Type = "forretning",
                Description = "Den ligger ved haven kanten",
                Bookable = "Ja",
                Items = "Bord og stoler"

            };
            db.Add(AarhusStrand);
            db.Add(Navitas);

            Activity Activity1 = new Activity()
            {
                ActivityId = 1,
                Time = DateTime.Now.Add(TimeSpan.FromHours(10)),
                Note = "jnjcxdzrtfyguhijokpszxrtfgyhuijokl",
                Participants = 5,


            };
            Activity Activity2 = new Activity()
            {
                ActivityId = 2,
                Time = DateTime.Now.Add(TimeSpan.FromHours(15)),
                Note = "jnjcxdzrtfyguhijokpszxrtfgyhuijokl",
                Participants = 10,

            };
            db.Add(Activity1);
            db.Add(Activity2);


            User User1 = new User()
            {
                UserID = 2022,
                Name = "Clara",
                Email = "clara@gmail.com",
                CVR = "109876543",
                Category = "Forretning",
                PhoneNumber = "42345677"
            };


            User User2 = new User()
            {
                UserID = 2030,
                Name = "Heja",
                Email = "Heja@gmail.com",
                CVR = "098765432",
                Category = "Forretning",
                PhoneNumber = "42336789"
            };

            db.Add(User1);
            db.Add(User2);


            Booking booking1 = new Booking()
            {
                BookingId = 12,
                ActivityId = 1,
                UserId = 2022,
                FacilityId = 1234567

            };

            Booking booking2 = new Booking()
            {

                BookingId = 12,
                ActivityId = 1,
                UserId = 2022,
                FacilityId = 1234567


            };











        }
    }
