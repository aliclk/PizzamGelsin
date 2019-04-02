using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class ResimCreateModel
    {
        [Display(Name = "Resim Yolu")]
        public string Url { get; set; }
    }
}