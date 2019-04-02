using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KrediKartiCreateModel
    {
        [Display(Name = "Kartı Kullanan Adı Soyadı")]
        public string KisiAdSoyad { get; set; }
        [Display(Name = "Son Kullanma Tarihi Yıl")]
        public int Yil { get; set; }
        [Display(Name = "Son Kullanma Tarihi Ay")]
        public int Ay { get; set; }
        [Display(Name = "Kredi Kartı No")]
        public string KrediKartNo { get; set; }
        [Display(Name = "Cvv(Kartın Arkasındaki 3 Hane)")]
        public string Cvv { get; set; }
    }
}