using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DFIdari.Models;

namespace DFIdari.Controllers
{
    public class PersonelController : Controller
    {
        private DFIdariEntities db = new DFIdariEntities();

        // GET: Personel
        public ActionResult Index()
        {
            return View(db.Personels.ToList());
        }

        // GET: Personel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personel personel = db.Personels.Find(id);
            if (personel == null)
            {
                return HttpNotFound();
            }
            return View(personel);
        }

        // GET: Personel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BolumId,Adi,Yas,Gorev")] Personel personel)
        {
            if (ModelState.IsValid)
            {
                db.Personels.Add(personel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personel);
        }

        // GET: Personel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personel personel = db.Personels.Find(id);
            if (personel == null)
            {
                return HttpNotFound();
            }
            return View(personel);
        }

        // POST: Personel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BolumId,Adi,Yas,Gorev")] Personel personel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personel);
        }

        // GET: Personel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personel personel = db.Personels.Find(id);
            if (personel == null)
            {
                return HttpNotFound();
            }
            return View(personel);
        }

        // POST: Personel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personel personel = db.Personels.Find(id);
            db.Personels.Remove(personel);
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
