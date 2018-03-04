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
    public class test1Controller : Controller
    {

        HhcDbEntities db = new HhcDbEntities();
        // GET: test1
        public ActionResult UploadExcel()
        {
            var v1 = db.tbl_registration.ToList();
            foreach (var w in v1)
            {
                db.tbl_registration.Remove(w);
                db.SaveChanges();
            }

            TempData["a"] = "Hello aaa mvc";        
            var v = db.tbl_registration.ToList();
            return View(v);
        }
        public FileResult DownloadExcel()
        {
            string path = "/Doc/Users.xlsx";
            return File(path, "application/vnd.ms-excel", "Users.xlsx");
        }
        [HttpPost]
        public ActionResult UploadExcel(tbl_registration tbl_rgs, HttpPostedFileBase FileUpload)
        {
            var v1 = db.tbl_registration.ToList();
            foreach (var w in v1)
            {
                db.tbl_registration.Remove(w);
                db.SaveChanges();
            }
            
            IEnumerable<tbl_registration> dt = db.tbl_registration.ToList();
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
                    var artistAlbums = from a in excelFile.Worksheet<tbl_registration>(sheetName) select a;

                    foreach (var a in artistAlbums)
                    {
                          try
                            {
                              if(a.Name!=null&&a.Address!=null&&a.ContactNo!=null&&a.Email!=null&&a.Password!=null&&a.City!=null)
                              //  if (a.Name != "" && a.Address != "" && a.ContactNo != "" && a.Email != "" && a.Password != "" && a.City != "")
                                {
                                    

                                    tbl_registration TU = new tbl_registration();
                                    TU.Name = a.Name;
                                    TU.Address = a.Address;
                                    TU.ContactNo = a.ContactNo;
                                    TU.Email = a.Email;
                                    TU.Password = a.Password;
                                    TU.City = a.City;
                                    TU.CreatedOn = DateTime.Now;
                                    db.tbl_registration.Add(TU);

                                    db.SaveChanges();
                                    // IEnumerable<tbl_registration> v = ;
                                    // return View(db.tbl_registration.ToList());
                                     ViewBag.msg ="Uploaded successfully  " + filename;
                                }
                                else
                                {

                                    data.Add("<ul>");
                                    if (a.Name == "" || a.Name == null) data.Add("<li> name is required</li>");
                                    if (a.Address == "" || a.Address == null) data.Add("<li> Address is required</li>");
                                    if(a.ContactNo==""||a.ContactNo==null) data.Add("<li> ContactNo is required</li>");
                                    if (a.Email == "" || a.Email == null) data.Add("<li>ContactNo is required</li>");
                                    if(a.Password==""||a.Password==null) data.Add("<li>Password is required</li>");
                                    if (a.City == "" || a.City == null) data.Add("<li>City is required</li>");
                                    data.Add("</ul>");
                                    data.ToArray();
                                    ViewBag.msg1 = data;
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
                    //if ((System.IO.File.Exists(pathToExcelFile)))
                    //{
                    //    System.IO.File.Delete(pathToExcelFile);
                    //}
                    //ViewBag.sheetdelmsg = "sheet deleted succcessfully";
                    return View(db.tbl_registration.ToList());
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