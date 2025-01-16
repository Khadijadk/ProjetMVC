using Microsoft.AspNetCore.Mvc;

namespace ProjetMVC.Controllers
{
    public class CommandeController : Controller
    {
        public IActionResult Ajouter()
        {
            return View();
        }
        public IActionResult Supprimer()
        {
            return View();
        }

        public IActionResult Modifier()
        {
            return View();
        }
    }
}
