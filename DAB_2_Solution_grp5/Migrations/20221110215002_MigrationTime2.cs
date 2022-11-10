using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_2_Solution_grp5.Migrations
{
    public partial class MigrationTime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Activities",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Activities",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 11, 13, 50, 2, 407, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "MaintenanceId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 11, 13, 50, 2, 407, DateTimeKind.Local).AddTicks(9547));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

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
    }
}
