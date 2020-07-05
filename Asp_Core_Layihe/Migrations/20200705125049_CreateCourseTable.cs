using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Core_Layihe.Migrations
{
    public partial class CreateCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutCourse = table.Column<string>(maxLength: 400, nullable: true),
                    HowToApply = table.Column<string>(maxLength: 400, nullable: true),
                    Certification = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Starts = table.Column<string>(maxLength: 65, nullable: false),
                    Duration = table.Column<string>(maxLength: 50, nullable: false),
                    Class_Duration = table.Column<string>(maxLength: 50, nullable: false),
                    Skill_Level = table.Column<string>(nullable: true),
                    Language = table.Column<string>(maxLength: 40, nullable: false),
                    Students = table.Column<int>(nullable: false),
                    Assesments = table.Column<string>(nullable: false),
                    Course_Fee = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Description = table.Column<string>(maxLength: 400, nullable: false),
                    CourseFeatureId = table.Column<int>(nullable: false),
                    CourseContentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_courseContents_CourseContentId",
                        column: x => x.CourseContentId,
                        principalTable: "courseContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_CourseFeatures_CourseFeatureId",
                        column: x => x.CourseFeatureId,
                        principalTable: "CourseFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseContentId",
                table: "Courses",
                column: "CourseContentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseFeatureId",
                table: "Courses",
                column: "CourseFeatureId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "courseContents");

            migrationBuilder.DropTable(
                name: "CourseFeatures");
        }
    }
}
