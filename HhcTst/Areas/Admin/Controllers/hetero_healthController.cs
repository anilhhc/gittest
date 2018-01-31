using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Areas.Admin.Models;

namespace HhcTst.Areas.Admin.Controllers
{
    public class hetero_healthController : Controller
    {
       // HhcDbEntities db = new HhcDbEntities();
        AdminDbEntities db=new AdminDbEntities();
        // GET: Admin/hetero_health
        public ActionResult Index()
        {
            var v = db.hhcsecondarysales.ToList();
            return View(v);
        }
    }
}