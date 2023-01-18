using Gestion_De_Stock.Data;
using Gestion_De_Stock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Gestion_De_Stock.Controllers
{
    public class StockController : Controller
    {
        private readonly ApplicationDBContext _db;
        public StockController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: StockController
        public ActionResult ListStock()
        {
            var listStock = _db.Stocks.Include(s => s.Produit)
                                      .Include(s => s.Fournisseur);
            return View(listStock);
        }

        // GET: StockController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StockController/Create
        public ActionResult Create()
        {
            ViewBag.ListProduit= new SelectList(_db.Produits, "Id", "Nom");
            ViewBag.ListFournisseur = new SelectList(_db.Fournisseurs, "Id", "NomCompletF");
            return View();
        }

        // POST: StockController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stock stock)
        {
                _db.Stocks.Add(stock);
                _db.SaveChanges();
                return RedirectToAction("ListStock");
        }

        // GET: StockController/Edit/5
        public ActionResult Edit(int id)
        {
            var stock = _db.Stocks.Find(id);
            ViewBag.ListProduit = new SelectList(_db.Produits, "Id", "Nom");
            ViewBag.ListFournisseur = new SelectList(_db.Fournisseurs, "Id", "NomCompletF");
            return View(stock);
        }

        // POST: StockController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Stock stock)
        {
            _db.Entry(stock).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("ListStock");
        }

        // GET: StockController/Delete/5
        public ActionResult Delete(int id)
        {
            var stock = _db.Stocks.Find(id);
            return View(stock);
        }

        // POST: StockController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Stock stock)
        {
            _db.Stocks.Remove(stock);
            _db.SaveChanges();
            return RedirectToAction("ListStock");
        }
    }
}
