//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HhcTst.Areas.Stockist.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hstockistupload
    {
        public int hstockistuploadID { get; set; }
        public string filedescription { get; set; }
        public Nullable<int> month { get; set; }
        public Nullable<int> year { get; set; }
        public Nullable<int> filenumber { get; set; }
        public Nullable<System.DateTime> fileuploaddate { get; set; }
        public string filepath { get; set; }
        public string monthname { get; set; }
        public string stockistid { get; set; }
        public string Status { get; set; }
    }
}
