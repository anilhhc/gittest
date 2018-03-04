using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;
using HhcTst.xsds.datacareTableAdapters;
using DocumentFormat.OpenXml.InkML;

namespace HhcTst.Controllers
{
    public class test3Controller : Controller
    {
        HhcDbEntities db = new HhcDbEntities();
        // GET: test3
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile,hstockistupload upldfile)
        {
            var v = new UploadedFilesTableAdapter();
            if (postedFile != null)
            {
                string path = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string str= path + "1-Hhc-" + Path.GetFileName(postedFile.FileName);
                postedFile.SaveAs(str);
                upldfile.filepath = postedFile.FileName;
                var dateandtime = DateTime.Now;
                var date = dateandtime.Date;
                upldfile.filedescription = "1-" + date;
                upldfile.filepath=str;
                upldfile.fileuploaddate = date;
                //upldfile.States = "state" + db.UploadedFiles.Select(x=>x.Id);
                db.hstockistuploads.Add(upldfile);
                db.SaveChanges();
                //v.Insert(upldfile);
                ViewBag.msg = "file uploaded successfully";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index1(List<HttpPostedFileBase> postedFiles)
        {
            string path = Server.MapPath("~/Uploads1/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            foreach (HttpPostedFileBase postedFile in postedFiles)
            {
                if (postedFile != null)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    postedFile.SaveAs(path + fileName);
                    ViewBag.msg1 += string.Format("<b>{0}</b> Uploaded.<br/>", fileName);
                }
            }
            return View();
        }


        [HttpGet]
        public ActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index2(List<HttpPostedFileBase> fileData )
        {
            string path = Server.MapPath("~/Uploads2");
            foreach (HttpPostedFileBase postedFile in fileData)
            {
                if (postedFile != null)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    postedFile.SaveAs(path + fileName);
                }
            }

            return View();
        }

        public ActionResult Index3()
        {
            return View(from c in db.hstockistuploads.Take(10)
                            select c);
        }
    }
}