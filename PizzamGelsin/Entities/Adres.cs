using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Adres")]
    public class Adres : DbObject
    {
        [Required]
        [MaxLength(30)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(200)]
        public string AdresIcerik { get; set; }

        public Adres()
        {

        }
    }
}