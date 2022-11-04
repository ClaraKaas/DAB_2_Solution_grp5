using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_2_Solution_grp5.Migrations
{
    public partial class FìxedNamingagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Booking",
                newName: "CitizenId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                newName: "IX_Booking_CitizenId");

            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    CitizenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.CitizenId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Citizens_CitizenId",
                table: "Booking",
                column: "CitizenId",
                principalTable: "Citizens",
                principalColumn: "CitizenId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Citizens_CitizenId",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.RenameColumn(
                name: "CitizenId",
                table: "Booking",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_CitizenId",
                table: "Booking",
                newName: "IX_Booking_UserId");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
