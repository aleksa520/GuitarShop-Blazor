using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarShop.Server.Migrations
{
    public partial class AddMigrationSredjenaBaza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guitars_GuitarBills_GuitarBillId",
                table: "Guitars");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "GuitarBills");

            migrationBuilder.RenameColumn(
                name: "GuitarBillId",
                table: "Guitars",
                newName: "GuitarBillID");

            migrationBuilder.RenameIndex(
                name: "IX_Guitars_GuitarBillId",
                table: "Guitars",
                newName: "IX_Guitars_GuitarBillID");

            migrationBuilder.AlterColumn<int>(
                name: "GuitarBillID",
                table: "Guitars",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Guitars_GuitarBills_GuitarBillID",
                table: "Guitars",
                column: "GuitarBillID",
                principalTable: "GuitarBills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guitars_GuitarBills_GuitarBillID",
                table: "Guitars");

            migrationBuilder.RenameColumn(
                name: "GuitarBillID",
                table: "Guitars",
                newName: "GuitarBillId");

            migrationBuilder.RenameIndex(
                name: "IX_Guitars_GuitarBillID",
                table: "Guitars",
                newName: "IX_Guitars_GuitarBillId");

            migrationBuilder.AlterColumn<int>(
                name: "GuitarBillId",
                table: "Guitars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "GuitarBills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Guitars_GuitarBills_GuitarBillId",
                table: "Guitars",
                column: "GuitarBillId",
                principalTable: "GuitarBills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
