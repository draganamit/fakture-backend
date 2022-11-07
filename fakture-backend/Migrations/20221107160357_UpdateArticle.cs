using Microsoft.EntityFrameworkCore.Migrations;

namespace fakture_backend.Migrations
{
    public partial class UpdateArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IznostSaRabatomBezPdv",
                table: "Article");

            migrationBuilder.AddColumn<float>(
                name: "IznosSaRabatomBezPdv",
                table: "Article",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IznosSaRabatomBezPdv",
                table: "Article");

            migrationBuilder.AddColumn<float>(
                name: "IznostSaRabatomBezPdv",
                table: "Article",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
