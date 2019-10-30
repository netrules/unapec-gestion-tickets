using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;

namespace MVCCrud.Controllers
{
    public class DecanatoesController : Controller
    {
        private DecanatoDBContext db = new DecanatoDBContext();

        // GET: Decanatoes
        public ActionResult Index()
        {
            return View(db.Decanatos.ToList());
        }

        // GET: Decanatoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Decanato decanato = db.Decanatos.Find(id);
            if (decanato == null)
            {
                return HttpNotFound();
            }
            return View(decanato);
        }

        // GET: Decanatoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Decanatoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Decanato decanato)
        {
            if (ModelState.IsValid)
            {
                db.Decanatos.Add(decanato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(decanato);
        }

        // GET: Decanatoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Decanato decanato = db.Decanatos.Find(id);
            if (decanato == null)
            {
                return HttpNotFound();
            }
            return View(decanato);
        }

        // POST: Decanatoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Decanato decanato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(decanato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(decanato);
        }

        // GET: Decanatoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Decanato decanato = db.Decanatos.Find(id);
            if (decanato == null)
            {
                return HttpNotFound();
            }
            return View(decanato);
        }

        // POST: Decanatoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Decanato decanato = db.Decanatos.Find(id);
            db.Decanatos.Remove(decanato);
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
