﻿// <auto-generated />
using System;
using DAB_2_Solution_grp5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAB_2_Solution_grp5.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221104130017_FìxedNamingagain")]
    partial class FìxedNamingagain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"), 1L, 1);

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Participants")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("CitizenId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("ActivityId");

                    b.HasIndex("CitizenId");

                    b.HasIndex("FacilityId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Citizen", b =>
                {
                    b.Property<int>("CitizenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CitizenId"), 1L, 1);

                    b.Property<string>("CVR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CitizenId");

                    b.ToTable("Citizens");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Does_Maintenance", b =>
                {
                    b.Property<int>("Does_MaintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Does_MaintenanceId"), 1L, 1);

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<int>("MaintenanceId")
                        .HasColumnType("int");

                    b.Property<int>("PersId")
                        .HasColumnType("int");

                    b.HasKey("Does_MaintenanceId");

                    b.HasIndex("FacilityId");

                    b.HasIndex("MaintenanceId");

                    b.HasIndex("PersId");

                    b.ToTable("Does_Maintenance");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Facility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bookable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Items")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.MaintenanceLog", b =>
                {
                    b.Property<int>("MaintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaintenanceId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaintenanceId");

                    b.ToTable("MaintenanceLogs");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Personnel", b =>
                {
                    b.Property<int>("PersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersId"), 1L, 1);

                    b.HasKey("PersId");

                    b.ToTable("Personnels");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Booking", b =>
                {
                    b.HasOne("DAB_2_Solution_grp5.Models.Activity", "Activity")
                        .WithMany("Bookings")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_2_Solution_grp5.Models.Citizen", "Citizen")
                        .WithMany("Bookings")
                        .HasForeignKey("CitizenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_2_Solution_grp5.Models.Facility", "Facility")
                        .WithMany("Bookings")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Citizen");

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Does_Maintenance", b =>
                {
                    b.HasOne("DAB_2_Solution_grp5.Models.Facility", "Facility")
                        .WithMany("Does_Maintenances")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_2_Solution_grp5.Models.MaintenanceLog", "MaintenanceLog")
                        .WithMany("Does_Maintenances")
                        .HasForeignKey("MaintenanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_2_Solution_grp5.Models.Personnel", "Personnel")
                        .WithMany("Does_Maintenances")
                        .HasForeignKey("PersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");

                    b.Navigation("MaintenanceLog");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Activity", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Citizen", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Facility", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Does_Maintenances");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.MaintenanceLog", b =>
                {
                    b.Navigation("Does_Maintenances");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Personnel", b =>
                {
                    b.Navigation("Does_Maintenances");
                });
#pragma warning restore 612, 618
        }
    }
}
