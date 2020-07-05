using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Core_Layihe.Migrations
{
    public partial class CreatTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillsTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Language = table.Column<int>(nullable: false),
                    Team_Leader = table.Column<int>(nullable: false),
                    Development = table.Column<int>(nullable: false),
                    Design = table.Column<int>(nullable: false),
                    Innovation = table.Column<int>(nullable: false),
                    Communication = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsTeachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 60, nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: false),
                    SKYPE = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    About = table.Column<string>(maxLength: 350, nullable: false),
                    DEGREE = table.Column<string>(maxLength: 50, nullable: false),
                    EXPERIENCE = table.Column<string>(maxLength: 55, nullable: false),
                    HOBBIES = table.Column<string>(nullable: true),
                    FACULTY = table.Column<string>(maxLength: 60, nullable: false),
                    SkillsTeacherId = table.Column<int>(nullable: false),
                    TeacherContactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_SkillsTeachers_SkillsTeacherId",
                        column: x => x.SkillsTeacherId,
                        principalTable: "SkillsTeachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_TeacherContacts_TeacherContactId",
                        column: x => x.TeacherContactId,
                        principalTable: "TeacherContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SkillsTeacherId",
                table: "Teachers",
                column: "SkillsTeacherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherContactId",
                table: "Teachers",
                column: "TeacherContactId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "SkillsTeachers");

            migrationBuilder.DropTable(
                name: "TeacherContacts");
        }
    }
}
