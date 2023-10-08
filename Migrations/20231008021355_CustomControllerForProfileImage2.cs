using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocMVCApp.Migrations
{
    public partial class CustomControllerForProfileImage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileImage",
                table: "UserPrimaryInfo",
                newName: "ImageData");

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "UserPrimaryInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "UserPrimaryInfo");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "UserPrimaryInfo",
                newName: "ProfileImage");
        }
    }
}
