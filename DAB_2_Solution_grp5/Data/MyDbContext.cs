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
            optionsBuilder.UseSqlServer("Data Source=127.0.0.1,1433;Database=DAB2_1;User Id=sa;Password=Rasm223j.;TrustServerCertificate=True");
        }

        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<MaintenanceLog> MaintenanceLogs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Does_Maintenance> Does_Maintenances { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Citizen
            modelBuilder.Entity<Citizen>().HasKey(a => a.CitizenId);

            
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
                .HasOne(ba => ba.Citizen)
                .WithMany(b => b.Bookings)
                .HasForeignKey(ba => ba.CitizenId);
            modelBuilder.Entity<Activity>()
                .HasOne(ba => ba.Booking)
                .WithOne(a => a.Activity)
                .HasForeignKey<Booking>(ba => ba.ActivityId);
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