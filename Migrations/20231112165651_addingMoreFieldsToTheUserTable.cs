using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocMVCApp.Migrations
{
    public partial class addingMoreFieldsToTheUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "UserPrimaryInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "UserPrimaryInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryPhone",
                table: "UserPrimaryInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Salary",
                table: "UserPrimaryInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "UserPrimaryInfo");

            migrationBuilder.DropColumn(
                name: "PrimaryPhone",
                table: "UserPrimaryInfo");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "UserPrimaryInfo");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "UserPrimaryInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
