using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocMVCApp.Migrations
{
    public partial class rollingBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTwoFactorEnabled",
                table: "UserPrimaryInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTwoFactorEnabled",
                table: "UserPrimaryInfo",
                type: "bit",
                nullable: true);
        }
    }
}
