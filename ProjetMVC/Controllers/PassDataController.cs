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
       


        public IActionResult Details()
        {
            var product = new Produit
            {
                Id = 1,
                Nom = "Laptop",
                Prix = 999,
            };

            ViewData["Product"] = product;
            return View();
        }

        public IActionResult Details2()
        {
            var product = new Produit
            {
                Id = 1,
                Nom = "Laptop",
                Prix = 999,
            };

            var client = new Client
            {
                Nom = "Darkaoui",
                AdresseEmail = "Darkaoui56@gmail.com",

            };
            var viewModel = new ClientProduit
            {
                produits = product,
                clients = client,
            };
            return View(viewModel);
        }




    }
}
