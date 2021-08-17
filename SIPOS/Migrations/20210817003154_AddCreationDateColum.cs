using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPOS.Migrations
{
    public partial class AddCreationDateColum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "GoodsOrder");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Order",
                newName: "Invoice");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "GoodsOrder",
                newName: "Invoice");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "SiposUser",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "SiposRol",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "OrderDetail",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "GoodsOrderDetail",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "GoodsOrder",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "GoodsOrder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "SiposUser");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "SiposRol");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "GoodsOrderDetail");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "GoodsOrder");

            migrationBuilder.RenameColumn(
                name: "Invoice",
                table: "Order",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "Invoice",
                table: "GoodsOrder",
                newName: "Number");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "Order",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "GoodsOrder",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "GoodsOrder",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
