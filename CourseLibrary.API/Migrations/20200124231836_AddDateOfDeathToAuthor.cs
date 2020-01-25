using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseLibrary.API.Migrations
{
    public partial class AddDateOfDeathToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateOfDeath",
                table: "Authors",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AuthorDto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    MainCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorDto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorDto");

            migrationBuilder.DropColumn(
                name: "DateOfDeath",
                table: "Authors");
        }
    }
}
