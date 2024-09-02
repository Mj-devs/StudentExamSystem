using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentExamSystem.Migrations
{
    public partial class addedemailandpasswordtolecturer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Lecturer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Lecturer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Lecturer");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Lecturer");
        }
    }
}
