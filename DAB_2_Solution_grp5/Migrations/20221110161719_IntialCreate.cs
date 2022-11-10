using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_2_Solution_grp5.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    CitizenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.CitizenId);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilityId);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    PersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.PersId);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Participants = table.Column<int>(type: "int", nullable: false),
                    CitizenId = table.Column<int>(type: "int", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activities_Citizens_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizens",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Activities_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceLogs",
                columns: table => new
                {
                    MaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: false),
                    PersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceLogs", x => x.MaintenanceId);
                    table.ForeignKey(
                        name: "FK_MaintenanceLogs_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintenanceLogs_Personnels_PersId",
                        column: x => x.PersId,
                        principalTable: "Personnels",
                        principalColumn: "PersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "CitizenId", "CVR", "Category", "Email", "Namee", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "12103023031", "Business", "Clara@gmail.com", "Clara", "25252525" },
                    { 2, "109876543", "Forretning", "clara@gmail.com", "Clara", "42345677" },
                    { 3, "098765432", "Forretning", "Heja@gmail.com", "Heja", "42336789" }
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilityId", "Address", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Strand 9", "God plads", "AarhusStrand", "Privat" },
                    { 2, "Møllevej 15", "Den ligger ved haven kanten", "Navitas", "forretning" },
                    { 3, "Finlandsgade 22", "Skole", "Aarhus Universitet", "forretning" },
                    { 4, "Finlandsgade 15", "Ligger i aarhus N", "Storcenter Nord", "Shopping" }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                column: "PersId",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "CitizenId", "FacilityId", "Note", "Participants", "Time" },
                values: new object[,]
                {
                    { 5, 1, 1, "jnjcxdzrtfyguhijokpszxrtfgyhuijokl", 5, new DateTime(2022, 11, 11, 3, 17, 19, 380, DateTimeKind.Local).AddTicks(5092) },
                    { 7, 2, 2, "jnjcxdzrtfyguhijokpszxrtfgyhuijokl", 10, new DateTime(2022, 11, 11, 8, 17, 19, 380, DateTimeKind.Local).AddTicks(5153) }
                });

            migrationBuilder.InsertData(
                table: "MaintenanceLogs",
                columns: new[] { "MaintenanceId", "Date", "Description", "FacilityId", "PersId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 11, 8, 17, 19, 380, DateTimeKind.Local).AddTicks(9543), "Ved ikke", 1, 1 },
                    { 2, new DateTime(2022, 11, 11, 8, 17, 19, 380, DateTimeKind.Local).AddTicks(9577), "gegikvep", 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CitizenId",
                table: "Activities",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_FacilityId",
                table: "Activities",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceLogs_FacilityId",
                table: "MaintenanceLogs",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceLogs_PersId",
                table: "MaintenanceLogs",
                column: "PersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "MaintenanceLogs");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Personnels");
        }
    }
}
