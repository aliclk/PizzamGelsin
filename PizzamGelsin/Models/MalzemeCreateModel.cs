using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class MalzemeCreateModel
    {
        [Display(Name = "Malzeme Ek Fiyatı")]
        public double EkFiyat { get; set; }
        [Display(Name = "Malzeme Adı")]
        public string MalzemeAdi { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimUrl { get; set; }
    }
}