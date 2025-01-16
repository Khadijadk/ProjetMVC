using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetMVC.Models;

namespace ProjetMVC.Controllers
{
    public class HomeController : Controller
    {
        string salut = "Bonjour khathil khadija , salam alley koum";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.salut = salut;
            ViewBag.message = "Hello Alioune tu dois partir à la préfécture et faire une grève pour qu'ils te donnent un rendez-vous";


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
