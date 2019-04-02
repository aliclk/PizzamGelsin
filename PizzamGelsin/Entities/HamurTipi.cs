using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("HamurTipi")]
    public class HamurTipi : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string HamurAdi { get; set; }
        [Required]
        public Resim Resim { get; set; }
        [Required]
        public double EkFiyat { get; set; }

        public HamurTipi()
        {

        }
    }
}