using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_De_Stock.Migrations
{
    public partial class AddCoPrStLnCo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Clients_ClientId",
                table: "Commandes");

            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Fournisseurs_FournisseurId",
                table: "Commandes");

            migrationBuilder.DropForeignKey(
                name: "FK_LigneCommandes_Commandes_CommandeId",
                table: "LigneCommandes");

            migrationBuilder.DropForeignKey(
                name: "FK_LigneCommandes_Produits_ProduitId",
                table: "LigneCommandes");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Fournisseurs_FournisseurId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Produits_ProduitId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produits",
                table: "Produits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LigneCommandes",
                table: "LigneCommandes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fournisseurs",
                table: "Fournisseurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commandes",
                table: "Commandes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "Stock");

            migrationBuilder.RenameTable(
                name: "Produits",
                newName: "Produit");

            migrationBuilder.RenameTable(
                name: "LigneCommandes",
                newName: "LigneCommande");

            migrationBuilder.RenameTable(
                name: "Fournisseurs",
                newName: "Fournisseur");

            migrationBuilder.RenameTable(
                name: "Commandes",
                newName: "Commande");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_ProduitId",
                table: "Stock",
                newName: "IX_Stock_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_FournisseurId",
                table: "Stock",
                newName: "IX_Stock_FournisseurId");

            migrationBuilder.RenameIndex(
                name: "IX_LigneCommandes_ProduitId",
                table: "LigneCommande",
                newName: "IX_LigneCommande_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_LigneCommandes_CommandeId",
                table: "LigneCommande",
                newName: "IX_LigneCommande_CommandeId");

            migrationBuilder.RenameIndex(
                name: "IX_Commandes_FournisseurId",
                table: "Commande",
                newName: "IX_Commande_FournisseurId");

            migrationBuilder.RenameIndex(
                name: "IX_Commandes_ClientId",
                table: "Commande",
                newName: "IX_Commande_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock",
                table: "Stock",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produit",
                table: "Produit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LigneCommande",
                table: "LigneCommande",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fournisseur",
                table: "Fournisseur",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commande",
                table: "Commande",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Client_ClientId",
                table: "Commande",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Fournisseur_FournisseurId",
                table: "Commande",
                column: "FournisseurId",
                principalTable: "Fournisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LigneCommande_Commande_CommandeId",
                table: "LigneCommande",
                column: "CommandeId",
                principalTable: "Commande",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LigneCommande_Produit_ProduitId",
                table: "LigneCommande",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Fournisseur_FournisseurId",
                table: "Stock",
                column: "FournisseurId",
                principalTable: "Fournisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Produit_ProduitId",
                table: "Stock",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Client_ClientId",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Fournisseur_FournisseurId",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_LigneCommande_Commande_CommandeId",
                table: "LigneCommande");

            migrationBuilder.DropForeignKey(
                name: "FK_LigneCommande_Produit_ProduitId",
                table: "LigneCommande");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Fournisseur_FournisseurId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Produit_ProduitId",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produit",
                table: "Produit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LigneCommande",
                table: "LigneCommande");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fournisseur",
                table: "Fournisseur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commande",
                table: "Commande");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Stock",
                newName: "Stocks");

            migrationBuilder.RenameTable(
                name: "Produit",
                newName: "Produits");

            migrationBuilder.RenameTable(
                name: "LigneCommande",
                newName: "LigneCommandes");

            migrationBuilder.RenameTable(
                name: "Fournisseur",
                newName: "Fournisseurs");

            migrationBuilder.RenameTable(
                name: "Commande",
                newName: "Commandes");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_ProduitId",
                table: "Stocks",
                newName: "IX_Stocks_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_FournisseurId",
                table: "Stocks",
                newName: "IX_Stocks_FournisseurId");

            migrationBuilder.RenameIndex(
                name: "IX_LigneCommande_ProduitId",
                table: "LigneCommandes",
                newName: "IX_LigneCommandes_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_LigneCommande_CommandeId",
                table: "LigneCommandes",
                newName: "IX_LigneCommandes_CommandeId");

            migrationBuilder.RenameIndex(
                name: "IX_Commande_FournisseurId",
                table: "Commandes",
                newName: "IX_Commandes_FournisseurId");

            migrationBuilder.RenameIndex(
                name: "IX_Commande_ClientId",
                table: "Commandes",
                newName: "IX_Commandes_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produits",
                table: "Produits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LigneCommandes",
                table: "LigneCommandes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fournisseurs",
                table: "Fournisseurs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commandes",
                table: "Commandes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Clients_ClientId",
                table: "Commandes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Fournisseurs_FournisseurId",
                table: "Commandes",
                column: "FournisseurId",
                principalTable: "Fournisseurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LigneCommandes_Commandes_CommandeId",
                table: "LigneCommandes",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LigneCommandes_Produits_ProduitId",
                table: "LigneCommandes",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Fournisseurs_FournisseurId",
                table: "Stocks",
                column: "FournisseurId",
                principalTable: "Fournisseurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Produits_ProduitId",
                table: "Stocks",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
