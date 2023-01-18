using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_De_Stock.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProduitId { get; set; }
        [ForeignKey("ProduitId")]
        public Produit Produit { get; set; }
        public int FournisseurId { get; set; }
        [ForeignKey("FournisseurId")]
        public Fournisseur Fournisseur { get; set; }
        public int Quantite { get; set; }

    }
}
