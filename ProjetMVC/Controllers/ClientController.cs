using Microsoft.AspNetCore.Mvc;
using ProjetMVC.Models;

namespace ProjetMVC.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Client()
        {
            Client client = new Client();
            client.AdresseEmail = "Khadija@gmail.com";
            client.Prénom = "Khadija";
            client.Nom = "Darkaoui";
            ViewBag.AdresseEmail = client.AdresseEmail;
            ViewBag.Prénom = client.Prénom;
            ViewBag.Nom = client.Nom;

         

           

            return View();
        }
    }
}
