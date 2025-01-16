using Microsoft.AspNetCore.Mvc;

namespace ProjetMVC.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Afficher()
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
