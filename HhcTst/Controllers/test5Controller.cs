using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class test5Controller : Controller
    {
        HhcDbEntities db = new HhcDbEntities();
        // GET: test5
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetPersons()
        {
            var result = db.Hstockistdetails.ToList();
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}