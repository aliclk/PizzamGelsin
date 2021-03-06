﻿using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class UrunCreateModel
    {
        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }
        [Display(Name = "Ürün Fiyatı")]
        public double UrunFiyat { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string UrunAciklama { get; set; }
        [Display(Name = "Adet")]
        public int UrunAdet { get; set; }
        [Display(Name = "Ürün Resimleri")]
        public List<Resim> UrunResimleri { get; set; }
        [Display(Name = "Ürün Alınma Adedi")]
        public int AlinmaAdedi { get; set; }
        [Display(Name = "Ürün Yıldız")]
        public int Yildiz { get; set; }
    }
}