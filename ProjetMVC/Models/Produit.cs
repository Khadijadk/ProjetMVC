
﻿using System.ComponentModel.DataAnnotations;

namespace ProjetMVC.Models
{
    public class Produit
    {
        public int Id { get; set; }
        
       
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Merci de saisir le nom")]
        [MinLength(2, ErrorMessage = "Au moins deux caractères")]
        public string Nom { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Prix")]
        [Required(ErrorMessage = "Merci de saisir le prix")]
        public double Prix { get; set; }

    }
}

