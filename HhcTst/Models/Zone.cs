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
    
    public partial class Zone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zone()
        {
            this.STATEs = new HashSet<STATE>();
        }
    
        public int ZoneID { get; set; }
        public string ZoneName { get; set; }
        public string ACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STATE> STATEs { get; set; }
    }
}
