using Gestion_De_Stock.Data;
using Gestion_De_Stock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestion_De_Stock.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDBContext _db;
        public ClientController(ApplicationDBContext db)
        {
            _db = db;
        }
        // GET: ClientController
        public ActionResult ListClient()
        {
            IEnumerable<Client> objList = _db.Clients;
            return View(objList);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        //GET : ClientController/Createµ
        public ActionResult Create()
        {
            return View();
        }
        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Add(client);
                _db.SaveChanges();
                return RedirectToAction("ListClient");
            }
            return View();
        }
        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            var client= _db.Clients.Find(id);
            return View(client);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Client client)
        {
            _db.Entry(client).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("ListClient");
        }

        
        public ActionResult Delete(int id)
        {
            var client = _db.Clients.Find(id);
            return View(client);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Client client)
        {
            if (client == null)
            {
                return NotFound();
            }
            _db.Clients.Remove(client);
            _db.SaveChanges();
            return RedirectToAction("ListClient");
        }
    }
}
