using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HhcTst.Models
{
    public class LoginVm
    {
        [Required(ErrorMessage="type ur name")]
        public string AdminName { get; set; }
        [Required(ErrorMessage="type ur password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}