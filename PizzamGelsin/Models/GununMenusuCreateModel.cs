using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class GununMenusuCreateModel
    {
        [Display(Name = "Tarih")]
        public DateTime Tarih { get; set; }
        [Display(Name = "Ürün Ekle")]
        public List<Urun> Urunler { get; set; }
    }
}