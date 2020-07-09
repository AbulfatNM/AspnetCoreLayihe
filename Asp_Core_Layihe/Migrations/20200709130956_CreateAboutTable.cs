using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Core_Layihe.Migrations
{
    public partial class CreateAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SmalLogoBlack",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmalLogoWhite",
                table: "Bios",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AboutNotices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutNotices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutSliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 350, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: false),
                    BackgroundImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutVideos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VideoLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutVideos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutWelcomes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutWelcomes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutNotices");

            migrationBuilder.DropTable(
                name: "AboutSliders");

            migrationBuilder.DropTable(
                name: "AboutVideos");

            migrationBuilder.DropTable(
                name: "AboutWelcomes");

            migrationBuilder.DropColumn(
                name: "SmalLogoBlack",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "SmalLogoWhite",
                table: "Bios");
        }
    }
}
