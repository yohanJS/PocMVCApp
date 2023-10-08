using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocMVCApp.Migrations
{
    public partial class CustomControllerForProfileImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImage",
                table: "UserPrimaryInfo",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "UserPrimaryInfo");
        }
    }
}
