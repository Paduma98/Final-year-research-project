using Microsoft.EntityFrameworkCore.Migrations;

namespace EP_System_Test.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    School_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Principl_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Principal_ContactNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Dep_Principal_Contact = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Grade_06_Count = table.Column<int>(type: "int", nullable: false),
                    Grade_07_Count = table.Column<int>(type: "int", nullable: false),
                    Grade_08_Count = table.Column<int>(type: "int", nullable: false),
                    Grade_09_Count = table.Column<int>(type: "int", nullable: false),
                    Grade_10_Count = table.Column<int>(type: "int", nullable: false),
                    Grade_11_Count = table.Column<int>(type: "int", nullable: false),
                    Grade_AL_Maths = table.Column<int>(type: "int", nullable: false),
                    Grade_AL_Bio = table.Column<int>(type: "int", nullable: false),
                    Grade_AL_Commerce = table.Column<int>(type: "int", nullable: false),
                    Grade_AL_Tech = table.Column<int>(type: "int", nullable: false),
                    Grade_AL_Arts = table.Column<int>(type: "int", nullable: false),
                    Sports_Coacher_01 = table.Column<int>(type: "int", nullable: false),
                    Sports_Coacher_02 = table.Column<int>(type: "int", nullable: false),
                    Sports_Coacher_03 = table.Column<int>(type: "int", nullable: false),
                    Sports_Coacher_04 = table.Column<int>(type: "int", nullable: false),
                    Sports_Coacher_05 = table.Column<int>(type: "int", nullable: false),
                    Subjects_Teachers_01 = table.Column<int>(type: "int", nullable: false),
                    Subjects_Teachers_02 = table.Column<int>(type: "int", nullable: false),
                    Subjects_Teachers_03 = table.Column<int>(type: "int", nullable: false),
                    Subjects_Teachers_04 = table.Column<int>(type: "int", nullable: false),
                    Subjects_Teachers_05 = table.Column<int>(type: "int", nullable: false),
                    Student_Count_Total = table.Column<int>(type: "int", nullable: false),
                    Teacher_Count_Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtraCurricualrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Society_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraCurricualrs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtraCurricualrs_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stu_Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mothers_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mother_Contact_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mother_Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Father_Contact_Number = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Father_Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade_Teaching = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Number = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Teacher_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassTeacher = table.Column<bool>(type: "bit", nullable: false),
                    Teaching_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appointed_Sports = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student_ExtraCurricular",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExtraCurricularId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_ExtraCurricular", x => new { x.StudentId, x.ExtraCurricularId });
                    table.ForeignKey(
                        name: "FK_Student_ExtraCurricular_ExtraCurricualrs_ExtraCurricularId",
                        column: x => x.ExtraCurricularId,
                        principalTable: "ExtraCurricualrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_ExtraCurricular_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sport_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sports_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sports_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students_Teachers",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students_Teachers", x => new { x.TeacherId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_Students_Teachers_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Teachers_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers_ExtraCurricualrs",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    ExtraCurricualrId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers_ExtraCurricualrs", x => new { x.ExtraCurricualrId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_Teachers_ExtraCurricualrs_ExtraCurricualrs_ExtraCurricualrId",
                        column: x => x.ExtraCurricualrId,
                        principalTable: "ExtraCurricualrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_ExtraCurricualrs_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student_Sport",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SportsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Sport", x => new { x.StudentId, x.SportsId });
                    table.ForeignKey(
                        name: "FK_Student_Sport_Sports_SportsId",
                        column: x => x.SportsId,
                        principalTable: "Sports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Sport_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers_Sports",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    SportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers_Sports", x => new { x.SportId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_Teachers_Sports_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_Sports_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExtraCurricualrs_SchoolId",
                table: "ExtraCurricualrs",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Sports_SchoolId",
                table: "Sports",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Sports_TeacherId",
                table: "Sports",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SchoolId",
                table: "Student",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ExtraCurricular_ExtraCurricularId",
                table: "Student_ExtraCurricular",
                column: "ExtraCurricularId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Sport_SportsId",
                table: "Student_Sport",
                column: "SportsId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Teachers_StudentId",
                table: "Students_Teachers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SchoolId",
                table: "Teacher",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ExtraCurricualrs_TeacherId",
                table: "Teachers_ExtraCurricualrs",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Sports_TeacherId",
                table: "Teachers_Sports",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_ExtraCurricular");

            migrationBuilder.DropTable(
                name: "Student_Sport");

            migrationBuilder.DropTable(
                name: "Students_Teachers");

            migrationBuilder.DropTable(
                name: "Teachers_ExtraCurricualrs");

            migrationBuilder.DropTable(
                name: "Teachers_Sports");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "ExtraCurricualrs");

            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "School");
        }
    }
}
