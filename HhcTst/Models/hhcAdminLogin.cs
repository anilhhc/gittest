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
    using System.ComponentModel.DataAnnotations;
    
    public partial class hhcAdminLogin
    {
        public int hhcAdminLoginsId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string Name { get; set; }
        public string Permissions { get; set; }
        public string EmailID { get; set; }
        public string ActiveStatus { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
