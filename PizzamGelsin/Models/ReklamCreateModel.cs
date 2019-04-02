using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class ReklamCreateModel
    {
        [Display(Name = "Resim Yolu")]
        public string ResimURL { get; set; }
        [Display(Name = "Reklam Linki")]
        public string ReklamLink { get; set; }
    }
}