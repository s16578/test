using Microsoft.EntityFrameworkCore.Migrations;

namespace test.Migrations
{
    public partial class UpdatedTables5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_Zamowienia_IdWyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_WyrobyCukiernicze_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_WyrobyCukiernicze_IdWyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdWyrobuCukierniczego",
                principalTable: "WyrobyCukiernicze",
                principalColumn: "IdWyrobuCukierniczego",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_Zamowienia_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdZamowienia",
                principalTable: "Zamowienia",
                principalColumn: "IdZamowienia",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_WyrobyCukiernicze_IdWyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_Zamowienia_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_Zamowienia_IdWyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdWyrobuCukierniczego",
                principalTable: "Zamowienia",
                principalColumn: "IdZamowienia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_WyrobyCukiernicze_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdZamowienia",
                principalTable: "WyrobyCukiernicze",
                principalColumn: "IdWyrobuCukierniczego",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
