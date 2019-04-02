using PizzamGelsin.Entities;
using PizzamGelsin.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class SiparisCreateModel
    {
        [Display(Name = "Ürün Listesi")]
        public List<Sepet> Urunler { get; set; }
        [Display(Name = "Adres")]
        public Adres Adres { get; set; }
        [Display(Name = "Sipariş Durumu")]
        public SiparisDurumu SiparisDurumu { get; set; }
    }
}