
﻿using System.ComponentModel.DataAnnotations;

namespace ProjetMVC.Models
{
    public class Produit
    {
        public int Id { get; set; }
        
       
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Merci de saisir le nom")]
        [MinLength(2, ErrorMessage = "Au moins deux caractères")]
        public string Nom { get; set; }
 
        [Display(Name = "Prix")]
        [Required(ErrorMessage = "Merci de saisir le prix")]
        public double Prix { get; set; }

    }
}

