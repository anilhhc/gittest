using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class COUNTRiesController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: COUNTRies
        public ActionResult Index()
        {
            return View(db.COUNTRies.ToList());
        }

        // GET: COUNTRies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COUNTRy cOUNTRY = db.COUNTRies.Find(id);
            if (cOUNTRY == null)
            {
                return HttpNotFound();
            }
            return View(cOUNTRY);
        }

        // GET: COUNTRies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: COUNTRies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COUNTRYID,COUNTRYNAME,ACTIVE")] COUNTRy cOUNTRY)
        {
            if (ModelState.IsValid)
            {
                db.COUNTRies.Add(cOUNTRY);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cOUNTRY);
        }

        // GET: COUNTRies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COUNTRy cOUNTRY = db.COUNTRies.Find(id);
            if (cOUNTRY == null)
            {
                return HttpNotFound();
            }
            return View(cOUNTRY);
        }

        // POST: COUNTRies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COUNTRYID,COUNTRYNAME,ACTIVE")] COUNTRy cOUNTRY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cOUNTRY).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cOUNTRY);
        }

        // GET: COUNTRies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COUNTRy cOUNTRY = db.COUNTRies.Find(id);
            if (cOUNTRY == null)
            {
                return HttpNotFound();
            }
            return View(cOUNTRY);
        }

        // POST: COUNTRies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            COUNTRy cOUNTRY = db.COUNTRies.Find(id);
            db.COUNTRies.Remove(cOUNTRY);
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
