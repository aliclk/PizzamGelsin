using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Kampanya")]
    public class Kampanya : DbObject
    {
        [Required]
        public double Fiyat { get; set; }
        [Required]
        [MaxLength(100)]
        public string KampanyaAdi { get; set; }
        public List<Urun> Urunler { get; set; }

        public Kampanya()
        {
            Urunler = new List<Urun>();
        }
    }
}