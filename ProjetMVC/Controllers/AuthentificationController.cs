using Microsoft.AspNetCore.Mvc;
using ProjetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetMVC.Controllers
{
    public class AuthentificationController : Controller
    {
        private readonly Myctx _context;
        public AuthentificationController(Myctx context)
        {

            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Client.ToList());
        }
        public IActionResult Connexion()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Connexion([Bind("Id,AdresseEmail,Password")] Client client)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(client);
        //        _context.SaveChanges();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(client);
        //}
        public IActionResult Inscription()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Inscription([Bind("Id,Nom,Prenom,AdresseEmail,Password")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Produits/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Client.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nom,")] Produit client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProduitExists(client.Id))
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
            return View(client);
        }

        // GET: Produits/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Client
                .FirstOrDefault(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var client = _context.Client.Find(id);
            if (client != null)
            {
                _context.Client.Remove(client);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ProduitExists(int id)
        {
            return _context.Client.Any(e => e.Id == id);
        }

        public IActionResult Modifier()
        {
            return View();
        }
        public IActionResult Supprimer()
        {
            return View();
        }


        public IActionResult Déconnexion()
        {
            return View();
        }
    }
}
