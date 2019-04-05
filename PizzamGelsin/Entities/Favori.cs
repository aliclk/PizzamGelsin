using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Favori")]
    public class Favori : DbObject
    {
        public Urun Urunler { get; set; }
    }
}