using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HhcTst.Models;
using Newtonsoft.Json;

namespace HhcTst.Controllers
{
    public class test6Controller : Controller
    {
        HhcDbEntities db = new HhcDbEntities();
        // GET: test6
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetStockists()
        {
            var v = db.Hstockistdetails.ToList();
            return Json(v, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult GetZones()
        {

            Zone zone = new Zone();
            string json = JsonConvert.SerializeObject(zone);
            //var v = db.Zones.AsEnumerable();
            return Json(json);
        }
        [HttpPost]
        public JsonResult InsertStockists(Hstockistdetail stockist)
        {
            db.Hstockistdetails.Add(stockist);
            db.SaveChanges();
            return Json(stockist);
        }
        [HttpPost]
        public ActionResult UpdateStockists(Hstockistdetail stockist)
        {
            stockist = db.Hstockistdetails.Where(x => x.HstockistdetailsID == stockist.HstockistdetailsID).FirstOrDefault();
            db.Entry(stockist).State = EntityState.Modified;
            db.SaveChanges();
            return new EmptyResult();
        }
        [HttpPost]
        public ActionResult DeleteStockists(Hstockistdetail stockist)
        {
            stockist = db.Hstockistdetails.Where(x => x.HstockistdetailsID == stockist.HstockistdetailsID).FirstOrDefault();
            db.Hstockistdetails.Remove(stockist);
            db.SaveChanges();
            return new EmptyResult();
        }
    }
}