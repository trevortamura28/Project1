using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox2.Data.Migrations
{
    public partial class thirtythree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Presets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "Presets",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Presets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Presets",
                nullable: false,
                defaultValue: 0);
        }
    }
}
