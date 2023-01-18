using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace Gestion_De_Stock.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NomComplet { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Ville { get; set; }

    }
}
