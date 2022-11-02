using Microsoft.EntityFrameworkCore.Migrations;

namespace fakture_backend.Migrations
{
    public partial class article : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Kolicina = table.Column<int>(nullable: false),
                    Cijena = table.Column<float>(nullable: false),
                    IznosBezPdv = table.Column<float>(nullable: false),
                    PostoRabata = table.Column<float>(nullable: false),
                    Rabat = table.Column<float>(nullable: false),
                    IznostSaRabatomBezPdv = table.Column<float>(nullable: false),
                    Pdv = table.Column<float>(nullable: false),
                    Ukupno = table.Column<float>(nullable: false),
                    FactureId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Facture_FactureId",
                        column: x => x.FactureId,
                        principalTable: "Facture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_FactureId",
                table: "Article",
                column: "FactureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}
