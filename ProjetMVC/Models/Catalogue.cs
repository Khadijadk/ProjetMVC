using System.ComponentModel.DataAnnotations;

namespace ProjetMVC.Models
{
    public class Catalogue{

        [Key]
        public int num { get; set; }
        public string nom { get; set; }
        public string image { get; set; }
        public string description { get; set; }

    }
}
