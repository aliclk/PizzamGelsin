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
    [Table("KuponKodu")]
    public class KuponKodu : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string KuponKod { get; set; }
        [Required]
        [Range(0, 100)]
        public int Value { get; set; }
        [Required]
        public IndirimTuru IndirimTuru { get; set; }

        public KuponKodu()
        {

        }
    }
}