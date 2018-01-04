using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HhcTst.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Upload selected Excel files.
        /// </summary>
        public ActionResult Submit(IEnumerable<HttpPostedFileBase> files)
        {
            if (files != null)
            {
                string fileName;
                string filepath;
                string fileExtension;

                foreach (var f in files)
                {
                    //Set file details.
                    SetFileDetails(f, out fileName, out filepath, out fileExtension);

                    if (fileExtension == Constants.xls || fileExtension == Constants.xlsx)
                    {
                        //Save the uploaded file to the application folder.
                        //string savedExcelFiles = Constants.UploadedFolder + fileName;
                        f.SaveAs(Server.MapPath(savedExcelFiles));

                        //Read Data From ExcelFiles.
                        ReadDataFromExcelFiles(savedExcelFiles);
                    }
                    else
                    {
                        //TODO: Send Alert to the users file not supported.
                    }
                }
            }
            return RedirectToAction("Index", "Connect");
        }


        /// <summary>
        /// This method is used to get the file details and set.
        /// </summary>
        private static void SetFileDetails(HttpPostedFileBase f, out string fileName, out string filepath, out string fileExtension)
        {
            fileName = Path.GetFileName(f.FileName);
            fileExtension = Path.GetExtension(f.FileName);
            filepath = Path.GetFullPath(f.FileName);
        }


        /// <summary>
        /// This method is used to get the data source and read the data from files.
        /// </summary>
        private void ReadDataFromExcelFiles(string savedExcelFiles)
        {
            //Create a connection string to access the data of Excel file by the help of Microsoft ACE OLEDB providers.
            var connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;", Server.MapPath(savedExcelFiles));

            //Fill the DataSet by the Sheets.
            var adapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString);
            var ds = new DataSet();
            List<UploadExcel> uploadExl = new List<UploadExcel>();

            adapter.Fill(ds, "Subscriber");
            DataTable data = ds.Tables["Subscriber"];

            GetSetUploadExcelData(uploadExl, data);
        }


        private static void GetSetUploadExcelData(List<UploadExcel> uploadExl, DataTable data)
        {
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                UploadExcel NewUpload = new UploadExcel();
                NewUpload.ID = Convert.ToInt16(data.Rows[i]["ID"]);
                NewUpload.CostCenter = Convert.ToString(data.Rows[i]["CostCenter"]);
                NewUpload.FirstName = Convert.ToString(data.Rows[i]["FirstName"]);
                NewUpload.LastName = Convert.ToString(data.Rows[i]["LastName"]);

                NewUpload.MobileNo = Convert.ToString(data.Rows[i]["MobileNo"]);
                NewUpload.EmailID = Convert.ToString(data.Rows[i]["EmailID"]);
                NewUpload.Services = Convert.ToString(data.Rows[i]["Services"]);

                NewUpload.UsageType = Convert.ToString(data.Rows[i]["UsageType"]);
                NewUpload.Network = Convert.ToString(data.Rows[i]["Network"]);
                NewUpload.UsageIncluded = Convert.ToInt16(data.Rows[i]["UsageIncluded"]);
                NewUpload.Unit = Convert.ToString(data.Rows[i]["Unit"]);

                uploadExl.Add(NewUpload);
            }
        }
    }
}