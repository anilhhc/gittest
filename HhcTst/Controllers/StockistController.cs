using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using HhcTst.Models;
using System.Net;
using System.Data.Entity;
using System.Data;
using System.Data.OleDb;
using LinqToExcel;
using System.Data.Entity.Validation;
using OfficeOpenXml;

namespace HhcTst.Controllers
{
    public class StockistController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();
        // GET: Stockist
        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hstockistdetail stockist=db.Hstockistdetails.Find(id);
            if(stockist==null)
            {
                return HttpNotFound();

            }
            return View(stockist);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StockistID,StockistName,ACTIVE")] Hstockistdetail stockist)
        {
            if (ModelState.IsValid)
            {
               // var count = db.Stockists.Count(t=>t.StockistName==stockist.StockistName)//.Where(o => o.StockistName == stockist.StockistName).SelectMany(o=>o.StockistName).Count();
               // if(db.Stockists.Count<>)
                 if (db.Hstockistdetails.Where(u => u.HstockistdetailsID == stockist.HstockistdetailsID).Any())
                {
                    ModelState.AddModelError("ZoneName", "Zone Name already taken");
                    return View(stockist);
                }
                else
                {
                    db.Entry(stockist).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }


            return View(stockist);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(StockistLoginVM vm)
        {
            if (ModelState.IsValid)
            {
                var tbRes = new Hstockistdetail()
                {
                    hsemailid = vm.StockistName,
                   hspwd = vm.Password
                };
                using (HhcDbEntities db = new HhcDbEntities())
                {
                    var v = db.Hstockistdetails.Where(a => a.hsemailid.Equals(tbRes.hsemailid) && a.hspwd.Equals(tbRes.hspwd)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["loggedStockistName"] = v.hsemailid.ToString();
                        return RedirectToAction("StockistDashBoard", "Stockist");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login credentials.");
                    }
                }
            }
            return View();
        }
        public ActionResult StockistDashBoard()
        {
            if (Session["loggedStockistName"] != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult ProfilePage()
        {
            string str = Session["loggedStockistName"].ToString();
            var v = db.Hstockistdetails.Where(a=>a.hsemailid == str).FirstOrDefault();

            return View(v);
        }
        public ActionResult UploadFileView()
        {
            return View();
        }
        public JsonResult UploadFile()
        {
            if (Request.Files.Count > 0)
            {
                try
                {
                    object[,] obj = null;
                    int noOfCol = 0;
                    int noOfRow = 0;
                    HttpFileCollectionBase file = Request.Files;
                    if ((file != null) && (file.Count > 0))
                    {
                        //string fileName = file.FileName;
                        //string fileContentType = file.ContentType;
                        byte[] fileBytes = new byte[Request.ContentLength];
                        var data = Request.InputStream.Read(fileBytes, 0, Convert.ToInt32(Request.ContentLength));
                        // var usersList = new List<Users>();
                        //using (var package = new ExcelPackage())
                        using (var package = new ExcelPackage(Request.InputStream))
                        {
                            var currentSheet = package.Workbook.Worksheets;
                            var workSheet = currentSheet.First();
                            noOfCol = workSheet.Dimension.End.Column;
                            noOfRow = workSheet.Dimension.End.Row;
                            obj = new object[noOfRow, noOfCol];
                            obj = (object[,])workSheet.Cells.Value;
                        }
                    }
                    return Json(new { data = obj, row = noOfRow, col = noOfCol }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {

                }

            }
            return Json("", JsonRequestBehavior.AllowGet);
        }
        public ActionResult Register()
        {
            return View();
        }

        // POST: Stockists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "StockistId,StockistName,Description,Password")] Hstockistdetail stockist)
        {
            if (ModelState.IsValid)
            {
                if (db.Hstockistdetails.Where(u => u.hsemailid == stockist.hsemailid).Any())
                {
                    ModelState.AddModelError("StockistName", "Stockist Name already taken");
                    return View(stockist);
                    //   .Write("Name already exists");
                    //Do what do u need to do...
                }
                else
                {
                    db.Hstockistdetails.Add(stockist);
                    db.SaveChanges();
                    ViewBag.name =( stockist.hsemailid.ToString()+" has been registered successfully");
                    ModelState.Clear();
                    return View();
                  //  return RedirectToAction("Login"); // RedirectToAction("Index");
                }
            }

            return View(stockist);
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Stockist");
        }
    }
}