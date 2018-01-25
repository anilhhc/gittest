using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;
using Newtonsoft.Json;

namespace HhcTst.Controllers
{
    public class test7ZonesController : Controller
    {
        HhcDbEntities db = new HhcDbEntities();
        // GET: test7Zones
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetZones()
        {
          //  CustomersEntities entities = new CustomersEntities();
            var v = db.Zones.ToList();
            return Json(v,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertZones(Zone zone)
        {
                db.Zones.Add(zone);
                db.SaveChanges();
            return Json(zone);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Zone zone)
        {
           
                Zone updatedZone = (from c in db.Zones
                                            where c.ZoneID == zone.ZoneID
                                            select c).FirstOrDefault();
                updatedZone.ZoneName = zone.ZoneName;
                db.SaveChanges();
            

            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult DeleteCustomer(int ZoneID)
        {
            
                Zone zone = (from c in db.Zones
                                     where c.ZoneID == ZoneID
                                     select c).FirstOrDefault();
                db.Zones.Remove(zone);
                db.SaveChanges();
            
            return new EmptyResult();
        }
    }
}