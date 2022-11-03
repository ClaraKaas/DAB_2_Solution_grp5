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
            optionsBuilder.UseSqlServer("REPLACE_WITH_A_USEFULL_CONNECTION_STRING");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User
            modelBuilder.Entity<User>().HasKey(a => a.UserId);

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
                .HasOne(ba => ba.User)
                .WithMany(b => b.Bookings)
                .HasForeignKey(ba => ba.UserId);
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