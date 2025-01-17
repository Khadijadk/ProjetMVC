using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetMVC.Models;

namespace ProjetMVC.Controllers
{
    public class ProduitController : Controller
    {
        private readonly Myctx _context;
        public ProduitController(Myctx context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,Nom,Prix")] Produit product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
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