using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HhcTst.Models
{
    public class CascadingTestModel
    {
        public IList<SelectListItem> ZoneNames { get; set; }
        public IList<SelectListItem> StateNames { get; set;}
        public IList<SelectListItem> CityNames { get; set; }
    }
}