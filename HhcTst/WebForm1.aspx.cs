using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HhcTst.Models;

namespace HhcTst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        HhcDbEntities db = new HhcDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var dbContext = new HhcDbEntities())
            {
                var query = dbContext.hhcsecondarysales.Select(x => x.openingstock).ToList();
              //  DropDownList1.DataSource = query;
                //if (DropDownList1.SelectedItem.Value)
                //{
                //    query = query.Where(en => en.PropertyName1 == textBox1.Text);
                //}
                //// Integer value
                //if (textBox2.Text != string.Empty)
                //{
                //    int textBox2AsInt = int.Parse(textBox2.Text);
                //    query = query.Where(en => en.PropertyName2 == textBox2AsInt);
                //}
                //if (textBox3.Text != string.Empty)
                //{
                //    query = query.Where(en => en.PropertyName3 == textBox3.Text);
                //}
                //if (textBox4.Text != string.Empty)
                //{
                //    query = query.Where(en => en.PropertyName4 == textBox4.Text);
                //}
                // Execute the query
                var queryResult = query.ToList();
                var v = dbContext.hhcsecondarysales.Select(x => x.heteroproductname).ToList();
                DropDownList3.DataSource = v;
                DropDownList3.DataBind();
                DropDownList2.DataSource = queryResult;
                DropDownList2.DataBind();
            }

        }

        //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //IQueryable<hhcsecondarysale> query = db.hhcsecondarysales;
        //    //    query = query.Where(en => en.openingstock ==int.Parse(DropDownList1.SelectedItem.Value));
            
        //}

        
    }
}