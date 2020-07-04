using Microsoft.EntityFrameworkCore.Migrations;

namespace test.Migrations
{
    public partial class AddedKlientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KlientIdKlient",
                table: "Zamowienia",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Klientci",
                columns: table => new
                {
                    IdKlient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klientci", x => x.IdKlient);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_KlientIdKlient",
                table: "Zamowienia",
                column: "KlientIdKlient");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienia_Klientci_KlientIdKlient",
                table: "Zamowienia",
                column: "KlientIdKlient",
                principalTable: "Klientci",
                principalColumn: "IdKlient",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienia_Klientci_KlientIdKlient",
                table: "Zamowienia");

            migrationBuilder.DropTable(
                name: "Klientci");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienia_KlientIdKlient",
                table: "Zamowienia");

            migrationBuilder.DropColumn(
                name: "KlientIdKlient",
                table: "Zamowienia");
        }
    }
}
