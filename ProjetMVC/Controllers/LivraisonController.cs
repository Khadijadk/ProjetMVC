using Microsoft.AspNetCore.Mvc;

namespace ProjetMVC.Controllers
{
    public class LivraisonController : Controller
    {
        public IActionResult AjouterAdresse()
        {
            return View();
        }
    

         public IActionResult ModeLivraison()
        {
            return View();
        }

        public IActionResult Annuler()
        {
            return View();
        }
    }
}

