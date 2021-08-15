using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPOS.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SiposRol",
                columns: new[] { "Id", "Activo", "Name" },
                values: new object[] { new Guid("cbdb7e0a-f65c-44ca-9708-29d606770f4f"), true, "Administrador" });

            migrationBuilder.InsertData(
                table: "SiposRol",
                columns: new[] { "Id", "Activo", "Name" },
                values: new object[] { new Guid("3bf4148a-6dcc-44ec-bf2b-7612ae1d3551"), true, "Vendedor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SiposRol",
                keyColumn: "Id",
                keyValue: new Guid("3bf4148a-6dcc-44ec-bf2b-7612ae1d3551"));

            migrationBuilder.DeleteData(
                table: "SiposRol",
                keyColumn: "Id",
                keyValue: new Guid("cbdb7e0a-f65c-44ca-9708-29d606770f4f"));
        }
    }
}
