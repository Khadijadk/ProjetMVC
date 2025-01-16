using Microsoft.AspNetCore.Mvc;

namespace ProjetMVC.Controllers
{
    public class ProduitController : Controller
    {
        public IActionResult Ajouter()
        {
            return View();
        }
        public IActionResult Modifier()
        {
            return View();
        }
        public IActionResult Supprimer()
        {
            return View();
        }
    }
}
