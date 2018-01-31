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
        protected void Page_Load(object sender, EventArgs e)
        {
            HhcDbEntities db = new HhcDbEntities();
            // int a=4;
            // var v = db.hhcAdminLogins.
            //   Where(a => a.UserName.Equals(tbRes.UserName) && a.UserPwd.Equals(tbRes.UserPwd)).FirstOrDefault();
            // GridView1.DataSource = db.STATEs.Where(x=>x.Zone1.ZoneID==a).OrderByDescending(x=>x.ACTIVE).ToList();
            // GridView1.DataBind();
            // var v = db.hhcsecondarysales.Sum(x => x.purshcasequantity>0).ToString();
            // Label1.Text ="the value is"+ v.ToString();
            // GridView1.DataSource = v;
            // GridView1.DataBind();



            var query = db.hhcsecondarysales.Where(x => x.hhcsecondarysalesID > 0).ToList();
            // int i = "purshcasequantity.Equals(purchasequantity) && x.month.Equals(monthyearid)";
            int i = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            var j = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            int k = Convert.ToInt32(DropDownList3.SelectedItem.Value);
            //AllApplications.Where(x => string.Equals(x.Name, txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            // db.hhcsecondarysales.Where(x =>x.purshcasequantity.Equals(i)).ToList();
            if (i>=0)
            {

                if(j>=0)
                {
                    if (k >=0)
                    { 
                    
                    }
                
                }
                var v1 = db.hhcsecondarysales.Where(x => x.purshcasequantity ==i||x.salequanitity==j).ToList();
                var v = db.hhcsecondarysales.Where(x => x.purshcasequantity == i).ToList();
                var v2 = from c in db.hhcsecondarysales.ToList()
                         where c.purshcasequantity > 0 
                         where c.purshcasequantity==i
                         select c;
                GridView1.DataSource = v1;
                GridView1.DataBind();
            }
        }

        
    }
}