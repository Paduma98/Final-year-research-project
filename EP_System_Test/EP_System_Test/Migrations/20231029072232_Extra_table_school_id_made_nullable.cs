using Microsoft.EntityFrameworkCore.Migrations;

namespace EP_System_Test.Migrations
{
    public partial class Extra_table_school_id_made_nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraCurricualrs_School_SchoolId",
                table: "ExtraCurricualrs");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "ExtraCurricualrs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraCurricualrs_School_SchoolId",
                table: "ExtraCurricualrs",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraCurricualrs_School_SchoolId",
                table: "ExtraCurricualrs");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "ExtraCurricualrs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraCurricualrs_School_SchoolId",
                table: "ExtraCurricualrs",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
