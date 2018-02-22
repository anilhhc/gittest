using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcMkTst.Models;
using System.Data.OleDb;
using System.Data;
using LinqToExcel;
using System.Data.Entity.Validation;
namespace HhcMkTst.Controllers
{
    public class SSalesController : Controller
    {
        HhcmkdbEntities db = new HhcmkdbEntities();
        // GET: test1

        public ActionResult UploadExcel()
        {
            var v1 = db.hhcsecondarysales.ToList();
            foreach (var w in v1)
            {
                db.hhcsecondarysales.Remove(w);
                db.SaveChanges();
            }

            TempData["a"] = "Hello aaa mvc";
            var v = db.hhcsecondarysales.ToList();
            return View(v);
        }
        public FileResult DownloadExcel()
        {
            string path = "/Doc/Users.xlsx";
            return File(path, "application/vnd.ms-excel", "Users.xlsx");
        }
        [HttpPost]
        public ActionResult UploadExcel(hhcsecondarysale hhcSs, HttpPostedFileBase FileUpload)
        {
            var v1 = db.hhcsecondarysales.ToList();
            foreach (var w in v1)
            {
                db.hhcsecondarysales.Remove(w);
                db.SaveChanges();
            }

            IEnumerable<hhcsecondarysale> dt = db.hhcsecondarysales.ToList();
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
                    var artistAlbums = from a in excelFile.Worksheet<hhcsecondarysale>(sheetName) select a;

                    foreach (var a in artistAlbums)
                    {
                        try
                        {
                            if ((a.stockistid != null) && (a.month != null) && 
                                (a.year != null) && (a.sapmaterialcode != null) && (a.stockistproductname != null) &&
                                (a.package != null) && (a.openingstock != null)&&(a.purshcasequantity!=null)&&(a.salequantity!=null)&&
                                (a.salereturn != null) && (a.purchasereturn != null) && (a.closing != null))
                            {
                                hhcsecondarysale Ss = new hhcsecondarysale();
                                Ss.stockistid = a.stockistid;Ss.month = a.month;Ss.year = a.year;
                                Ss.sapmaterialcode = a.sapmaterialcode;Ss.stockistproductname = a.stockistproductname;
                                Ss.package = a.package; Ss.openingstock = a.openingstock; Ss.purshcasequantity = a.purshcasequantity;
                                Ss.salequantity = a.salequantity; Ss.salereturn = a.salereturn; Ss.purchasereturn = a.purchasereturn;
                                Ss.closing = a.closing;
                               // Ss.CreatedOn = DateTime.Now;
                                db.hhcsecondarysales.Add(Ss);
                                db.SaveChanges();
                                // IEnumerable<tbl_registration> v = ;
                                // return View(db.tbl_registration.ToList());
                                // ViewBag.msg ="Uploaded successfully";
                            }
                            else
                            {                
                                data.Add("<ul>");
                                if (a.stockistid == "" || a.stockistid == null) data.Add("<li> stockistid is required</li>");
                                if (a.month == "" || a.month == null) data.Add("<li>month is required</li>");
                                if (a.year == "" || a.year == null) data.Add("<li>year is required</li>");
                                if (a.sapmaterialcode == "" || a.sapmaterialcode == null) data.Add("<li>sap material code is required");
                                if (a.stockistproductname == "" || a.stockistproductname == null) data.Add("<li>stockistProductName is required</li>");
                                if (a.package == "" || a.package == null) data.Add("<li> package is required</li>");
                                if (!a.openingstock.HasValue  || a.openingstock == null) data.Add("<li> openingstock is required</li>");
                                if (!a.purshcasequantity.HasValue|| a.purshcasequantity == null) data.Add("<li> purchase quantity is required</li>");
                                if (!a.salequantity.HasValue || a.package == null) data.Add("<li> saleQuantity is required</li>");
                                if (!a.purchasereturn.HasValue || a.purchasereturn == null) data.Add("<li> purchase return is required</li>");
                                if (!a.salereturn.HasValue || a.salereturn == null) data.Add("<li> sale return is required</li>");
                                if (!a.closing.HasValue || a.closing == null) data.Add("<li> closing is required</li>");
                               // if (a.filepath=="" || a.filepath == null) data.Add("<li> filepath is required</li>");
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
                    ViewBag.sheetdelmsg = "sheet deleted succcessfully";
                    return View(db.hhcsecondarysales.ToList());
                }
                else
                {
                    //alert message for invalid file format  
                    data.Add("<ul>");
                    data.Add("<li>Only Excel file format is allowed</li>");
                    data.Add("</ul>");
                    data.ToArray();
                    ViewBag.formatexception = "Only excel format please";
                    return View();
                }
            }
            else
            {
                data.Add("<ul>");
                if (FileUpload == null) data.Add("<li>Please choose Excel file</li>");
                data.Add("</ul>");
                data.ToArray();
                ViewBag.unknownformatexception = "Plese choose excel file";
                return View();
            }
        }
    }
}