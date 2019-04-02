using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Yorum")]
    public class Yorum : DbObject
    {
        public Urun Urun { get; set; }
        [Required]
        [MaxLength(3000)]
        public string YorumIcerigi { get; set; }

        public Yorum()
        {

        }
    }
}