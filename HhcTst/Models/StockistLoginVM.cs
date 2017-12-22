using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HhcTst.Models
{
    public class StockistLoginVM
    {
        [Required(ErrorMessage="please enter ur name")]
        public string StockistName { get; set; }
        [Required(ErrorMessage="please enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}