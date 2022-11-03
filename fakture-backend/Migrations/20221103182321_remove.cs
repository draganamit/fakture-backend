using Microsoft.EntityFrameworkCore.Migrations;

namespace fakture_backend.Migrations
{
    public partial class remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Facture_FakturaId",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_FakturaId",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "FakturaId",
                table: "Article");

            migrationBuilder.AddColumn<int>(
                name: "FactureId",
                table: "Article",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Article_FactureId",
                table: "Article",
                column: "FactureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Facture_FactureId",
                table: "Article",
                column: "FactureId",
                principalTable: "Facture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Facture_FactureId",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_FactureId",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "FactureId",
                table: "Article");

            migrationBuilder.AddColumn<int>(
                name: "FakturaId",
                table: "Article",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Article_FakturaId",
                table: "Article",
                column: "FakturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Facture_FakturaId",
                table: "Article",
                column: "FakturaId",
                principalTable: "Facture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
