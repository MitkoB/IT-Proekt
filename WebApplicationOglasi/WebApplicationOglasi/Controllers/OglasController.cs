using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationOglasi.Models;

namespace WebApplicationOglasi.Controllers
{
    public class OglasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Oglas
        public ActionResult Index()
        {
            return View(db.Oglas.ToList());
        }
        public ActionResult Aparati()
        {
            return View(db.Oglas.ToList());
        }
        public ActionResult Avtomobili()
        {
            return View(db.Oglas.ToList());
        }
        public ActionResult Mebel()
        {
            return View(db.Oglas.ToList());

        }
        public ActionResult RabotnaPozicija()
        {
            return View(db.Oglas.ToList());
        }
        // GET: Oglas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oglas oglas = db.Oglas.Find(id);
            if (oglas == null)
            {
                return HttpNotFound();
            }
            return View(oglas);
        }

        // GET: Oglas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Oglas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,zanimanje,kategorija,pocetnaData,krajnaData,pravnoLice,opstina,adresa,email,telBroj,slikaUrl,opis")] Oglas oglas)
        {
            if (ModelState.IsValid)
            {
                db.Oglas.Add(oglas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oglas);
        }

        // GET: Oglas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oglas oglas = db.Oglas.Find(id);
            if (oglas == null)
            {
                return HttpNotFound();
            }
            return View(oglas);
        }

        // POST: Oglas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,zanimanje,kategorija,pocetnaData,krajnaData,pravnoLice,opstina,adresa,email,telBroj,slikaUrl,opis")] Oglas oglas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oglas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oglas);
        }

        // GET: Oglas/Delete/5
       [Authorize(Roles ="Administrator")]
        public ActionResult Delete(int id)
        {
            Oglas oglas = db.Oglas.Find(id);
            db.Oglas.Remove(oglas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
