using System.ComponentModel.DataAnnotations;

namespace ProjetMVC.Models
{
    public class Produit
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Nom { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public decimal Prix { get; set; }

    }
}
