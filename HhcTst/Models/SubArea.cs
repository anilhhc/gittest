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
    
    public partial class SubArea
    {
        public int SubAreaID { get; set; }
        public string SubArea1 { get; set; }
        public Nullable<int> CITYID { get; set; }
        public string ACTIVE { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual CITy CITy { get; set; }
    }
}
