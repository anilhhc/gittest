using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HhcTst.Models
{
    public class TestUploadExcel
    {
        public int ID { get; set; }
        public string CostCenter { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Services { get; set; }
        public string UsageType { get; set; }
        public string Network { get; set; }
        public int UsageIncluded { get; set; }
        public string Unit { get; set; }
    }
}