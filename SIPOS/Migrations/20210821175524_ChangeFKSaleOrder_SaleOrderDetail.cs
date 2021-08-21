using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPOS.Migrations
{
    public partial class ChangeFKSaleOrder_SaleOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_SaleOrder_OrderId",
                table: "SaleOrderDetail");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "SaleOrderDetail",
                newName: "SaleOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrderDetail_OrderId",
                table: "SaleOrderDetail",
                newName: "IX_SaleOrderDetail_SaleOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_SaleOrder_SaleOrderId",
                table: "SaleOrderDetail",
                column: "SaleOrderId",
                principalTable: "SaleOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_SaleOrder_SaleOrderId",
                table: "SaleOrderDetail");

            migrationBuilder.RenameColumn(
                name: "SaleOrderId",
                table: "SaleOrderDetail",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrderDetail_SaleOrderId",
                table: "SaleOrderDetail",
                newName: "IX_SaleOrderDetail_OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_SaleOrder_OrderId",
                table: "SaleOrderDetail",
                column: "OrderId",
                principalTable: "SaleOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
