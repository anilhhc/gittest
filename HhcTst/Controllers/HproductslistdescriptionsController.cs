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
    public class HproductslistdescriptionsController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: Hproductslistdescriptions
        public ActionResult Index()
        {
            return View(db.Hproductslistdescriptions.ToList());
        }

        // GET: Hproductslistdescriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hproductslistdescription hproductslistdescription = db.Hproductslistdescriptions.Find(id);
            if (hproductslistdescription == null)
            {
                return HttpNotFound();
            }
            return View(hproductslistdescription);
        }

        // GET: Hproductslistdescriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hproductslistdescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HproductslistdescriptionID,HproductslistdescriptionDESC,STATUS,Hproductslistcompanyid,hpdquantityperpack,hpdquantityperstrip,hpdratevalidform,hpdpricetoretailer,hpdmrp,hpdstandardrate,hpdpricetostockist,hpdbrandname,hdpcategoryname,hpddivisionname,hdpmanfacturename")] Hproductslistdescription hproductslistdescription)
        {
            if (ModelState.IsValid)
            {
                db.Hproductslistdescriptions.Add(hproductslistdescription);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hproductslistdescription);
        }

        // GET: Hproductslistdescriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hproductslistdescription hproductslistdescription = db.Hproductslistdescriptions.Find(id);
            if (hproductslistdescription == null)
            {
                return HttpNotFound();
            }
            return View(hproductslistdescription);
        }

        // POST: Hproductslistdescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HproductslistdescriptionID,HproductslistdescriptionDESC,STATUS,Hproductslistcompanyid,hpdquantityperpack,hpdquantityperstrip,hpdratevalidform,hpdpricetoretailer,hpdmrp,hpdstandardrate,hpdpricetostockist,hpdbrandname,hdpcategoryname,hpddivisionname,hdpmanfacturename")] Hproductslistdescription hproductslistdescription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hproductslistdescription).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hproductslistdescription);
        }

        // GET: Hproductslistdescriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hproductslistdescription hproductslistdescription = db.Hproductslistdescriptions.Find(id);
            if (hproductslistdescription == null)
            {
                return HttpNotFound();
            }
            return View(hproductslistdescription);
        }

        // POST: Hproductslistdescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hproductslistdescription hproductslistdescription = db.Hproductslistdescriptions.Find(id);
            db.Hproductslistdescriptions.Remove(hproductslistdescription);
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
