//using Microsoft.AspNetCore.Mvc;
//using ProjetMVC.Models;

//namespace ProjetMVC.Controllers
//{
//    public class ClientController : Controller
//    {
//        public IActionResult Ajouter()
//        {
//            Client client = new Client();
//            client.AdresseEmail = "Khadija@gmail.com";
//            client.Prenom = "Khadija";
//            client.Nom = "Darkaoui";
//            ViewBag.AdresseEmail = client.AdresseEmail;
//            ViewBag.Prénom = client.Prenom;
//            ViewBag.Nom = client.Nom;

//            ViewData["Nom"] = "Cli1";
//            ViewData["Message"] = "bonjour";



//            return View();
//        }

//        public IActionResult Modifier()
//        {
//            return View();
//        }

//        public IActionResult Supprimer()
//        {
//            return View();
//        }
//    }
//}
