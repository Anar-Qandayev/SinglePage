using Microsoft.EntityFrameworkCore.Migrations;

namespace SinglePage.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialty",
                table: "Experiences");

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Experiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Experiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Abouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "History",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "Specialty",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
