using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Resim")]
    public class Resim : DbObject
    {
        [Required]
        [MaxLength(1000)]
        public string Url { get; set; }

        public Resim()
        {

        }
    }
}