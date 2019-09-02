using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox2.Data.Migrations
{
    public partial class nineteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Locations_LocationId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_LocationId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Toppings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Toppings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_LocationId",
                table: "Toppings",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Locations_LocationId",
                table: "Toppings",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
