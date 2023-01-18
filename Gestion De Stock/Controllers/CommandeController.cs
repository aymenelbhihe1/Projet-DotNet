using Gestion_De_Stock.Data;
using Gestion_De_Stock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gestion_De_Stock.Controllers
{
    public class CommandeController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CommandeController(ApplicationDBContext db)
        {
            _db = db;
        }
        // GET: CommandeController
        public ActionResult ListCommande()
        {
            var listCommande = _db.Commandes.Include(c => c.Client)
                                  .Include(c => c.Fournisseur).ToList();
            return View(listCommande);
        }

        // GET: CommandeController/Details/5
        public ActionResult Details(int id)
        {
            var commande = _db.Commandes.Find(id);
            ViewData["nomClient"] = _db.Clients.Find(commande.ClientId).NomComplet;
            ViewData["nomFournisseur"] = _db.Fournisseurs.Find(commande.FournisseurId).NomCompletF;
            return View(commande);
        }

        // GET: CommandeController/Create
        public ActionResult Create()
        {
            ViewBag.ListClient = new SelectList(_db.Clients.ToList(), "Id", "NomComplet");
            ViewBag.ListFournisseur = new SelectList(_db.Fournisseurs.ToList(), "Id", "NomCompletF");
            return View();
        }
        // POST: CommandeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Commande commande)
        {
 
                _db.Commandes.Add(commande);
                _db.SaveChanges();
                return RedirectToAction("ListCommande");
        }

        // GET: CommandeController/Edit/5
        public ActionResult Edit(int id)
        {
            var commande = _db.Commandes.Find(id);
            ViewBag.ListClient = new SelectList(_db.Clients.ToList(), "Id", "NomComplet");
            ViewBag.ListFournisseur = new SelectList(_db.Fournisseurs.ToList(), "Id", "NomCompletF");
            return View(commande);
        }

        // POST: CommandeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Commande commande)
        {
            _db.Entry(commande).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("ListCommande");
        }
        public ActionResult Delete(int id)
        {
            var commande =_db.Commandes.Find(id);
            ViewData["nomClient"] = _db.Clients.Find(commande.ClientId).NomComplet;
            ViewData["nomFournisseur"] = _db.Fournisseurs.Find(commande.FournisseurId).NomCompletF;
            return View(commande);
        }
        // POST: CommandeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Commande commande)
        {
            _db.Commandes.Remove(commande);
            _db.SaveChanges();
            return RedirectToAction("ListCommande");
        }
    }
}
