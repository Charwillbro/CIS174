using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174.Migrations
{
    public partial class Clres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "testMigrationField",
                table: "Accomplishments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testMigrationField",
                table: "Accomplishments");
        }
    }
}
