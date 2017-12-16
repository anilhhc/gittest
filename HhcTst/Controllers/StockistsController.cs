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
    public class StockistsController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: Stockists
        public ActionResult Index()
        {
                return View(db.Stockists.ToList());
        }

        // GET: Stockists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stockist stockist = db.Stockists.Find(id);
            if (stockist == null)
            {
                return HttpNotFound();
            }
            return View(stockist);
        }

        // GET: Stockists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stockists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StockistId,StockistName,Description,Password")] Stockist stockist)
        {
            if (ModelState.IsValid)
            {
                db.Stockists.Add(stockist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stockist);
        }

        // GET: Stockists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stockist stockist = db.Stockists.Find(id);
            if (stockist == null)
            {
                return HttpNotFound();
            }
            return View(stockist);
        }

        // POST: Stockists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StockistId,StockistName,Description,Password")] Stockist stockist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stockist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stockist);
        }

        // GET: Stockists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stockist stockist = db.Stockists.Find(id);
            if (stockist == null)
            {
                return HttpNotFound();
            }
            return View(stockist);
        }

        // POST: Stockists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stockist stockist = db.Stockists.Find(id);
            db.Stockists.Remove(stockist);
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
