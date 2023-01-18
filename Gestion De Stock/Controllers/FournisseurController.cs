using Gestion_De_Stock.Data;
using Gestion_De_Stock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestion_De_Stock.Controllers
{
    public class FournisseurController : Controller
    {
        private readonly ApplicationDBContext _db;
        public FournisseurController(ApplicationDBContext db)
        {
            _db = db;
        }
        // GET: FournisseurController
        public ActionResult ListFournisseur()
        {
            IEnumerable<Fournisseur> fournisseurs = _db.Fournisseurs;
            return View(fournisseurs);
        }

        // GET: FournisseurController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FournisseurController/Create
        public ActionResult Create(Fournisseur fournisseur)
        {
            if (ModelState.IsValid)
            {
                _db.Fournisseurs.Add(fournisseur);
                _db.SaveChanges();
                return RedirectToAction("ListFournisseur");
            }
            return View();
        }
        // GET: FournisseurController/Edit/5
        public ActionResult Edit(int id)
        {
            var fournisseur = _db.Fournisseurs.Find(id);
            return View(fournisseur);
        }

        // POST: FournisseurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fournisseur fournisseur)
        {
            _db.Entry(fournisseur).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("ListFournisseur");
        }
        // GET: FournisseurController/Delete/5
        public ActionResult Delete(int id)
        {
            var fournisseur = _db.Fournisseurs.Find(id);
            return View(fournisseur);
        }

        // POST: FournisseurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Fournisseur fournisseur)
        {
            _db.Fournisseurs.Remove(fournisseur);
            _db.SaveChanges();
            return RedirectToAction("ListFournisseur");
        }
    }
}
