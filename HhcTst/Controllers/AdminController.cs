using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;
using System.Data.OleDb;
using System.Data;
using LinqToExcel;
using System.Data.Entity.Validation;

namespace HhcTst.Controllers
{
    public class AdminController : Controller
    {
        HhcDbEntities1 db = new HhcDbEntities1();

        public ActionResult Zones()
        {
            return View(db.COUNTRies.ToList());
        }


        public FileResult DownloadExcel()
        {
            string path = "/Doc/Users.xlsx";
            return File(path, "application/vnd.ms-excel", "Users.xlsx");
        }


        [HttpPost]
        public JsonResult UploadExcel(hhcAdminLogin users, HttpPostedFileBase FileUpload)
        {

            List<string> data = new List<string>();
            if (FileUpload != null)
            {
                // tdata.ExecuteCommand("truncate table OtherCompanyAssets");  
                if (FileUpload.ContentType == "application/vnd.ms-excel" || FileUpload.ContentType == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                {
                    string filename = FileUpload.FileName;
                    string targetpath = Server.MapPath("~/Doc/");
                    FileUpload.SaveAs(targetpath + filename);
                    string pathToExcelFile = targetpath + filename;
                    var connectionString = "";
                    if (filename.EndsWith(".xls"))
                    {
                        connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", pathToExcelFile);
                    }
                    else if (filename.EndsWith(".xlsx"))
                    {
                        connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", pathToExcelFile);
                    }

                    var adapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString);
                    var ds = new DataSet();

                    adapter.Fill(ds, "ExcelTable");

                    DataTable dtable = ds.Tables["ExcelTable"];

                    string sheetName = "Sheet1";

                    var excelFile = new ExcelQueryFactory(pathToExcelFile);
                    var SecondarySl = from a in excelFile.Worksheet<secondarysale>(sheetName) select a;

                    foreach (var a in SecondarySl)
                    {
                        try
                        {
                            if (a.month != "" && a.year != "" && a.heteroproductid != "")
                            {
                                secondarysale TU = new secondarysale();
                                TU.heteroproductid = a.heteroproductid;
                                TU.month = a.month;
                                TU.year = a.year;
                                db.secondarysales.Add(TU);

                                db.SaveChanges();



                            }
                            else
                            {
                                data.Add("<ul>");
                                if (a.heteroproductid == "" || a.heteroproductid == null) data.Add("<li> name is required</li>");
                                if (a.month == "" || a.month == null) data.Add("<li> Address is required</li>");
                                if (a.year == "" || a.year == null) data.Add("<li>ContactNo is required</li>");

                                data.Add("</ul>");
                                data.ToArray();
                                return Json(data, JsonRequestBehavior.AllowGet);
                            }
                        }

                        catch (DbEntityValidationException ex)
                        {
                            foreach (var entityValidationErrors in ex.EntityValidationErrors)
                            {

                                foreach (var validationError in entityValidationErrors.ValidationErrors)
                                {

                                    Response.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);

                                }

                            }
                        }
                    }
                    //deleting excel file from folder  
                    if ((System.IO.File.Exists(pathToExcelFile)))
                    {
                        System.IO.File.Delete(pathToExcelFile);
                    }
                    return Json("success", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    //alert message for invalid file format  
                    data.Add("<ul>");
                    data.Add("<li>Only Excel file format is allowed</li>");
                    data.Add("</ul>");
                    data.ToArray();
                    return Json(data, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                data.Add("<ul>");
                if (FileUpload == null) data.Add("<li>Please choose Excel file</li>");
                data.Add("</ul>");
                data.ToArray();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
        // GET: Admin
        //[Authorize(Roles="Admin")]
        public ActionResult GetAdmins()
        {
            if (Session["loggedAdminName"] != null)
            {
                var v = db.hhcAdminLogins.ToList();
                return View(v);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginVm vm)
        {
            if (ModelState.IsValid)
            {
                var tbRes = new hhcAdminLogin()
                {
                    UserName = vm.UserName,
                    UserPwd = vm.UserPwd
                };
                using (HhcDbEntities1 db = new HhcDbEntities1())
                {
                    var v = db.hhcAdminLogins.Where(a => a.UserName.Equals(tbRes.UserName) && a.UserPwd.Equals(tbRes.UserPwd)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["loggedAdminName"] = v.UserName.ToString();
                        return RedirectToAction("AdminDashBoard", "Admin");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login credentials.");
                    }
                }
            }
            return View();
        }
        public ActionResult AdminDashBoard()
        {
            if (Session["loggedAdminName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        }
    }
}