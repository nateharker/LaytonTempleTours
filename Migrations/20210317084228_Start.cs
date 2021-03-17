using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTempleTours.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvailableTimes",
                columns: table => new
                {
                    AvailableTimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppointementTime = table.Column<DateTime>(nullable: false),
                    SlotBooked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableTimes", x => x.AvailableTimeId);
                });

            migrationBuilder.CreateTable(
                name: "GroupInfos",
                columns: table => new
                {
                    GroupInfoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    TimeSlot = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupInfos", x => x.GroupInfoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailableTimes");

            migrationBuilder.DropTable(
                name: "GroupInfos");
        }
    }
}
