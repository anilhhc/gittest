//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HhcTst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class secondarysale
    {
        public int secondarysalesID { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string filepath { get; set; }
        public string stockistid { get; set; }
        public string productcode { get; set; }
        public string productname { get; set; }
        public string pack { get; set; }
        public Nullable<int> purshcasequantity { get; set; }
        public Nullable<int> purchasereturn { get; set; }
        public Nullable<int> openingquantity { get; set; }
        public Nullable<int> salequanitity { get; set; }
        public Nullable<int> salereturn { get; set; }
        public Nullable<int> closing { get; set; }
        public string heteroproductid { get; set; }
    }
}
