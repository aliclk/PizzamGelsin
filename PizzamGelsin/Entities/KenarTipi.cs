using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("KenarTipi")]
    public class KenarTipi : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string KenarAdi { get; set; }
        [Required]
        public Resim KenarResim { get; set; }
        [Required]
        public double EkFiyat { get; set; }

        public KenarTipi()
        {

        }
    }
}