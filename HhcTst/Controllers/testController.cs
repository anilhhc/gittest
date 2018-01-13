using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class testController : Controller
    {
        HhcDbEntities db = new HhcDbEntities();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HhcDbConnectionString"].ConnectionString);
        OleDbConnection Econ;

        private void ExcelConn(string filepath)
        {

            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", filepath);

            Econ = new OleDbConnection(constr);



        }
        private void InsertExceldata(string fileepath, string filename)
        {

            string fullpath = Server.MapPath("/excelfolder/") + filename;

            ExcelConn(fullpath);

            string query = string.Format("Select * from [{0}]", "Sheet1$");

            OleDbCommand Ecom = new OleDbCommand(query, Econ);

            Econ.Open();



            DataSet ds = new DataSet();

            OleDbDataAdapter oda = new OleDbDataAdapter(query, Econ);

            Econ.Close();

            oda.Fill(ds);



            DataTable dt = ds.Tables[0];



            SqlBulkCopy objbulk = new SqlBulkCopy(con);

            objbulk.DestinationTableName = "tbl_registration";

            objbulk.ColumnMappings.Add("Email", "Email");

            objbulk.ColumnMappings.Add("Password", "Password");

            objbulk.ColumnMappings.Add("Name", "Name");

            objbulk.ColumnMappings.Add("Address", "Address");

            objbulk.ColumnMappings.Add("City", "City");

            con.Open();

            objbulk.WriteToServer(dt);


            
            con.Close();
            
        }
        // GET: test
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {

            string filename = Guid.NewGuid() + Path.GetExtension(file.FileName);

            string filepath = "/excelfolder/" + filename;

            file.SaveAs(Path.Combine(Server.MapPath("/excelfolder"), filename));

            InsertExceldata(filepath, filename);
            //var v=
            //var v = ViewBag.exdb;
           // var v = db.tbl_registration.ToList();
            return View();
            

        }
     
  


    }
}