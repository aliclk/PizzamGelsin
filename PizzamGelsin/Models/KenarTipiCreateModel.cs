using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KenarTipiCreateModel
    {
        [Display(Name = "Pizza Kenar Adı")]
        public string KenarAdi { get; set; }
        [Display(Name = "Resim Yolu")]
        public string KenarResimUrl { get; set; }
        [Display(Name = "Pizza Kenarı Ek Fiyatı")]
        public double EkFiyat { get; set; }
    }
}