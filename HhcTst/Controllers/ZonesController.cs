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
    public class ZonesController : Controller
    {
        //test
        ZonesTableAdapter dz = new ZonesTableAdapter();
        private HhcDbEntities db = new HhcDbEntities();

        // GET: Zones
        public ActionResult Index()
        {
            TempData["a"] = "Hello mvc!";
           //// if (db.Zones.Where(u => u.ACTIVE == "y").Any()) 
           // {

           //  //  return View(db.Zones.ToList());
           // }
            //return View(db.Zones.Where(u=>u.ACTIVE=="y").ToList());
            return View(db.Zones.ToList());
        }

        // GET: Zones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zone zone = db.Zones.Find(id);
            if (zone == null)
            {
                return HttpNotFound();
            }
            return View(zone);
        }

        // GET: Zones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZoneID,ZoneName,ACTIVE")] Zone zone)
        {
            if (ModelState.IsValid)
            {
                //var v = from p in db.Zones
                //        where p.ZoneName == zone.ZoneName && p.ZoneID != zone.ZoneID
                //        select p;
                //if (v.Any())
               if (db.Zones.Where(u => u.ZoneName == zone.ZoneName).Where(u=>u.ZoneID!=zone.ZoneID).Any())
                {
                    ModelState.AddModelError("ZoneName", "Zone Name already taken");
                    return View(zone);
                }
                else
                {
                    var dateandtime = DateTime.Now;
                    var date = dateandtime.Date;
                    zone.CreatedOn = date;
                    zone.ACTIVE = "y";
                    db.Zones.Add(zone);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(zone);
        }

        // GET: Zones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zone zone = db.Zones.Find(id);
            if (zone == null)
            {
                return HttpNotFound();
            }
            return View(zone);
        }

        // POST: Zones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZoneID,ZoneName,ACTIVE")] Zone zone)
        {
            if (ModelState.IsValid)
            {
                //var v = from p in db.Zones
                //        where p.ZoneName == zone.ZoneName && p.ZoneID != zone.ZoneID
                //        select p;
                //if (v.Any())


               // if (dz.getothercount(zone.ZoneName, zone.ZoneID) > 0)
                if (db.Zones.Where(u => u.ZoneName == zone.ZoneName).Where(u => u.ZoneID != zone.ZoneID).Any())
              //   if (db.Zones.Where(u => u.ZoneName == zone.ZoneName).Any())
                {
                    ModelState.AddModelError("ZoneName", "Zone Name already taken");
                    return View(zone);
                }
                else
                {
                    db.Entry(zone).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(zone);
        }

        // GET: Zones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zone zone = db.Zones.Find(id);
            if (zone == null)
            {
                return HttpNotFound();
            }
            return View(zone);
        }

        // POST: Zones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zone zone = db.Zones.Find(id);
            db.Zones.Remove(zone);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Active(int id)
        {
            Zone zone = db.Zones.Find(id);
            if(zone.ACTIVE=="n")
            {
                zone.ACTIVE = "y";
                db.SaveChanges();
            }
            else
            {
                zone.ACTIVE = "n";
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
