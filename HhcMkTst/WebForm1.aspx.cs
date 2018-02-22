using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HhcMkTst

{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            // string path = Server.MapPath("first.xls");
            string path = FileUpload1.PostedFile.FileName;
            string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
            con.ConnectionString = ConnString;
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from [sheet1$]", con);
            OleDbDataReader rd = cmd.ExecuteReader();
            GridView1.DataSource = rd;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String strConnection = "Data Source=HHCL-CORP-20308;Initial Catalog=SMS;Integrated Security=True";
            DataTable dt = new DataTable();
            dt.Columns.Add("TherapaticDesc", typeof(string));
            dt.Columns.Add("TherapaticHetCode", typeof(string));
            dt.Columns.Add("Therapaticname", typeof(string));
            dt.Columns.Add("ChkDiv", typeof(string));
            foreach (GridViewRow row in GridView1.Rows)
            {

                string TherapaticDesc = row.Cells[1].Text;
                string TherapaticHetCode = row.Cells[2].Text;
                string Therapaticname = row.Cells[3].Text;
                string ChkDiv = row.Cells[4].Text;
                dt.Rows.Add(TherapaticDesc, TherapaticHetCode, Therapaticname, ChkDiv);
            }
            using (SqlConnection con = new SqlConnection(strConnection))
            {
                con.Open();
                SqlBulkCopy sqlBulk = new SqlBulkCopy(strConnection);
                //Give your Destination table name
                sqlBulk.DestinationTableName = "Tbl_Therapatic";
                sqlBulk.WriteToServer(dt);
                con.Close();
            }
            lblmsg.Text = "Details Inserted Successfully";
            lblmsg.ForeColor = System.Drawing.Color.Green;
        }

    }
}