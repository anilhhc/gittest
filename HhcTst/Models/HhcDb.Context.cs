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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HhcDbEntities : DbContext
    {
        public HhcDbEntities()
            : base("name=HhcDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CITy> CITies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Hdivision> Hdivisions { get; set; }
        public virtual DbSet<hhcControlPanelIPStat> hhcControlPanelIPStats { get; set; }
        public virtual DbSet<hhcprimarysale> hhcprimarysales { get; set; }
        public virtual DbSet<hhcsecondarysale> hhcsecondarysales { get; set; }
        public virtual DbSet<Hproductslistdescription> Hproductslistdescriptions { get; set; }
        public virtual DbSet<Hproductslist> Hproductslists { get; set; }
        public virtual DbSet<Hstockistdetail> Hstockistdetails { get; set; }
        public virtual DbSet<hstockistupload> hstockistuploads { get; set; }
        public virtual DbSet<Htherapatic> Htherapatics { get; set; }
        public virtual DbSet<Hvendordetail> Hvendordetails { get; set; }
        public virtual DbSet<Hvproductslist> Hvproductslists { get; set; }
        public virtual DbSet<Hvsale> Hvsales { get; set; }
        public virtual DbSet<OtherAdminLogin> OtherAdminLogins { get; set; }
        public virtual DbSet<OtherAdminPermission> OtherAdminPermissions { get; set; }
        public virtual DbSet<secondarysale> secondarysales { get; set; }
        public virtual DbSet<Stockist> Stockists { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UploadFileName> UploadFileNames { get; set; }
        public virtual DbSet<UserAdminLogin> UserAdminLogins { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<Usershetro> Usershetroes { get; set; }
        public virtual DbSet<VENDORSPECIALIZATION> VENDORSPECIALIZATIONs { get; set; }
        public virtual DbSet<VENDORSPECIALIZATIONs1> VENDORSPECIALIZATIONs1 { get; set; }
        public virtual DbSet<VENDORSUser> VENDORSUsers { get; set; }
        public virtual DbSet<VENDORTYPE> VENDORTYPES { get; set; }
        public virtual DbSet<VENDORTYPESpecialisationsentry> VENDORTYPESpecialisationsentries { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<hhcAdminLogin> hhcAdminLogins { get; set; }
        public virtual DbSet<STATE> STATEs { get; set; }
        public virtual DbSet<SubArea> SubAreas { get; set; }
        public virtual DbSet<tbl_registration> tbl_registration { get; set; }
        public virtual DbSet<UploadedFile> UploadedFiles { get; set; }
    
        public virtual ObjectResult<Nullable<int>> spSkCountId(string stockistname, string stockistId)
        {
            var stockistnameParameter = stockistname != null ?
                new ObjectParameter("stockistname", stockistname) :
                new ObjectParameter("stockistname", typeof(string));
    
            var stockistIdParameter = stockistId != null ?
                new ObjectParameter("StockistId", stockistId) :
                new ObjectParameter("StockistId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spSkCountId", stockistnameParameter, stockistIdParameter);
        }
    
        public virtual ObjectResult<string> osHhcSs()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("osHhcSs");
        }
    
        public virtual ObjectResult<Cltive_HhcSs_Result> Cltive_HhcSs(string stockistname, string month, string year, string stockistproductname)
        {
            var stockistnameParameter = stockistname != null ?
                new ObjectParameter("stockistname", stockistname) :
                new ObjectParameter("stockistname", typeof(string));
    
            var monthParameter = month != null ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(string));
    
            var yearParameter = year != null ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(string));
    
            var stockistproductnameParameter = stockistproductname != null ?
                new ObjectParameter("stockistproductname", stockistproductname) :
                new ObjectParameter("stockistproductname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cltive_HhcSs_Result>("Cltive_HhcSs", stockistnameParameter, monthParameter, yearParameter, stockistproductnameParameter);
        }
    
        public virtual ObjectResult<string> monthHhcSs()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("monthHhcSs");
        }
    
        public virtual ObjectResult<string> stockistproductnameHhcSs()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("stockistproductnameHhcSs");
        }
    
        public virtual ObjectResult<string> yearHhcSs()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("yearHhcSs");
        }
    }
}
