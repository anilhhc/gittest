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
    
    public partial class STATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STATE()
        {
            this.CITies = new HashSet<CITy>();
        }
    
        public int STATEID { get; set; }
        public string STATENAME { get; set; }
        public Nullable<int> Zone { get; set; }
        public string ACTIVE { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual Zone Zone1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITy> CITies { get; set; }
    }
}
