using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;
using Microsoft.Owin.Security.Infrastructure;

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

        // GET: Stockists/Create d
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stockists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stockist stockist)
        {
            if (ModelState.IsValid)
            {
                var v = from p in db.Stockists
                        where p.StockistName == stockist.StockistName && p.StockistId != stockist.StockistId
                        select p;
                if (v.Any())
               // if (db.Stockists.Where(u => u.StockistName == stockist.StockistName).Any())
                {
                    ModelState.AddModelError("StockistName", "Stockist Name already taken");
                    return View(stockist);
                    //   .Write("Name already exists");
                    //Do what do u need to do...
                }
                else
                {
                    var dt = DateTime.Now;
                    var d = dt.Date;
                    stockist.CreatedOn = d;
                    stockist.ACTIVE = "y";
                    db.Stockists.Add(stockist);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
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
            Hstockistdetail stockist = db.Hstockistdetails.Find(id);
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
        public ActionResult Edit(Hstockistdetail stockist)
        {
            if (ModelState.IsValid)
            {
                var v = from p in db.Hstockistdetails
                        where p.hsemailid == stockist.hsemailid && p.HstockistdetailsID != stockist.HstockistdetailsID
                        select p;
                if(v.Any())
               // if(db.spSkCountId(stockist.StockistName,stockist.StockistId.ToString()).Any())
               // if (db.Stockists.Where(u => u.StockistName == stockist.StockistName).Any())
                {
                    ModelState.AddModelError("StockistName", "Stockist Name already taken");
                    return View(stockist);
                }
                else
                {
                    db.Entry(stockist).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
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
            Hstockistdetail stockist = db.Hstockistdetails.Find(id);
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
            Hstockistdetail stockist = db.Hstockistdetails.Find(id);
            db.Hstockistdetails.Remove(stockist);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Active(int id)
        {
            Stockist stockist = db.Stockists.Find(id);
            if (stockist.ACTIVE == "n")
            {
                stockist.ACTIVE = "y";
                db.SaveChanges();
            }
            else
            {
                stockist.ACTIVE = "n";
                db.SaveChanges();
            }
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
