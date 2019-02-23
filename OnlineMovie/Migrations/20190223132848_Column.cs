using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovie.Migrations
{
    public partial class Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bugdet",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bugdet",
                table: "Movies");
        }
    }
}
