using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_2_Solution_grp5.Migrations
{
    public partial class FìxedNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_activities_ActivityId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_facilities_FacilityId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_users_UserId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Does_Maintenance_facilities_FacilityId",
                table: "Does_Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Does_Maintenance_maintenanceLogs_MaintenanceId",
                table: "Does_Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Does_Maintenance_personnels_PersId",
                table: "Does_Maintenance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personnels",
                table: "personnels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_maintenanceLogs",
                table: "maintenanceLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_facilities",
                table: "facilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_activities",
                table: "activities");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "personnels",
                newName: "Personnels");

            migrationBuilder.RenameTable(
                name: "maintenanceLogs",
                newName: "MaintenanceLogs");

            migrationBuilder.RenameTable(
                name: "facilities",
                newName: "Facilities");

            migrationBuilder.RenameTable(
                name: "activities",
                newName: "Activities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personnels",
                table: "Personnels",
                column: "PersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintenanceLogs",
                table: "MaintenanceLogs",
                column: "MaintenanceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities",
                column: "FacilityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Activities_ActivityId",
                table: "Booking",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Facilities_FacilityId",
                table: "Booking",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "FacilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Does_Maintenance_Facilities_FacilityId",
                table: "Does_Maintenance",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "FacilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Does_Maintenance_MaintenanceLogs_MaintenanceId",
                table: "Does_Maintenance",
                column: "MaintenanceId",
                principalTable: "MaintenanceLogs",
                principalColumn: "MaintenanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Does_Maintenance_Personnels_PersId",
                table: "Does_Maintenance",
                column: "PersId",
                principalTable: "Personnels",
                principalColumn: "PersId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Activities_ActivityId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Facilities_FacilityId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Does_Maintenance_Facilities_FacilityId",
                table: "Does_Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Does_Maintenance_MaintenanceLogs_MaintenanceId",
                table: "Does_Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Does_Maintenance_Personnels_PersId",
                table: "Does_Maintenance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personnels",
                table: "Personnels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintenanceLogs",
                table: "MaintenanceLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Personnels",
                newName: "personnels");

            migrationBuilder.RenameTable(
                name: "MaintenanceLogs",
                newName: "maintenanceLogs");

            migrationBuilder.RenameTable(
                name: "Facilities",
                newName: "facilities");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "activities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personnels",
                table: "personnels",
                column: "PersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_maintenanceLogs",
                table: "maintenanceLogs",
                column: "MaintenanceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_facilities",
                table: "facilities",
                column: "FacilityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_activities",
                table: "activities",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_activities_ActivityId",
                table: "Booking",
                column: "ActivityId",
                principalTable: "activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_facilities_FacilityId",
                table: "Booking",
                column: "FacilityId",
                principalTable: "facilities",
                principalColumn: "FacilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_users_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Does_Maintenance_facilities_FacilityId",
                table: "Does_Maintenance",
                column: "FacilityId",
                principalTable: "facilities",
                principalColumn: "FacilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Does_Maintenance_maintenanceLogs_MaintenanceId",
                table: "Does_Maintenance",
                column: "MaintenanceId",
                principalTable: "maintenanceLogs",
                principalColumn: "MaintenanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Does_Maintenance_personnels_PersId",
                table: "Does_Maintenance",
                column: "PersId",
                principalTable: "personnels",
                principalColumn: "PersId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
