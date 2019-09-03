using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox2.Data.Migrations
{
    public partial class twentyeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Inventories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Inventories");
        }
    }
}
