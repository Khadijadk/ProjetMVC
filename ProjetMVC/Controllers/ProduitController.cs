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
        // GET: Produits
        public IActionResult Index()
        {
            return View(_context.Produit.ToList());
        }

        // GET: Produits/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = _context.Produit
                .FirstOrDefault(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,Nom,Prix")] Produit produit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produit);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produit);
        }

        // GET: Produits/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = _context.Produit.Find(id);
            if (produit == null)
            {
                return NotFound();
            }
            return View(produit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nom,Prix")] Produit produit)
        {
            if (id != produit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produit);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProduitExists(produit.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produit);
        }

        // GET: Produits/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = _context.Produit
                .FirstOrDefault(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var produit = _context.Produit.Find(id);
            if (produit != null)
            {
                _context.Produit.Remove(produit);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ProduitExists(int id)
        {
            return _context.Produit.Any(e => e.Id == id);
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