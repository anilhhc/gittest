﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StkDbEntities : DbContext
    {
        public StkDbEntities()
            : base("name=StkDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hhcsecondarysale> hhcsecondarysales { get; set; }
        public virtual DbSet<Hstockistdetail> Hstockistdetails { get; set; }
        public virtual DbSet<hstockistupload> hstockistuploads { get; set; }
        public virtual DbSet<secondarysale> secondarysales { get; set; }
        public virtual DbSet<STATE> STATEs { get; set; }
        public virtual DbSet<Stockist> Stockists { get; set; }
        public virtual DbSet<SubArea> SubAreas { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<CITy> CITies { get; set; }
    }
}
