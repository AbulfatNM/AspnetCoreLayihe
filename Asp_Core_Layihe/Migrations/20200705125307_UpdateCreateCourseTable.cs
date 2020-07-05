using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Core_Layihe.Migrations
{
    public partial class UpdateCreateCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_courseContents_CourseContentId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courseContents",
                table: "courseContents");

            migrationBuilder.RenameTable(
                name: "courseContents",
                newName: "CourseContents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseContents",
                table: "CourseContents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseContents_CourseContentId",
                table: "Courses",
                column: "CourseContentId",
                principalTable: "CourseContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseContents_CourseContentId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseContents",
                table: "CourseContents");

            migrationBuilder.RenameTable(
                name: "CourseContents",
                newName: "courseContents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courseContents",
                table: "courseContents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_courseContents_CourseContentId",
                table: "Courses",
                column: "CourseContentId",
                principalTable: "courseContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
