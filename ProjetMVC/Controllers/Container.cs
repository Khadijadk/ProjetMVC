using Microsoft.AspNetCore.Mvc;

namespace ProjetMVC.Controllers
{
    public class Container : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
