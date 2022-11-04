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


            Console.WriteLine("\n" + "Seeding!");



            Facility AarhusStrand = new Facility()
            {
                Name = "AarhusStrand",
                Address = "Strand 9",
                Type = "Privat",
                Description = "God plads",
                Bookable = "Ja",
                Items = "offentlig toillet"

            };

            Facility Navitas = new Facility()
            {

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
      
                Time = DateTime.Now.Add(TimeSpan.FromHours(15)),
                Note = "jnjcxdzrtfyguhijokpszxrtfgyhuijokl",
                Participants = 10,

            };
            db.Add(Activity1);
            db.Add(Activity2);


            User User1 = new User()
            {
    
                Name = "Clara",
                Email = "clara@gmail.com",
                CVR = "109876543",
                Category = "Forretning",
                PhoneNumber = "42345677"
            };


            User User2 = new User()
            {
             
                Name = "Heja",
                Email = "Heja@gmail.com",
                CVR = "098765432",
                Category = "Forretning",
                PhoneNumber = "42336789"
            };

            db.Add(User1);
            db.Add(User2);


            Personnel Personnel1 = new Personnel()
            {    };

            Personnel Personnel2 = new Personnel()
            {

            };

            db.Add(Personnel1);
            db.Add(Personnel2);

            MaintenanceLog MaintenanceLog1 = new MaintenanceLog()
            {

                Description = "Ved ikke",
                Date = DateTime.Now.Add(TimeSpan.FromHours(15)),

            };

            MaintenanceLog MaintenanceLog2 = new MaintenanceLog()
            {

     
                Description = "gegikvep",
                Date = DateTime.Now.Add(TimeSpan.FromHours(15)),

            };
            db.Add(MaintenanceLog1);
            db.Add(MaintenanceLog2);


            Console.WriteLine("Seeding completed successfully!");

            db.SaveChanges();

            Console.WriteLine("Changes saved");

        }




    }
}