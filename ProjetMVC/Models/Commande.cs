using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetMVC.Models
{
    public class Commande{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Numéro { get; set; }
        public DateTime datedecommande{ get; set; }
        public DateTime datedeLivraison { get; set; }





    }
}
