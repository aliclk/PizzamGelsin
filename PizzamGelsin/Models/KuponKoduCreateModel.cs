using PizzamGelsin.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KuponKoduCreateModel
    {
        [Display(Name = "Kupon Kodu")]
        public string KuponKod { get; set; }
        [Display(Name = "Kupon İndirim Değeri")]
        public int Value { get; set; }
        [Display(Name = "İndirim Türü")]
        public IndirimTuru IndirimTuru { get; set; }
    }
}