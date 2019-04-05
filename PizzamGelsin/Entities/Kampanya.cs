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
        public Pizza Pizza { get; set; }
        public Icecek Icecek { get; set; }

        public Kampanya()
        {
        }
    }
}