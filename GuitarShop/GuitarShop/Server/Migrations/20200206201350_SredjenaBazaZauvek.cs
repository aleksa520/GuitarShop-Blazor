using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarShop.Server.Migrations
{
    public partial class SredjenaBazaZauvek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuitarBillItem");

            migrationBuilder.AddColumn<int>(
                name: "GuitarBillId",
                table: "Guitars",
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
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "GuitarBillItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    GuitarBillId = table.Column<int>(type: "int", nullable: false),
                    GuitarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarBillItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuitarBillItem_GuitarBills_GuitarBillId",
                        column: x => x.GuitarBillId,
                        principalTable: "GuitarBills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuitarBillItem_Guitars_GuitarId",
                        column: x => x.GuitarId,
                        principalTable: "Guitars",
                        principalColumn: "Id",
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
    }
}
