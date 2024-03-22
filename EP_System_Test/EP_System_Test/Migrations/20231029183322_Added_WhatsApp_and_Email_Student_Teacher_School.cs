using Microsoft.EntityFrameworkCore.Migrations;

namespace EP_System_Test.Migrations
{
    public partial class Added_WhatsApp_and_Email_Student_Teacher_School : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sports_Teacher_TeacherId",
                table: "Sports");

            migrationBuilder.DropIndex(
                name: "IX_Sports_TeacherId",
                table: "Sports");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Sports");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatsApp",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatsApp",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "School",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatsApp",
                table: "School",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "WhatsApp",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "WhatsApp",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "School");

            migrationBuilder.DropColumn(
                name: "WhatsApp",
                table: "School");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Sports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sports_TeacherId",
                table: "Sports",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sports_Teacher_TeacherId",
                table: "Sports",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
