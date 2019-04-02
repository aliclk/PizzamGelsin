using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class HamurTipiCreateModel
    {
        [Display(Name = "Hamur Adı")]
        public string HamurAdi { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimUrl { get; set; }
        [Display(Name = "Ek Fiyat")]
        public double EkFiyat { get; set; }
    }
}