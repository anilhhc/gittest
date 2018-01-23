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
            var v = db.Stockists.ToList();
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
        public JsonResult InsertStockists(Stockist stockist)
        {
            db.Stockists.Add(stockist);
            db.SaveChanges();
            return Json(stockist);
        }
        [HttpPost]
        public ActionResult UpdateStockists(Stockist stockist)
        {
            stockist = db.Stockists.Where(x => x.StockistId == stockist.StockistId).FirstOrDefault();
            db.Entry(stockist).State = EntityState.Modified;
            db.SaveChanges();
            return new EmptyResult();
        }
        [HttpPost]
        public ActionResult DeleteStockists(Stockist stockist)
        {
            stockist = db.Stockists.Where(x => x.StockistId == stockist.StockistId).FirstOrDefault();
            db.Stockists.Remove(stockist);
            db.SaveChanges();
            return new EmptyResult();
        }
    }
}