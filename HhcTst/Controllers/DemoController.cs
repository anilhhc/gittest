using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class DemoController : Controller
    {
        HhcDbEntities db = new HhcDbEntities();
        // GET: Demo
        public ActionResult Index()
        {
           // var v = db.Zones.ToList();
            return View(db.Zones.ToList());
        }
       
    }
}