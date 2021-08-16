using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPOS.Migrations
{
    public partial class ChangeNameQtyToStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Product",
                newName: "Stock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Product",
                newName: "Quantity");
        }
    }
}
