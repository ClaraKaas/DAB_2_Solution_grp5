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
            // Personnel
            modelBuilder.Entity<Personnel>().HasKey(b => b.PersId);
            // Activity
            modelBuilder.Entity<Activity>().HasKey(b => b.ActivityId);
            // MaintenanceLog
            modelBuilder.Entity<MaintenanceLog>().HasKey(b => b.MaintenanceId);

            // Facility
            modelBuilder.Entity<Facility>().HasKey(b => b.FacilityId);
            
        
            // Activity
            modelBuilder.Entity<Activity>()
                .HasOne(ba => ba.Citizen)
                .WithMany(b => b.Activities)
                .HasForeignKey(ba => ba.CitizenId);

            modelBuilder.Entity<Activity>()
                .HasOne(ba => ba.Facility)
                .WithMany(a => a.Activities)
                .HasForeignKey(ba => ba.FacilityId);

            // Facility

            modelBuilder.Entity<Facility>()
                .HasOne(ba => ba.MaintenanceLog)
                .WithOne(a => a.Facility)
                .HasForeignKey<MaintenanceLog>(ba => ba.FacilityId);

            // MaintenanceLog
            modelBuilder.Entity<MaintenanceLog>()
                .HasOne(ba => ba.Personnel)
                .WithMany(a => a.MaintenaceLogs)
                .HasForeignKey(ba => ba.PersId);
        }
        
    }
}