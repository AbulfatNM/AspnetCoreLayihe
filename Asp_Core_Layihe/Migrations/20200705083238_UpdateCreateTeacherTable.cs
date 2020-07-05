using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Core_Layihe.Migrations
{
    public partial class UpdateCreateTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Teachers",
                maxLength: 70,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Teachers");
        }
    }
}
