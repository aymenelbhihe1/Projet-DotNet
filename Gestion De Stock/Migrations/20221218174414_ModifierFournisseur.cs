using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_De_Stock.Migrations
{
    public partial class ModifierFournisseur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomComplet",
                table: "Fournisseur",
                newName: "NomCompletF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomCompletF",
                table: "Fournisseur",
                newName: "NomComplet");
        }
    }
}
