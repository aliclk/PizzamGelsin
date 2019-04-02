using PizzamGelsin.Entities;
using PizzamGelsin.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KullaniciCreateModel
    {
        [Display(Name = "Adı")]
        public string Adi { get; set; }
        [Display(Name = "Soyadı")]
        public string Soyadi { get; set; }
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }
        [Display(Name = "E-posta")]
        public string Eposta { get; set; }
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
        [Display(Name = "Kullanıcı Tipi")]
        public KullaniciTipi KullaniciTipi { get; set; }
        [Display(Name = "Adresler")]
        public List<Adres> Adresler { get; set; }
        [Display(Name = "Favoriler")]
        public List<Favori> Favoriler { get; set; }
        [Display(Name = "Sepet")]
        public List<Sepet> Sepet { get; set; }
        [Display(Name = "Geçmiş Siparişler")]
        public List<Siparis> GecmisSiparisler { get; set; }
        [Display(Name = "Yorumlar")]
        public List<Yorum> Yorumlar { get; set; }
    }
}