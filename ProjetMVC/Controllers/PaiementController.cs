using Microsoft.AspNetCore.Mvc;

namespace ProjetMVC.Controllers
{
    public class PaiementController : Controller
    {
     
        public IActionResult ModePaiement()
        {
            return View();
        }
        public IActionResult ValiderPaiement()
        {
            return View();
        }

        public IActionResult Annuler()
        {
            return View();
        }
    }
}
