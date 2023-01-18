using System.ComponentModel.DataAnnotations;

namespace Gestion_De_Stock.Models
{
    public class Fournisseur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NomCompletF { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}
