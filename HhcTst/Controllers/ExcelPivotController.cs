using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Office.Interop.Excel;
namespace HhcTst.Controllers
{
    public class ExcelPivotController : Controller
    {
        // GET: ExcelPivot
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Upload() { return View(); }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {

            return View();
        }


    }
}