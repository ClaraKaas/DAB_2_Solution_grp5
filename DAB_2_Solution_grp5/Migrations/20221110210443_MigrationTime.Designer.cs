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
    [Migration("20221110210443_MigrationTime")]
    partial class MigrationTime
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

                    b.Property<int>("CitizenId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Participants")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ActivityId");

                    b.HasIndex("CitizenId");

                    b.HasIndex("FacilityId");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            ActivityId = 1,
                            CitizenId = 3,
                            EndTime = new DateTime(2022, 11, 11, 10, 4, 42, 714, DateTimeKind.Local).AddTicks(7031),
                            FacilityId = 4,
                            Note = "jnjcxdzrtfyguhijokpszxrtfgyhuijokl",
                            Participants = 5,
                            StartTime = new DateTime(2022, 11, 11, 8, 4, 42, 714, DateTimeKind.Local).AddTicks(6982)
                        },
                        new
                        {
                            ActivityId = 2,
                            CitizenId = 1,
                            EndTime = new DateTime(2022, 11, 11, 15, 4, 42, 714, DateTimeKind.Local).AddTicks(7040),
                            FacilityId = 2,
                            Note = "jnjcxdzrtfyguhijokpszxrtfgyhuijokl",
                            Participants = 10,
                            StartTime = new DateTime(2022, 11, 11, 13, 4, 42, 714, DateTimeKind.Local).AddTicks(7036)
                        });
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

                    b.Property<string>("Namee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CitizenId");

                    b.ToTable("Citizens");

                    b.HasData(
                        new
                        {
                            CitizenId = 1,
                            CVR = "12103023031",
                            Category = "Business",
                            Email = "Clara@gmail.com",
                            Namee = "Clara",
                            PhoneNumber = "25252525"
                        },
                        new
                        {
                            CitizenId = 2,
                            CVR = "109876543",
                            Category = "Forretning",
                            Email = "Rasmus@gmail.com",
                            Namee = "Rasmus",
                            PhoneNumber = "42345677"
                        },
                        new
                        {
                            CitizenId = 3,
                            CVR = "098765432",
                            Category = "Forretning",
                            Email = "Heja@gmail.com",
                            Namee = "Heja",
                            PhoneNumber = "42336789"
                        });
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Facility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityId");

                    b.ToTable("Facilities");

                    b.HasData(
                        new
                        {
                            FacilityId = 1,
                            Description = "God plads",
                            Latitude = 2.1740300000000001,
                            Longitude = 41.403379999999999,
                            Name = "AarhusStrand",
                            Type = "Privat"
                        },
                        new
                        {
                            FacilityId = 2,
                            Description = "Den ligger ved haven kanten",
                            Latitude = 34.556600000000003,
                            Longitude = 32.344499999999996,
                            Name = "Navitas",
                            Type = "Forretning"
                        },
                        new
                        {
                            FacilityId = 3,
                            Description = "Skole",
                            Latitude = 1.2333400000000001,
                            Longitude = 23.44556,
                            Name = "Aarhus Universitet",
                            Type = "Forretning"
                        },
                        new
                        {
                            FacilityId = 4,
                            Description = "Ligger i aarhus N",
                            Latitude = 98.667770000000004,
                            Longitude = 12.33343,
                            Name = "Storcenter Nord",
                            Type = "Shopping"
                        });
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

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<int>("PersId")
                        .HasColumnType("int");

                    b.HasKey("MaintenanceId");

                    b.HasIndex("FacilityId");

                    b.HasIndex("PersId");

                    b.ToTable("MaintenanceLogs");

                    b.HasData(
                        new
                        {
                            MaintenanceId = 1,
                            Date = new DateTime(2022, 11, 11, 13, 4, 42, 714, DateTimeKind.Local).AddTicks(9886),
                            Description = "Ved ikke",
                            FacilityId = 1,
                            PersId = 1
                        },
                        new
                        {
                            MaintenanceId = 2,
                            Date = new DateTime(2022, 11, 11, 13, 4, 42, 714, DateTimeKind.Local).AddTicks(9903),
                            Description = "gegikvep",
                            FacilityId = 2,
                            PersId = 2
                        });
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Personnel", b =>
                {
                    b.Property<int>("PersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersId"), 1L, 1);

                    b.HasKey("PersId");

                    b.ToTable("Personnels");

                    b.HasData(
                        new
                        {
                            PersId = 1
                        },
                        new
                        {
                            PersId = 2
                        });
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Activity", b =>
                {
                    b.HasOne("DAB_2_Solution_grp5.Models.Citizen", "Citizen")
                        .WithMany("Activities")
                        .HasForeignKey("CitizenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_2_Solution_grp5.Models.Facility", "Facility")
                        .WithMany("Activities")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Citizen");

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.MaintenanceLog", b =>
                {
                    b.HasOne("DAB_2_Solution_grp5.Models.Facility", "Facility")
                        .WithMany("MaintenanceLogs")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_2_Solution_grp5.Models.Personnel", "Personnel")
                        .WithMany("MaintenaceLogs")
                        .HasForeignKey("PersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Citizen", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Facility", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("MaintenanceLogs");
                });

            modelBuilder.Entity("DAB_2_Solution_grp5.Models.Personnel", b =>
                {
                    b.Navigation("MaintenaceLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
