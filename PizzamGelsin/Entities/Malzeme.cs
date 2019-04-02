using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Malzeme")]
    public class Malzeme : DbObject
    {
        [Required]
        public double EkFiyat { get; set; }
        [Required]
        [MaxLength(100)]
        public string MalzemeAdi { get; set; }
        [Required]
        public Resim Resim { get; set; }

        public Malzeme()
        {

        }
    }
}