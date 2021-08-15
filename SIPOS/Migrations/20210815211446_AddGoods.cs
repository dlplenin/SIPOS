using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPOS.Migrations
{
    public partial class AddGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Order",
                newName: "CreationDate");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "SiposUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "SiposRol",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "SugestedPriceToSell",
                table: "Product",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "OrderDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "Order",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Order",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "SiposUser");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "SiposRol");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SugestedPriceToSell",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Order",
                newName: "OrderDate");

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "OrderDetail",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
