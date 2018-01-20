﻿using System;
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
        
        public JsonResult GetZones()
        {
            List<Zone> allZones = new List<Zone>();

            allZones = db.Zones.ToList();
            return new JsonResult{Data=allZones,JsonRequestBehavior=JsonRequestBehavior.AllowGet};
        }
        //fetch states by zone id
        [HttpPost]
        public JsonResult GetStates(int ZoneID)
        {
            List<STATE> allStates = new List<STATE>();

            allStates= db.STATEs.Where(m => m.Zone == ZoneID).ToList();

            return new JsonResult { Data = allStates, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult Part5()
        {
            return View();
        }
        // GET: STATEs
        //public ActionResult Test()
        //{
        //    List<SelectListItem> zoneNames = new List<SelectListItem>();
        //    List<SelectListItem> stateNames = new List<SelectListItem>();
        //    List<SelectListItem> cityNames = new List<SelectListItem>();
        //    CascadingTestModel cstModel = new CascadingTestModel();
        //    List<Zone> zones = db.Zones.ToList();
        //    List<STATE> states = db.STATEs.ToList();
        //    List<CITy> cities = db.CITies.ToList();
        //    zones.ForEach(x =>
        //    {
        //        zoneNames.Add(new SelectListItem { Text = x.ZoneName, Value = x.ZoneID.ToString() });
        //    });
        //    states.ForEach(x =>
        //    {
        //        stateNames.Add(new SelectListItem { Text = x.STATENAME, Value = x.STATEID.ToString()});
        //    });
        //    cities.ForEach(x =>
        //    {
        //        cityNames.Add(new SelectListItem { Text = x.CITYNAME, Value = x.CITYID.ToString() });
        //    });
        //    cstModel.StateNames = stateNames;
        //    cstModel.ZoneNames=zoneNames;
        //    return View(cstModel);
        //}
        //[HttpPost]
        //public ActionResult GetStates(string zoneId)
        //{
        //    int statId;
        //    List<SelectListItem> stateNames = new List<SelectListItem>();
        //    if (!string.IsNullOrEmpty(zoneId))
        //    {
        //        statId = Convert.ToInt32(zoneId);
        //        List<STATE> states = db.STATEs.Where(x => x.Zone1.ZoneID == statId).ToList();
        //        states.ForEach(x =>
        //        {
        //            stateNames.Add(new SelectListItem { Text = x.STATENAME, Value = x.STATEID.ToString() });
        //        });
        //    }
        //    return Json(stateNames, JsonRequestBehavior.AllowGet);
        //}  
        public ActionResult Index()
        {
            var fromDatabaseEF = new SelectList(db.Zones.ToList(), "ZoneID", "ZoneName");
            ViewBag.Zones = fromDatabaseEF;
            //  // var v=from d in db.STATEs
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
            var fromDatabaseEF = new SelectList(db.Zones.ToList(), "ZoneID", "ZoneName");
            ViewBag.Zones = fromDatabaseEF;
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
                if (db.STATEs.Where(u => u.STATENAME == sTATE.STATENAME).Where(u => u.STATEID != sTATE.STATEID).Any())
                {
                    ModelState.AddModelError("ZoneName", "Zone Name already taken");
                    return View(sTATE);
                }
                else
                {
                    var dateandtime = DateTime.Now;
                    var date = dateandtime.Date;
                    sTATE.CreatedOn = date;
                    db.STATEs.Add(sTATE);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
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
        public ActionResult Edit([Bind(Include = "STATEID,STATENAME,Zone,ACTIVE")] STATE sTATE)
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
        public ActionResult Active(int id)
        {
            STATE state = db.STATEs.Find(id);
            if (state.ACTIVE == "n")
            {
                state.ACTIVE = "y";
                db.SaveChanges();
            }
            else
            {
                state.ACTIVE = "n";
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
