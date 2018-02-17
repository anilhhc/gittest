using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;
using HhcTst.xsds.datacareTableAdapters;
namespace HhcTst.Controllers
{
    public class CITiesController : Controller
    {
      //  CITiesTableAdapter cta = new CITiesTableAdapter();   
        private HhcDbEntities db = new HhcDbEntities();

        // GET: CITies
        public ActionResult Index()
        {
            var v = db.CITies;
            return View(v);
        }

        // GET: CITies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             CITy cITy = db.CITies.Find(id);
            if (cITy == null)
            {
                return HttpNotFound();
            }
            return View(cITy);
        }

        // GET: CITies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CITies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CITYID,CITYNAME,STATEID,ACTIVE")] CITy cITy)
        {
            if (ModelState.IsValid)
            {
                if (db.CITies.Where(u => u.CITYNAME == cITy.CITYNAME).Where(u => u.CITYID != cITy.CITYID).Any())
                {
                    ModelState.AddModelError("ZoneName", "Zone Name already taken");
                    return View(cITy);
                }
                //if(db.CITies.Count(cITy.CITYID)>0)
               else
                {
                   var dateandtime=DateTime.Now;
                   var date=dateandtime.Date;
                   cITy.CreatedOn = date;
                   //cITy.ACTIVE = "y";
                    db.CITies.Add(cITy);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }

            return View(cITy);
        }

        // GET: CITies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CITy cITy = db.CITies.Find(id);
            if (cITy == null)
            {
                return HttpNotFound();
            }
            return View(cITy);
        }

        // POST: CITies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CITYID,CITYNAME,STATEID,ACTIVE")] CITy cITy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cITy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cITy);
        }

        // GET: CITies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CITy cITy = db.CITies.Find(id);
            if (cITy == null)
            {
                return HttpNotFound();
            }
            return View(cITy);
        }

        // POST: CITies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CITy cITy = db.CITies.Find(id);
            db.CITies.Remove(cITy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Active(int id)
        {
            CITy city = db.CITies.Find(id);
            if (city.ACTIVE == "n")
            {
                city.ACTIVE = "y";
                db.SaveChanges();
            }
            else
            {
                city.ACTIVE = "n";
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
