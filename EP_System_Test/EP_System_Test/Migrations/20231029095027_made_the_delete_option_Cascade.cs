using Microsoft.EntityFrameworkCore.Migrations;

namespace EP_System_Test.Migrations
{
    public partial class made_the_delete_option_Cascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_Student_StudentId",
                table: "Students_Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_Teacher_TeacherId",
                table: "Students_Teachers");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_Student_StudentId",
                table: "Students_Teachers",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_Teacher_TeacherId",
                table: "Students_Teachers",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_Student_StudentId",
                table: "Students_Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_Teacher_TeacherId",
                table: "Students_Teachers");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_Student_StudentId",
                table: "Students_Teachers",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_Teacher_TeacherId",
                table: "Students_Teachers",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
