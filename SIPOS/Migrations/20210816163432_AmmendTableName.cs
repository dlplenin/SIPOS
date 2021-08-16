using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPOS.Migrations
{
    public partial class AmmendTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsOrder_Suplier_SuplierId",
                table: "GoodsOrder");

            migrationBuilder.DropTable(
                name: "Suplier");

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsOrder_Supplier_SuplierId",
                table: "GoodsOrder",
                column: "SuplierId",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsOrder_Supplier_SuplierId",
                table: "GoodsOrder");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.CreateTable(
                name: "Suplier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplier", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsOrder_Suplier_SuplierId",
                table: "GoodsOrder",
                column: "SuplierId",
                principalTable: "Suplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
