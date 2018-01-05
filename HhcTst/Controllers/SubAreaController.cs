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
    public class SubAreaController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: subareaCITies
        public ActionResult Index()
        {
            return View(db.SubAreas.ToList());
        }

        // GET: subareaCITies/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SubArea subareaCITy = db.SubAreas.Find(id);
        //    if (subareaCITy == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(subareaCITy);
        //}

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
        public ActionResult Create([Bind(Include = "SubAreaID,SubArea1,CITYID,ACTIVE")] SubArea subarea)
        {
            if (ModelState.IsValid)
            {
                if (db.SubAreas.Where(u => u.SubArea1 == subarea.SubArea1).Where(u => u.SubAreaID != subarea.SubAreaID).Any())
                {
                    ModelState.AddModelError("ZoneName", "Zone Name already taken");
                    return View(subarea);
                }
                else
                {
                    var DT = DateTime.Now;
                    var d = DT.Date;
                    subarea.CreatedOn = d;
                    db.SubAreas.Add(subarea);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(subarea);
        }

        // GET: subareaCITies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubArea subareaCITy = db.SubAreas.Find(id);
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
        public ActionResult Edit([Bind(Include = "SubAreaID,SubArea1,CITYID,ACTIVE")] SubArea subarea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subarea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subarea);
        }

        //// GET: subareaCITies/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SubArea subareaCITy = db.SubAreas.Find(id);
        //    if (subareaCITy == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(subareaCITy);
        //}

        //// POST: subareaCITies/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    SubArea subareaCITy = db.SubAreas.Find(id);
        //    db.SubAreas.Remove(subareaCITy);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        public ActionResult Active(int id)
        {
            SubArea subarea = db.SubAreas.Find(id);
            if (subarea.ACTIVE == "n")
            {
                subarea.ACTIVE = "y";
                db.SaveChanges();
            }
            else
            {
                subarea.ACTIVE = "n";
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
