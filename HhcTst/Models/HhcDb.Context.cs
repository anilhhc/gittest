﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HhcDbEntities1 : DbContext
    {
        public HhcDbEntities1()
            : base("name=HhcDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CITY> CITies { get; set; }
        public virtual DbSet<COUNTRY> COUNTRies { get; set; }
        public virtual DbSet<Hdivision> Hdivisions { get; set; }
        public virtual DbSet<hhcAdminLogin> hhcAdminLogins { get; set; }
        public virtual DbSet<hhcControlPanelIPStat> hhcControlPanelIPStats { get; set; }
        public virtual DbSet<hhcprimarysale> hhcprimarysales { get; set; }
        public virtual DbSet<hhcsecondarysale> hhcsecondarysales { get; set; }
        public virtual DbSet<Hproductslist> Hproductslists { get; set; }
        public virtual DbSet<Hproductslistdescription> Hproductslistdescriptions { get; set; }
        public virtual DbSet<Hstockistdetail> Hstockistdetails { get; set; }
        public virtual DbSet<hstockistupload> hstockistuploads { get; set; }
        public virtual DbSet<Htherapatic> Htherapatics { get; set; }
        public virtual DbSet<Hvendordetail> Hvendordetails { get; set; }
        public virtual DbSet<Hvproductslist> Hvproductslists { get; set; }
        public virtual DbSet<Hvsale> Hvsales { get; set; }
        public virtual DbSet<OtherAdminLogin> OtherAdminLogins { get; set; }
        public virtual DbSet<OtherAdminPermission> OtherAdminPermissions { get; set; }
        public virtual DbSet<secondarysale> secondarysales { get; set; }
        public virtual DbSet<STATE> STATEs { get; set; }
        public virtual DbSet<subareaCITY> subareaCITies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UploadFileName> UploadFileNames { get; set; }
        public virtual DbSet<UserAdminLogin> UserAdminLogins { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<Usershetro> Usershetroes { get; set; }
        public virtual DbSet<VENDORSPECIALIZATION> VENDORSPECIALIZATIONs { get; set; }
        public virtual DbSet<VENDORSPECIALIZATION1> VENDORSPECIALIZATIONs1 { get; set; }
        public virtual DbSet<VENDORSUser> VENDORSUsers { get; set; }
        public virtual DbSet<VENDORTYPE> VENDORTYPES { get; set; }
        public virtual DbSet<VENDORTYPESpecialisationsentry> VENDORTYPESpecialisationsentries { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Stockist> Stockists { get; set; }
    }
}
