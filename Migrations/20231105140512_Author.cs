using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flaviu_Iepan_lab2.Migrations
{
    public partial class Author : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "theAuthor",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "theAuthor",
                table: "Book");
        }
    }
}
