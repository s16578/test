using Microsoft.EntityFrameworkCore.Migrations;

namespace test.Migrations
{
    public partial class UpdatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienia_Pracownicy_IdPracownik",
                table: "Zamowienia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pracownicy",
                table: "Pracownicy");

            migrationBuilder.DropColumn(
                name: "IdPracownika",
                table: "Pracownicy");

            migrationBuilder.AddColumn<int>(
                name: "IdPracownik",
                table: "Pracownicy",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pracownicy",
                table: "Pracownicy",
                column: "IdPracownik");

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
                name: "FK_Zamowienia_Pracownicy_IdPracownik",
                table: "Zamowienia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pracownicy",
                table: "Pracownicy");

            migrationBuilder.DropColumn(
                name: "IdPracownik",
                table: "Pracownicy");

            migrationBuilder.AddColumn<int>(
                name: "IdPracownika",
                table: "Pracownicy",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pracownicy",
                table: "Pracownicy",
                column: "IdPracownika");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienia_Pracownicy_IdPracownik",
                table: "Zamowienia",
                column: "IdPracownik",
                principalTable: "Pracownicy",
                principalColumn: "IdPracownika",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
