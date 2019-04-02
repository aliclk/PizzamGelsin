using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class SepetCreateModel
    {
        [Display(Name = "Sepetteki Ürünler")]
        public Urun Urun { get; set; }
        [Display(Name = "Toplam Fiyat")]
        public double Fiyat { get; set; }
        [Display(Name = "Adet")]
        public int Adet { get; set; }
    }
}