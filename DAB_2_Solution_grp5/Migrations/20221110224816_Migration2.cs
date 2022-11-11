using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_2_Solution_grp5.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Participants",
                table: "Activities");

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    Cpr = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.Cpr);
                });

            migrationBuilder.CreateTable(
                name: "ActivityParticipant",
                columns: table => new
                {
                    ActivitiesActivityId = table.Column<int>(type: "int", nullable: false),
                    ParticipantsCpr = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityParticipant", x => new { x.ActivitiesActivityId, x.ParticipantsCpr });
                    table.ForeignKey(
                        name: "FK_ActivityParticipant_Activities_ActivitiesActivityId",
                        column: x => x.ActivitiesActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityParticipant_Participant_ParticipantsCpr",
                        column: x => x.ParticipantsCpr,
                        principalTable: "Participant",
                        principalColumn: "Cpr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 1,
                column: "Date",
<<<<<<<< HEAD:DAB_2_Solution_grp5/Migrations/20221110224816_Migration2.cs
                value: new DateTime(2022, 11, 11, 14, 48, 16, 301, DateTimeKind.Local).AddTicks(889));
========
                value: new DateTime(2022, 11, 11, 15, 30, 24, 408, DateTimeKind.Local).AddTicks(3509));
>>>>>>>> b9db9ff42a31ba8298bb2b6b0c8962798e9d4aab:DAB_2_Solution_grp5/Migrations/20221110233024_Migration2.cs

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 2,
                column: "Date",
<<<<<<<< HEAD:DAB_2_Solution_grp5/Migrations/20221110224816_Migration2.cs
                value: new DateTime(2022, 11, 11, 14, 48, 16, 301, DateTimeKind.Local).AddTicks(933));
========
                value: new DateTime(2022, 11, 11, 15, 30, 24, 408, DateTimeKind.Local).AddTicks(3543));
>>>>>>>> b9db9ff42a31ba8298bb2b6b0c8962798e9d4aab:DAB_2_Solution_grp5/Migrations/20221110233024_Migration2.cs

            migrationBuilder.InsertData(
                table: "Participant",
                columns: new[] { "Cpr", "ActivityId" },
                values: new object[,]
                {
                    { "123021-1234", 1 },
                    { "123021-2345", 1 },
                    { "123021-3456", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityParticipant_ParticipantsCpr",
                table: "ActivityParticipant",
                column: "ParticipantsCpr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityParticipant");

            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.AddColumn<int>(
                name: "Participants",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "Participants",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 2,
                column: "Participants",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 11, 15, 9, 3, 805, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 11, 15, 9, 3, 805, DateTimeKind.Local).AddTicks(7919));
        }
    }
}
