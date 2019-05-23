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
        private void GeData()
        {
            string connection = @"OLEDB;Provider=SQLOLEDB.1;Integrated Security=SSPI;Server=192.168.0.1\SQL2005;DataBase=Test;UID=sa;PWD=pass@123";
            string command = "SELECT Column1,Column2,Column3,Column4,cast((Column5*1.00)/Column4 AS DECIMAL(16,2)) as Column5  FROM  PivotData";
            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook workbook = (Microsoft.Office.Interop.Excel.Workbook)app.Workbooks.Add(Type.Missing);
            Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            Excel.PivotCache pivotCache = app.ActiveWorkbook.PivotCaches().Add(Excel.XlPivotTableSourceType.xlExternal, (Excel.Range)sheet.get_Range("A1", "E10"));
            pivotCache.Connection = connection;
            pivotCache.MaintainConnection = true;
            pivotCache.CommandText = command;
            pivotCache.CommandType = Excel.XlCmdType.xlCmdSql;
            Excel.PivotTables pivotTables = (Excel.PivotTables)sheet.PivotTables(Type.Missing);
            Excel.PivotTable pivotTable = pivotTables.Add(pivotCache, app.ActiveCell, "PivotTable1", Type.Missing, Type.Missing);
            pivotTable.SmallGrid = false;
            pivotTable.ShowTableStyleRowStripes = true;
            pivotTable.TableStyle2 = "PivotStyleLight1";
            Excel.PivotFields rowField = (Excel.PivotFields)pivotTable.PivotFields(Type.Missing);
            int fieldCount = rowField.Count;

            for (int i = 1; i <= fieldCount; i++)
            {
                if ("Colunm" + i != "Colunm2" && "Colunm" + i != "Colunm5")
                {
                    Excel.PivotField field = (Excel.PivotField)pivotTable.PivotFields("Column" + i);
                    field.Orientation = Excel.XlPivotFieldOrientation.xlRowField;
                }
            }

            pivotTable.AddDataField(pivotTable.PivotFields("Column4"), "Sum of Column4", Excel.XlConsolidationFunction.xlSum);
        }

    }
}