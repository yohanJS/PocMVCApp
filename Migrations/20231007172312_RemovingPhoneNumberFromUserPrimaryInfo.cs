using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocMVCApp.Migrations
{
    public partial class RemovingPhoneNumberFromUserPrimaryInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "UserPrimaryInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "UserPrimaryInfo",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
