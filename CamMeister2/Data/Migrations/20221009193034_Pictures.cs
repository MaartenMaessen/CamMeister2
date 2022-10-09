using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CamMeister2.Data.Migrations
{
    public partial class Pictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CameraPhotoURL",
                table: "Cameras",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CameraPhotoURL",
                table: "Cameras");
        }
    }
}
