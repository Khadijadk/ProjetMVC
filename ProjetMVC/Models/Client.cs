namespace ProjetMVC.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Prénom { get; set; }
        public string AdresseEmail { get; set; }
         private int Age { get; set; }
        


    }
}