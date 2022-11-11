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

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Activities");

            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Activities",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "Activities",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

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
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { "2/1/2022", new TimeSpan(0, 12, 0, 0, 0), "1/1/2022", new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 2,
                columns: new[] { "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { "3/2/2022", new TimeSpan(0, 10, 0, 0, 0), "2/2/2022", new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 11, 14, 48, 16, 301, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 11, 14, 48, 16, 301, DateTimeKind.Local).AddTicks(933));

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

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Activities");

            migrationBuilder.AddColumn<int>(
                name: "Participants",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "Participants", "Time" },
                values: new object[] { 5, new DateTime(2022, 11, 11, 4, 46, 49, 474, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 2,
                columns: new[] { "Participants", "Time" },
                values: new object[] { 10, new DateTime(2022, 11, 11, 9, 46, 49, 474, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 11, 9, 46, 49, 474, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 11, 9, 46, 49, 474, DateTimeKind.Local).AddTicks(4987));
        }
    }
}
