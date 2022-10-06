using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CamMeister2.Data.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camera_Info");

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.CreateTable(
                name: "Camera_Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camera_Info", x => x.Id);
                });
        }
    }
}
