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
    using System.Web.Mvc;
    
    public partial class Stockist
    {
        [HiddenInput(DisplayValue=false)]
        public int StockistId { get; set; }
        [Required(ErrorMessage="enter ur name")]
        public string StockistName { get; set; }
        [Required(ErrorMessage = "enter ur name")]
        public string Description { get; set; }
        [Required(ErrorMessage = "enter ur name")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
