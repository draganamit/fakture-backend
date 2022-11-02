using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fakture_backend.Migrations
{
    public partial class facture1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    Partner = table.Column<string>(nullable: true),
                    IznosBezPdv = table.Column<float>(nullable: false),
                    PostoRabata = table.Column<float>(nullable: false),
                    Rabat = table.Column<float>(nullable: false),
                    IznosSaRabatomBezPdv = table.Column<float>(nullable: false),
                    Pdv = table.Column<float>(nullable: false),
                    Ukupno = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facture");
        }
    }
}
