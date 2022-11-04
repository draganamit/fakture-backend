using Microsoft.EntityFrameworkCore.Migrations;

namespace fakture_backend.Migrations
{
    public partial class cascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Facture_FactureId",
                table: "Article");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Facture_FactureId",
                table: "Article",
                column: "FactureId",
                principalTable: "Facture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Facture_FactureId",
                table: "Article");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Facture_FactureId",
                table: "Article",
                column: "FactureId",
                principalTable: "Facture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
