using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarShop.Server.Migrations
{
    public partial class AddedGuitarBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guitars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuitarBillId",
                table: "Guitars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GuitarBills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarBills", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "GuitarBills");

            migrationBuilder.DropIndex(
                name: "IX_Guitars_GuitarBillId",
                table: "Guitars");

            migrationBuilder.DropColumn(
                name: "GuitarBillId",
                table: "Guitars");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guitars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
