using Microsoft.AspNetCore.Mvc;
using ProjetMVC.Models;

namespace ProjetMVC.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.message = "MyviewBag";
            ViewData["Message"] = "Myviewdata";

            TempData["age"] = "Salam Alioune";
            var data = TempData["age"];
            ViewData["user"] = data;
            TempData.Keep();

            return View();
        }

        public IActionResult Index2()
        {
            ViewData["user2"] = TempData["age"];
           

            return View();
        }

   
    }
}
