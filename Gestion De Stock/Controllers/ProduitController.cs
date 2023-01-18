using Gestion_De_Stock.Data;
using Gestion_De_Stock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestion_De_Stock.Controllers
{
    public class ProduitController : Controller
    {
        private readonly ApplicationDBContext _db;
        public ProduitController(ApplicationDBContext db)
        {
            _db = db;
        }
        // GET: ProduitController
        public ActionResult ListProduit()
        {
            IEnumerable<Produit> produit = _db.Produits;
            return View(produit);
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            var produit = _db.Produits.Find(id);
            return View(produit);
        }
        // GET: ProduitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produit produit)
        {
            if (ModelState.IsValid)
            {
                _db.Produits.Add(produit);
                _db.SaveChanges();
                return RedirectToAction("ListProduit");
            }
            return View(produit);
        }

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            var produit =_db.Produits.Find(id);
            return View(produit);
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produit produit)
        {
            _db.Entry(produit).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("ListProduit");
        }
        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            var produit = _db.Produits.Find(id);
            return View(produit);
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Produit produit)
        {
            _db.Produits.Remove(produit);
            _db.SaveChanges();
            return RedirectToAction("ListProduit");
        }
    }
}
