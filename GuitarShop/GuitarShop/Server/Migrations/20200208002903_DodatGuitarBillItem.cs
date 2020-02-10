using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarShop.Server.Migrations
{
    public partial class DodatGuitarBillItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guitars_GuitarBills_GuitarBillId",
                table: "Guitars");

            migrationBuilder.DropIndex(
                name: "IX_Guitars_GuitarBillId",
                table: "Guitars");

            migrationBuilder.DropColumn(
                name: "GuitarBillId",
                table: "Guitars");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "GuitarBills",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "GuitarBillItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuitarBillItem");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "GuitarBills");

            migrationBuilder.AddColumn<int>(
                name: "GuitarBillId",
                table: "Guitars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_GuitarBillId",
                table: "Guitars",
                column: "GuitarBillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guitars_GuitarBills_GuitarBillId",
                table: "Guitars",
                column: "GuitarBillId",
                principalTable: "GuitarBills",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
