using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarShop.Server.Migrations
{
    public partial class DodatId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Guitars",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GuitarBills",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Guitars",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "GuitarBills",
                newName: "Id");
        }
    }
}
