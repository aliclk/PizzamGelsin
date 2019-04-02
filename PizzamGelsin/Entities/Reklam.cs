using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Reklam")]
    public class Reklam : DbObject
    {
        public Resim  Resim { get; set; }
        [Required]
        [MaxLength(700)]
        public string ReklamLink { get; set; }

        public Reklam()
        {

        }
    }
}