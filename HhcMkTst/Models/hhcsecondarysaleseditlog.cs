//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HhcMkTst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hhcsecondarysaleseditlog
    {
        public int ID { get; set; }
        public string QUERYDESC { get; set; }
        public Nullable<System.DateTime> edittime { get; set; }
        public Nullable<int> openingstock { get; set; }
        public Nullable<int> purchasequantity { get; set; }
        public Nullable<int> salesquantity { get; set; }
        public Nullable<int> purchasereturn { get; set; }
        public Nullable<int> salesreturn { get; set; }
        public Nullable<int> closingstock { get; set; }
        public Nullable<int> secondarysalesid { get; set; }
    }
}
