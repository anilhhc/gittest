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
    public class HproductslistsController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: Hproductslists
        public ActionResult Index()
        {
            return View(db.Hproductslists.ToList());
        }

        // GET: Hproductslists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hproductslist hproductslist = db.Hproductslists.Find(id);
            if (hproductslist == null)
            {
                return HttpNotFound();
            }
            return View(hproductslist);
        }

        // GET: Hproductslists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hproductslists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HproductslistID,HproductslistNAME,HproductslistDESC,Hproductslistcompanyid")] Hproductslist hproductslist)
        {
            if (ModelState.IsValid)
            {
                db.Hproductslists.Add(hproductslist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hproductslist);
        }

        // GET: Hproductslists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hproductslist hproductslist = db.Hproductslists.Find(id);
            if (hproductslist == null)
            {
                return HttpNotFound();
            }
            return View(hproductslist);
        }

        // POST: Hproductslists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HproductslistID,HproductslistNAME,HproductslistDESC,Hproductslistcompanyid")] Hproductslist hproductslist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hproductslist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hproductslist);
        }

        // GET: Hproductslists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hproductslist hproductslist = db.Hproductslists.Find(id);
            if (hproductslist == null)
            {
                return HttpNotFound();
            }
            return View(hproductslist);
        }

        // POST: Hproductslists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hproductslist hproductslist = db.Hproductslists.Find(id);
            db.Hproductslists.Remove(hproductslist);
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
