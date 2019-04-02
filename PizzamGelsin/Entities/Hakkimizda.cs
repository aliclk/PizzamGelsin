using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Hakkimizda")]
    public class Hakkimizda : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string Baslik { get; set; }
        [Required]
        [MaxLength(300)]
        public string Icerik { get; set; }
        [Required]
        public Resim Resim { get; set; }

        public Hakkimizda()
        {
                
        }
    }
}