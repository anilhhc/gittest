using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;
namespace HhcTst.Controllers
{
    public class test4Controller : Controller
    {
        // GET: test4
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AjaxMethod(string type, int value)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            HhcDbEntities db = new HhcDbEntities();

            switch (type)
            {
                default:
                    foreach (var z in db.Zones)
                    {
                        items.Add(new SelectListItem { Text = z.ZoneName, Value = z.ZoneID.ToString() });
                    }
                    break;
                case "ZoneId":
                    var states = (from state in db.STATEs
                                  where state.Zone1.ZoneID == value
                                  select state).ToList();
                    foreach (var s in states)
                    {
                        items.Add(new SelectListItem { Text = s.STATENAME, Value = s.STATEID.ToString() });
                    }
                    break;
                case "STATEID":
                    var cities = (from city in db.CITies
                                  where city.STATEID == value
                                  select city).ToList();
                    foreach (var city in cities)
                    {
                        items.Add(new SelectListItem { Text = city.CITYNAME, Value = city.CITYID.ToString() });
                       
                    }
                    break;
            }
            return Json(items);
        }
    }
}