using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CamMeister2.Data.Migrations
{
    public partial class AddApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Cameras",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_ApplicationUserId",
                table: "Cameras",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_AspNetUsers_ApplicationUserId",
                table: "Cameras",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_AspNetUsers_ApplicationUserId",
                table: "Cameras");

            migrationBuilder.DropIndex(
                name: "IX_Cameras_ApplicationUserId",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "AspNetUsers");
        }
    }
}
