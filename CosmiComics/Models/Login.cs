using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosmiComics.Models
{
    public class Login
    {
        [Required(ErrorMessage = "No username given")]
        [Display(Name = "Admin Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "No password given")]
        [Display(Name = "Admin Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}