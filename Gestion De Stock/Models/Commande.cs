using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_De_Stock.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public int FournisseurId { get; set;}
        [ForeignKey("FournisseurId")]
        public Fournisseur Fournisseur { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
