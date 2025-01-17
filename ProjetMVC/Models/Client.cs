using System.ComponentModel.DataAnnotations;

namespace ProjetMVC.Models
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Merci de saisir le nom")]
        [MinLength(2, ErrorMessage = "Au moins deux caractères")]
        public string Nom { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Prenom")]
        [Required(ErrorMessage = "Merci de saisir le prenom")]
        [MinLength(2, ErrorMessage = "Au moins deux caractères")]
        public string Prenom { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Adresse Email")]
        [Required(ErrorMessage = "Merci de saisir l'adresse email")]
        [MinLength(2, ErrorMessage = "Au moins deux caractères")]
        public string AdresseEmail { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Merci de saisir le mot de passe")]
        public string Password { get; set; }
        


    }
}