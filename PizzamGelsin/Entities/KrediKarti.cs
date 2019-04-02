using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("KrediKarti")]
    public class KrediKarti : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string KisiAdSoyad { get; set; }
        [Required]
        [Range(0, 100)]
        public int Yil { get; set; }
        [Required]
        [Range(0, 100)]
        public int Ay { get; set; }
        [Required]
        [MaxLength(100)]
        public string KrediKartNo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Cvv { get; set; }

        public KrediKarti()
        {

        }
    }
}