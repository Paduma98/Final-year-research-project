using Microsoft.EntityFrameworkCore.Migrations;

namespace EP_System_Test.Migrations
{
    public partial class made_db_context_delete_option_cascading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_ExtraCurricular_ExtraCurricualrs_ExtraCurricularId",
                table: "Student_ExtraCurricular");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_ExtraCurricular_Student_StudentId",
                table: "Student_ExtraCurricular");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Sport_Sports_SportsId",
                table: "Student_Sport");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Sport_Student_StudentId",
                table: "Student_Sport");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_ExtraCurricualrs_ExtraCurricualrs_ExtraCurricualrId",
                table: "Teachers_ExtraCurricualrs");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_ExtraCurricualrs_Teacher_TeacherId",
                table: "Teachers_ExtraCurricualrs");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Sports_Sports_SportId",
                table: "Teachers_Sports");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Sports_Teacher_TeacherId",
                table: "Teachers_Sports");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_ExtraCurricular_ExtraCurricualrs_ExtraCurricularId",
                table: "Student_ExtraCurricular",
                column: "ExtraCurricularId",
                principalTable: "ExtraCurricualrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_ExtraCurricular_Student_StudentId",
                table: "Student_ExtraCurricular",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Sport_Sports_SportsId",
                table: "Student_Sport",
                column: "SportsId",
                principalTable: "Sports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Sport_Student_StudentId",
                table: "Student_Sport",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_ExtraCurricualrs_ExtraCurricualrs_ExtraCurricualrId",
                table: "Teachers_ExtraCurricualrs",
                column: "ExtraCurricualrId",
                principalTable: "ExtraCurricualrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_ExtraCurricualrs_Teacher_TeacherId",
                table: "Teachers_ExtraCurricualrs",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Sports_Sports_SportId",
                table: "Teachers_Sports",
                column: "SportId",
                principalTable: "Sports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Sports_Teacher_TeacherId",
                table: "Teachers_Sports",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_ExtraCurricular_ExtraCurricualrs_ExtraCurricularId",
                table: "Student_ExtraCurricular");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_ExtraCurricular_Student_StudentId",
                table: "Student_ExtraCurricular");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Sport_Sports_SportsId",
                table: "Student_Sport");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Sport_Student_StudentId",
                table: "Student_Sport");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_ExtraCurricualrs_ExtraCurricualrs_ExtraCurricualrId",
                table: "Teachers_ExtraCurricualrs");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_ExtraCurricualrs_Teacher_TeacherId",
                table: "Teachers_ExtraCurricualrs");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Sports_Sports_SportId",
                table: "Teachers_Sports");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Sports_Teacher_TeacherId",
                table: "Teachers_Sports");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_ExtraCurricular_ExtraCurricualrs_ExtraCurricularId",
                table: "Student_ExtraCurricular",
                column: "ExtraCurricularId",
                principalTable: "ExtraCurricualrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_ExtraCurricular_Student_StudentId",
                table: "Student_ExtraCurricular",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Sport_Sports_SportsId",
                table: "Student_Sport",
                column: "SportsId",
                principalTable: "Sports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Sport_Student_StudentId",
                table: "Student_Sport",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_ExtraCurricualrs_ExtraCurricualrs_ExtraCurricualrId",
                table: "Teachers_ExtraCurricualrs",
                column: "ExtraCurricualrId",
                principalTable: "ExtraCurricualrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_ExtraCurricualrs_Teacher_TeacherId",
                table: "Teachers_ExtraCurricualrs",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Sports_Sports_SportId",
                table: "Teachers_Sports",
                column: "SportId",
                principalTable: "Sports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Sports_Teacher_TeacherId",
                table: "Teachers_Sports",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
