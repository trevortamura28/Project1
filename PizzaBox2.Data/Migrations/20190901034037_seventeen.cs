using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox2.Data.Migrations
{
    public partial class seventeen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Locations_LId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Orders_OId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_LId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_OId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_UId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "LId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "OId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "UId",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "L",
                table: "Transactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "O",
                table: "Transactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "U",
                table: "Transactions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "L",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "O",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "U",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "LId",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OId",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UId",
                table: "Transactions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_LId",
                table: "Transactions",
                column: "LId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OId",
                table: "Transactions",
                column: "OId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UId",
                table: "Transactions",
                column: "UId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Locations_LId",
                table: "Transactions",
                column: "LId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Orders_OId",
                table: "Transactions",
                column: "OId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UId",
                table: "Transactions",
                column: "UId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
