using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class CalisanCreateModel
    {
        [Display(Name = "Adı")]
        public string Adi { get; set; }
        [Display(Name = "Özgeçmiş")]
        public string Ozgecmis { get; set; }
        [Display(Name = "Ünvan")]
        public string Unvan { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimURL { get; set; }
    }
}