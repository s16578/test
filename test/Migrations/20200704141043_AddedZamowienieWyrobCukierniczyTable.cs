using Microsoft.EntityFrameworkCore.Migrations;

namespace test.Migrations
{
    public partial class AddedZamowienieWyrobCukierniczyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienia_Klientci_KlientIdKlient",
                table: "Zamowienia");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienia_Pracownicy_PracownikIdPracownika",
                table: "Zamowienia");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienia_KlientIdKlient",
                table: "Zamowienia");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienia_PracownikIdPracownika",
                table: "Zamowienia");

            migrationBuilder.DropColumn(
                name: "KlientIdKlient",
                table: "Zamowienia");

            migrationBuilder.DropColumn(
                name: "PracownikIdPracownika",
                table: "Zamowienia");

            migrationBuilder.CreateTable(
                name: "Zamowienie_WyrobCukierniczy",
                columns: table => new
                {
                    IdWyrobuCukierniczego = table.Column<int>(nullable: false),
                    IdZamowienia = table.Column<int>(nullable: false),
                    Ilosc = table.Column<int>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie_WyrobCukierniczy", x => new { x.IdWyrobuCukierniczego, x.IdZamowienia });
                    table.ForeignKey(
                        name: "FK_Zamowienie_WyrobCukierniczy_Zamowienia_IdWyrobuCukierniczego",
                        column: x => x.IdWyrobuCukierniczego,
                        principalTable: "Zamowienia",
                        principalColumn: "IdZamowienia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamowienie_WyrobCukierniczy_WyrobyCukiernicze_IdZamowienia",
                        column: x => x.IdZamowienia,
                        principalTable: "WyrobyCukiernicze",
                        principalColumn: "IdWyrobuCukierniczego",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_IdKlient",
                table: "Zamowienia",
                column: "IdKlient");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_IdPracownik",
                table: "Zamowienia",
                column: "IdPracownik");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_WyrobCukierniczy_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdZamowienia");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienia_Klientci_IdKlient",
                table: "Zamowienia",
                column: "IdKlient",
                principalTable: "Klientci",
                principalColumn: "IdKlient",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienia_Pracownicy_IdPracownik",
                table: "Zamowienia",
                column: "IdPracownik",
                principalTable: "Pracownicy",
                principalColumn: "IdPracownik",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienia_Klientci_IdKlient",
                table: "Zamowienia");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienia_Pracownicy_IdPracownik",
                table: "Zamowienia");

            migrationBuilder.DropTable(
                name: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienia_IdKlient",
                table: "Zamowienia");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienia_IdPracownik",
                table: "Zamowienia");

            migrationBuilder.AddColumn<int>(
                name: "KlientIdKlient",
                table: "Zamowienia",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PracownikIdPracownika",
                table: "Zamowienia",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_KlientIdKlient",
                table: "Zamowienia",
                column: "KlientIdKlient");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_PracownikIdPracownika",
                table: "Zamowienia",
                column: "PracownikIdPracownika");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienia_Klientci_KlientIdKlient",
                table: "Zamowienia",
                column: "KlientIdKlient",
                principalTable: "Klientci",
                principalColumn: "IdKlient",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienia_Pracownicy_PracownikIdPracownika",
                table: "Zamowienia",
                column: "PracownikIdPracownika",
                principalTable: "Pracownicy",
                principalColumn: "IdPracownik",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
