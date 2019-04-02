using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("PizzaBoyut")]
    public class PizzaBoyut : DbObject
    {
        [Required]
        [MaxLength(100)]
        public string BoyutAdi { get; set; }

        public PizzaBoyut()
        {

        }
    }
}