using Gestion_De_Stock.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Gestion_De_Stock.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<LigneCommande> LigneCommandes { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Fournisseur>().ToTable("Fournisseur");
            modelBuilder.Entity<Commande>().ToTable("Commande");
            modelBuilder.Entity<LigneCommande>().ToTable("LigneCommande");
            modelBuilder.Entity<Produit>().ToTable("Produit");
            modelBuilder.Entity<Stock>().ToTable("Stock");
        }

    }
}

