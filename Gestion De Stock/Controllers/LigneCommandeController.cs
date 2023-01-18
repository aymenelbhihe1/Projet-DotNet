using Gestion_De_Stock.Data;
using Gestion_De_Stock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Gestion_De_Stock.Controllers
{
    public class LigneCommandeController : Controller
    {
        private readonly ApplicationDBContext _db;
        public LigneCommandeController(ApplicationDBContext db)
        {
            _db = db;
        }
        // GET: LigneCommandeController
        public ActionResult ListLigneCommande()
        {
            var ListLigneCommande = _db.LigneCommandes.Include(c => c.Commande)
                                                      .Include(p => p.Produit).ToList();
            return View(ListLigneCommande);
        }
        // GET: LigneCommandeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: LigneCommandeController/Create
        public ActionResult Create()
        {
            ViewBag.ListCommande = new SelectList(_db.Commandes.ToList(), "Id", "Id");
            ViewBag.ListProduit = new SelectList(_db.Produits.ToList(), "Id", "Nom");
            return View();
        }

        // POST: LigneCommandeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LigneCommande ligneCommande)
        {
            var prix = _db.Produits.Find(ligneCommande.ProduitId).Prix;
            ligneCommande.Total = prix * ligneCommande.Quantite;
            _db.LigneCommandes.Add(ligneCommande);
            _db.SaveChanges();
            return RedirectToAction("ListLigneCommande");
        }

        // GET: LigneCommandeController/Edit/5
        public ActionResult Edit(int id)
        {
            var ligneCommande = _db.LigneCommandes.Find(id);
            ViewBag.ListCommande = new SelectList(_db.Commandes.ToList(), "Id", "Id");
            ViewBag.ListProduit = new SelectList(_db.Produits.ToList(), "Id", "Nom");
            return View(ligneCommande);
        }

        // POST: LigneCommandeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LigneCommande ligneCommande)
        {
            ligneCommande.Total = ligneCommande.Produit.Prix * ligneCommande.Quantite;
            _db.LigneCommandes.Update(ligneCommande);
            _db.SaveChanges();
            return RedirectToAction("ListLigneCommande");
        }
        // GET: LigneCommandeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LigneCommandeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
