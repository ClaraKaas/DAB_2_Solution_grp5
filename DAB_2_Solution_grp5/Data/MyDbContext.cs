using System;
using System.Collections.Generic;
using System.Linq;
using DAB_2_Solution_grp5.Models;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;



namespace DAB_2_Solution_grp5.Data
{
    public class MyDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=127.0.0.1, 1433; Database=DAB2_1; User ID=sa;Password=Rasm223j. ;TrustServerCertificate=true; ApplicationIntent=ReadWrite;");
        }

        public DbSet<Facility>? Facilities { get; set; }
        public DbSet<Citizen>? Citizens { get; set; }
        public DbSet<Activity>? Activities { get; set; }
        public DbSet<Personnel>? Personnels { get; set; }
        public DbSet<MaintenanceLog>? MaintenanceLogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Citizen
            modelBuilder.Entity<Citizen>().HasKey(a => a.CitizenId);
            modelBuilder.Entity<Citizen>().HasData(
                 new Citizen { CitizenId = 1, Namee = "Clara", Email = "Clara@gmail.com", CVR = "12103023031", Category = "Business", PhoneNumber = "25252525" },
                 new Citizen { CitizenId = 2, Namee = "Clara", Email = "clara@gmail.com", CVR = "109876543", Category = "Forretning", PhoneNumber = "42345677" },
                 new Citizen { CitizenId = 3, Namee = "Heja", Email = "Heja@gmail.com", CVR = "098765432", Category = "Forretning", PhoneNumber = "42336789" });


            // Personnel
            modelBuilder.Entity<Personnel>().HasKey(b => b.PersId);
            modelBuilder.Entity<Personnel>().HasData(
                 new Personnel { PersId = 1 },
                 new Personnel { PersId = 2 });

            // Facility
            modelBuilder.Entity<Facility>().HasKey(b => b.FacilityId);
            modelBuilder.Entity<Facility>().HasData(
                new Facility { FacilityId = 1, Name = "AarhusStrand", Address = "Strand 9", Type = "Privat", Description = "God plads", /*Bookable = "Ja", Items = "offentlig toillet"*/},
                new Facility { FacilityId = 2, Name = "Navitas", Address = "Møllevej 15", Type = "forretning", Description = "Den ligger ved haven kanten" /*Bookable = "Ja", //Items = "Bord og stoler"*/},
                new Facility { FacilityId = 3, Name = "Aarhus Universitet", Address = "Finlandsgade 22", Type = "forretning", Description = "Skole" /*Bookable = "Ja",//Items = "Bord og stoler"*/ },
                new Facility { FacilityId = 4, Name = "Storcenter Nord", Address = "Finlandsgade 15", Type = "Shopping", Description = "Ligger i aarhus N" /*//Bookable = "Ja",  //Items = "Butikker"*/});

            


            // Activity
            modelBuilder.Entity<Activity>().HasKey(b => b.ActivityId);
            modelBuilder.Entity<Activity>().HasData(
                 new Activity { ActivityId = 1, Time = DateTime.Now.Add(TimeSpan.FromHours(10)), Note = "jnjcxdzrtfyguhijokpszxrtfgyhuijokl", Participants = 5, CitizenId = 1,FacilityId = 1 },
                 new Activity { ActivityId = 2, Time = DateTime.Now.Add(TimeSpan.FromHours(15)), Note = "jnjcxdzrtfyguhijokpszxrtfgyhuijokl", Participants = 10, CitizenId = 2, FacilityId = 2 });

            modelBuilder.Entity<Activity>()
                .HasOne(ba => ba.Citizen)
                .WithMany(b => b.Activities)
                .HasForeignKey(ba => ba.CitizenId);

            modelBuilder.Entity<Activity>()
                .HasOne(ba => ba.Facility)
                .WithMany(a => a.Activities)
                .HasForeignKey(ba => ba.FacilityId);

            // MaintenanceLog
            modelBuilder.Entity<MaintenanceLog>().HasKey(b => b.MaintenanceId);
            modelBuilder.Entity<MaintenanceLog>().HasData(
                new MaintenanceLog { MaintenanceId = 1, Description = "Ved ikke", Date = DateTime.Now.Add(TimeSpan.FromHours(15)), FacilityId = 1, PersId = 1 },
                new MaintenanceLog { MaintenanceId = 2, Description = "gegikvep", Date = DateTime.Now.Add(TimeSpan.FromHours(15)), FacilityId = 2, PersId = 2 });

            modelBuilder.Entity<MaintenanceLog>()
                .HasOne(ba => ba.Personnel)
                .WithMany(a => a.MaintenaceLogs)
                .HasForeignKey(ba => ba.PersId);

            modelBuilder.Entity<MaintenanceLog>()
                .HasOne(ba => ba.Facility)
                .WithMany(a => a.MaintenanceLogs)
                .HasForeignKey(ba => ba.FacilityId);

        }

    }
}