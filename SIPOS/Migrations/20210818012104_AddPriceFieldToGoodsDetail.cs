using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPOS.Migrations
{
    public partial class AddPriceFieldToGoodsDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SugestedPriceToSell",
                table: "Product",
                newName: "PriceToSell");

            migrationBuilder.RenameColumn(
                name: "PriceSell",
                table: "Product",
                newName: "PriceSugestedToSell");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderDetail",
                newName: "PriceToSell");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "GoodsOrderDetail",
                newName: "PriceToSell");

            migrationBuilder.AddColumn<decimal>(
                name: "PricePurchase",
                table: "GoodsOrderDetail",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSugestedToSell",
                table: "GoodsOrderDetail",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePurchase",
                table: "GoodsOrderDetail");

            migrationBuilder.DropColumn(
                name: "PriceSugestedToSell",
                table: "GoodsOrderDetail");

            migrationBuilder.RenameColumn(
                name: "PriceToSell",
                table: "Product",
                newName: "SugestedPriceToSell");

            migrationBuilder.RenameColumn(
                name: "PriceSugestedToSell",
                table: "Product",
                newName: "PriceSell");

            migrationBuilder.RenameColumn(
                name: "PriceToSell",
                table: "OrderDetail",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "PriceToSell",
                table: "GoodsOrderDetail",
                newName: "UnitPrice");
        }
    }
}
