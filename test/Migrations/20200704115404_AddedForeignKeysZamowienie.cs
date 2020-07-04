using Microsoft.EntityFrameworkCore.Migrations;

namespace test.Migrations
{
    public partial class AddedForeignKeysZamowienie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPracownika",
                table: "Zamowienia");

            migrationBuilder.AddColumn<int>(
                name: "IdPracownik",
                table: "Zamowienia",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPracownik",
                table: "Zamowienia");

            migrationBuilder.AddColumn<int>(
                name: "IdPracownika",
                table: "Zamowienia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
