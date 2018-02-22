using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HhcMkTst.Models;
using System.Data;

namespace HhcMkTst
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HhcmkdbEntities db = new HhcmkdbEntities();
           List<Hproductslist> v = db.Hproductslists.ToList();
            GridView1.DataSource = v;
            GridView1.DataBind();
            
        }

       
    }
}