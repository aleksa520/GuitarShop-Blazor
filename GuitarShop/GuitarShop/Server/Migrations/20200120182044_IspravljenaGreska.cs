using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarShop.Server.Migrations
{
    public partial class IspravljenaGreska : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guitars_GuitarBills_GuitarBillID",
                table: "Guitars");

            migrationBuilder.DropIndex(
                name: "IX_Guitars_GuitarBillID",
                table: "Guitars");

            migrationBuilder.DropColumn(
                name: "GuitarBillID",
                table: "Guitars");

            migrationBuilder.CreateTable(
                name: "GuitarBillItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuitarBillId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    GuitarId = table.Column<int>(nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuitarBillItem");

            migrationBuilder.AddColumn<int>(
                name: "GuitarBillID",
                table: "Guitars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_GuitarBillID",
                table: "Guitars",
                column: "GuitarBillID");

            migrationBuilder.AddForeignKey(
                name: "FK_Guitars_GuitarBills_GuitarBillID",
                table: "Guitars",
                column: "GuitarBillID",
                principalTable: "GuitarBills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
