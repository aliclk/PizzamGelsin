using OhmCrud;
using PizzamGelsin.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Kullanici")]
    public class Kullanici : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(50)]
        public string Soyadi { get; set; }
        [Required]
        [MaxLength(50)]
        public string Telefon { get; set; }
        [Required]
        [MaxLength(50)]
        public string Eposta { get; set; }
        [Required]
        [MaxLength(50)]
        public string Sifre { get; set; }
        [Required]
        public KullaniciTipi KullaniciTipi { get; set; }
        public List<Adres> Adresler { get; set; }
        public List<Favori> Favoriler { get; set; }
        public List<Sepet> Sepet { get; set; }
        public List<Siparis> GecmisSiparisler { get; set; }
        public List<Yorum> Yorumlar { get; set; }

        public Kullanici()
        {
            Adresler = new List<Adres>();
            Favoriler = new List<Favori>();
            Sepet = new List<Sepet>();
            GecmisSiparisler = new List<Siparis>();
            Yorumlar = new List<Yorum>();
        }
    }
   
}