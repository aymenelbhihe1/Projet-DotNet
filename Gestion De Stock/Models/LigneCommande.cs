using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_De_Stock.Models
{
    public class LigneCommande
    {
        public int Id { get; set; }
        public int ProduitId { get; set; }
        [ForeignKey("ProduitId")]
        public Produit Produit { get; set; }
        public int CommandeId { get; set; }
        [ForeignKey("CommandeId")]
        public Commande Commande { get; set; }
        public int Quantite { get; set; }
        public double Total { get; set; }
    }
}
