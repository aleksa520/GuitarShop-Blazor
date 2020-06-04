using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarShop.Server.Migrations
{
    public partial class novo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guitars",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GuitarBills",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarBills", x => x.id);
                    table.ForeignKey(
                        name: "FK_GuitarBills_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GuitarBillItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    GuitarId = table.Column<int>(nullable: true),
                    GuitarBillId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarBillItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_GuitarBillItem_GuitarBills_GuitarBillId",
                        column: x => x.GuitarBillId,
                        principalTable: "GuitarBills",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GuitarBillItem_Guitars_GuitarId",
                        column: x => x.GuitarId,
                        principalTable: "Guitars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuitarBillItem_GuitarBillId",
                table: "GuitarBillItem",
                column: "GuitarBillId");

            migrationBuilder.CreateIndex(
                name: "IX_GuitarBillItem_GuitarId",
                table: "GuitarBillItem",
                column: "GuitarId");

            migrationBuilder.CreateIndex(
                name: "IX_GuitarBills_UserId",
                table: "GuitarBills",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuitarBillItem");

            migrationBuilder.DropTable(
                name: "GuitarBills");

            migrationBuilder.DropTable(
                name: "Guitars");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
