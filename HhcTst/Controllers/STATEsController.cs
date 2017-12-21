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
    public class STATEsController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: STATEs
        public ActionResult Index()
        {

                var fromDatabaseEF = new SelectList(db.Zones.ToList(), "ZoneID", "ZoneName");
                ViewBag.Zones=fromDatabaseEF;
           // var v=from d in db.STATEs
              //    Where 
                return View(db.STATEs.ToList());
        }

        // GET: STATEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STATE sTATE = db.STATEs.Find(id);
            if (sTATE == null)
            {
                return HttpNotFound();
            }
            return View(sTATE);
        }

        // GET: STATEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: STATEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STATEID,STATENAME,COUNTRYID,ACTIVE")] STATE sTATE)
        {
            if (ModelState.IsValid)
            {
                db.STATEs.Add(sTATE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sTATE);
        }

        // GET: STATEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STATE sTATE = db.STATEs.Find(id);
            if (sTATE == null)
            {
                return HttpNotFound();
            }
            return View(sTATE);
        }

        // POST: STATEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STATEID,STATENAME,COUNTRYID,ACTIVE")] STATE sTATE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sTATE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sTATE);
        }

        // GET: STATEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STATE sTATE = db.STATEs.Find(id);
            if (sTATE == null)
            {
                return HttpNotFound();
            }
            return View(sTATE);
        }

        // POST: STATEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            STATE sTATE = db.STATEs.Find(id);
            db.STATEs.Remove(sTATE);
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
