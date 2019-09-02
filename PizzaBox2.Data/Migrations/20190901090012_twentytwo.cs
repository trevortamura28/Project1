using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox2.Data.Migrations
{
    public partial class twentytwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_OnHereId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_OnHereId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "OnHereId",
                table: "Toppings");

            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "Toppings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Toppings");

            migrationBuilder.AddColumn<int>(
                name: "OnHereId",
                table: "Toppings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_OnHereId",
                table: "Toppings",
                column: "OnHereId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Pizzas_OnHereId",
                table: "Toppings",
                column: "OnHereId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
