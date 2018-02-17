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
    public class PSalesController : Controller
    {
        // GET: PSales
        public ActionResult Index()
        {
            return View();
        }
        HhcmkdbEntities db = new HhcmkdbEntities();
        // GET: test1

        public ActionResult UploadExcel()
        {
            var v1 = db.hhcprimarysales.ToList();
            foreach (var w in v1)
            {
                db.hhcprimarysales.Remove(w);
                db.SaveChanges();
            }

            TempData["a"] = "Hello aaa mvc";
            var v = db.hhcprimarysales.ToList();
            return View(v);
        }
        public FileResult DownloadExcel()
        {
            string path = "/Doc/Users.xlsx";
            return File(path, "application/vnd.ms-excel", "Users.xlsx");
        }
        [HttpPost]
        public ActionResult UploadExcel(hhcprimarysale hhcPs, HttpPostedFileBase FileUpload)
        {
            var v1 = db.hhcprimarysales.ToList();
            foreach (var w in v1)
            {
                db.hhcprimarysales.Remove(w);
                db.SaveChanges();
            }

            IEnumerable<hhcprimarysale> dt = db.hhcprimarysales.ToList();
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
                    var artistAlbums = from a in excelFile.Worksheet<hhcprimarysale>(sheetName) select a;

                    foreach (var a in artistAlbums)
                    {
                        try
                        {
                            if (a.billingdocument != "" && a.billingdate != "" && a.stockistcode != "" && a.productid != "" && a.sapproductquantity!= "" && a.rate!= "" &&a.value!="")
                            {


                                hhcprimarysale Ps = new hhcprimarysale();
                                Ps.billingdocument = a.billingdocument;
                                Ps.billingdate = a.billingdate;
                                Ps.stockistcode = a.stockistcode;
                                Ps.productid = a.productid;
                                Ps.sapproductquantity = a.sapproductquantity;
                                Ps.rate = a.rate;
                                Ps.value = a.value;
                              //  Ps.CreatedOn = DateTime.Now;
                                db.hhcprimarysales.Add(Ps);

                                db.SaveChanges();
                                // IEnumerable<tbl_registration> v = ;
                                // return View(db.tbl_registration.ToList());
                                // ViewBag.msg ="Uploaded successfully";
                            }
                            else
                            {

                                data.Add("<ul>");
                                if (a.billingdocument == "" || a.billingdocument == null) data.Add("<li> billingdoc is required</li>");
                                if (a.billingdate == "" || a.billingdate == null) data.Add("<li> billingdate is required</li>");
                                if (a.stockistcode == "" || a.stockistcode == null) data.Add("<li>stockistcode is required</li>");

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
                    return View(db.hhcprimarysales.ToList());
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