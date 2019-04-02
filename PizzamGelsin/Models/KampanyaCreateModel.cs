using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KampanyaCreateModel
    {
        [Display(Name = "Kampanya Fiyatı")]
        public double Fiyat { get; set; }
        [Display(Name = "Kampanya Adı")]
        public string KampanyaAdi { get; set; }
        [Display(Name = "Kampanyaya Ürünleri Ekle")]
        public List<Urun> Urunler { get; set; }
    }
}