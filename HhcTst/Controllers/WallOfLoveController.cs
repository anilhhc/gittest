using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class WallOfLoveController : Controller
    {
        mkdbEntities db1 = new mkdbEntities();
        HhcDbEntities db = new HhcDbEntities();
        // GET: WallOfLove
        //[ ActionName("Something")]
        public ActionResult Index()
        {
            return View(db.hhcAdminLogins.ToList());
        }
        //[ActionName("Wall-Of-Love")]
        public ActionResult WallOfLove1(foursolarwalloflove fswl)
        {
            fswl.tittle = "regular-title";
            var v = db1.foursolarwallofloves.Where(n => n.tittle == fswl.tittle).ToList();
            return View(v);
        }
    }
}