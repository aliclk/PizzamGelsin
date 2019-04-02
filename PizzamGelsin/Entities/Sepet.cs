using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Sepet")]
    public class Sepet : DbObject
    {
        public Urun Urun { get; set; }
        [Required]
        public double Fiyat { get; set; }
        [Required]
        [Range(0, 100)]
        public int Adet { get; set; }

        public Sepet()
        {

        }
    }
}