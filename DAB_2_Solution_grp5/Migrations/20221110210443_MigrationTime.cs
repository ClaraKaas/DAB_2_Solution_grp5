using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_2_Solution_grp5.Migrations
{
    public partial class MigrationTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Activities",
                newName: "StartTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 10, 4, 42, 714, DateTimeKind.Local).AddTicks(7031), new DateTime(2022, 11, 11, 8, 4, 42, 714, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 15, 4, 42, 714, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 11, 11, 13, 4, 42, 714, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 11, 13, 4, 42, 714, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 11, 13, 4, 42, 714, DateTimeKind.Local).AddTicks(9903));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Activities",
                newName: "Time");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 11, 11, 4, 46, 49, 474, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 11, 11, 9, 46, 49, 474, DateTimeKind.Local).AddTicks(3345));

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
