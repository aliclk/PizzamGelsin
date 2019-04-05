using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Urun")]
    public class Urun : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string UrunAdi { get; set; }
        [Required]
        public double UrunFiyat { get; set; }
        [Required]
        [MaxLength(1000)]
        public string UrunAciklama { get; set; }
        [Required]
        [Range(0,101)]
        public int UrunAdet { get; set; }
        public List<Resim> UrunResimleri { get; set; }
        [Required]
        [Range(0, 100)]
        public int AlinmaAdedi { get; set; }
        [Required]
        [Range(0, 100)]
        public int Yildiz { get; set; }

        public Urun()
        {
            UrunResimleri = new List<Resim>();
        }
        public override string ToString()
        {
            return UrunAdi;
        }
    }
}