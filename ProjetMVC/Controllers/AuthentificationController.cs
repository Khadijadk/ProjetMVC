using Microsoft.AspNetCore.Mvc;

namespace ProjetMVC.Controllers
{
    public class AuthentificationController : Controller
    {
        public IActionResult Connexion()
        {
            return View();
        }
        public IActionResult Inscription()
        {
            return View();
        }
        public IActionResult Déconnexion()
        {
            return View();
        }
    }
}
