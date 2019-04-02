using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Calisan")]
    public class Calisan : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(300)]
        public string Ozgecmis { get; set; }
        [Required]
        [MaxLength(50)]
        public string Unvan { get; set; }
        [Required]
        public Resim Resim { get; set; }

        public Calisan()
        {
                
        }
    }
}