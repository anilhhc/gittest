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
    public class subareaCITiesController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: subareaCITies
        public ActionResult Index()
        {
            return View(db.subareaCITies.ToList());
        }

        // GET: subareaCITies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subareaCITy subareaCITy = db.subareaCITies.Find(id);
            if (subareaCITy == null)
            {
                return HttpNotFound();
            }
            return View(subareaCITy);
        }

        // GET: subareaCITies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: subareaCITies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "subareaCITYID,subareaCITYNAME,CITYID,ACTIVE")] subareaCITy subareaCITy)
        {
            if (ModelState.IsValid)
            {
                db.subareaCITies.Add(subareaCITy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subareaCITy);
        }

        // GET: subareaCITies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subareaCITy subareaCITy = db.subareaCITies.Find(id);
            if (subareaCITy == null)
            {
                return HttpNotFound();
            }
            return View(subareaCITy);
        }

        // POST: subareaCITies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "subareaCITYID,subareaCITYNAME,CITYID,ACTIVE")] subareaCITy subareaCITy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subareaCITy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subareaCITy);
        }

        // GET: subareaCITies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subareaCITy subareaCITy = db.subareaCITies.Find(id);
            if (subareaCITy == null)
            {
                return HttpNotFound();
            }
            return View(subareaCITy);
        }

        // POST: subareaCITies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            subareaCITy subareaCITy = db.subareaCITies.Find(id);
            db.subareaCITies.Remove(subareaCITy);
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
