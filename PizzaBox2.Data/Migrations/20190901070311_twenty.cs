using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox2.Data.Migrations
{
    public partial class twenty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pizzas");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Pizzas");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pizzas",
                nullable: false,
                defaultValue: "");
        }
    }
}
