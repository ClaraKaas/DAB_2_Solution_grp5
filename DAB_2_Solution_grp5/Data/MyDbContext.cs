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
        //public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=127.0.0.1,1433;Database=DAB2;User Id=sa;Password=Rasm223j.;TrustServerCertificate=True");
        }

        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<MaintenanceLog> MaintenanceLogs { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Profile
            modelBuilder.Entity<Profile>().HasKey(a => a.ProfileId);

            modelBuilder.Entity<Profile>().HasData(new Profile { ProfileId = 2022, Name = "Clara", Email = "Clara@.com", CVR = "109812732123", Category = "forretning", PhoneNumber = "123959214" });
            // Activity
            modelBuilder.Entity<Activity>().HasKey(b => b.ActivityId);
            
            // Facility
            modelBuilder.Entity<Facility>().HasKey(b => b.FacilityId);
            
            // MaintenanceLog
            modelBuilder.Entity<MaintenanceLog>().HasKey(b => b.MaintenanceId);
            
            // Personnel
            modelBuilder.Entity<Personnel>().HasKey(b => b.PersId);

            // Booking
            modelBuilder.Entity<Booking>()
                .HasOne(ba => ba.Profile)
                .WithMany(b => b.Bookings)
                .HasForeignKey(ba => ba.ProfileId);
            modelBuilder.Entity<Booking>()
                .HasOne(ba => ba.Activity)
                .WithMany(a => a.Bookings)
                .HasForeignKey(ba => ba.ActivityId);
            modelBuilder.Entity<Booking>()
                .HasOne(ba => ba.Facility)
                .WithMany(a => a.Bookings)
                .HasForeignKey(ba => ba.FacilityId);
            

            // Does_Maintenance
            modelBuilder.Entity<Does_Maintenance>()
                .HasOne(ba => ba.Facility)
                .WithMany(a => a.Does_Maintenances)
                .HasForeignKey(ba => ba.FacilityId);
            modelBuilder.Entity<Does_Maintenance>()
                .HasOne(ba => ba.MaintenanceLog)
                .WithMany(a => a.Does_Maintenances)
                .HasForeignKey(ba => ba.MaintenanceId);
            modelBuilder.Entity<Does_Maintenance>()
                .HasOne(ba => ba.Personnel)
                .WithMany(b => b.Does_Maintenances)
                .HasForeignKey(ba => ba.PersId);

        

        }
        
    }
}