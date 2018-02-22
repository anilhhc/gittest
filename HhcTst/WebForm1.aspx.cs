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
            HhcDbEntities db=new HhcDbEntities();
            GridView1.DataSource = db.SpHhcPs();
            GridView1.DataBind();
        }
    }
}