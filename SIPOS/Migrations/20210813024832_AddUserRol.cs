using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPOS.Migrations
{
    public partial class AddUserRol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SiposRol",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiposRol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiposUserRol",
                columns: table => new
                {
                    SiposUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiposRolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiposUserRol", x => new { x.SiposRolId, x.SiposUserId });
                    table.ForeignKey(
                        name: "FK_SiposUserRol_SiposRol_SiposRolId",
                        column: x => x.SiposRolId,
                        principalTable: "SiposRol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiposUserRol_SiposUser_SiposUserId",
                        column: x => x.SiposUserId,
                        principalTable: "SiposUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiposUserRol_SiposUserId",
                table: "SiposUserRol",
                column: "SiposUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiposUserRol");

            migrationBuilder.DropTable(
                name: "SiposRol");
        }
    }
}
