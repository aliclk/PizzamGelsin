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
        public List<Urun> Urunler { get; set; }

        public Favori()
        {
            Urunler = new List<Urun>();
        }
    }
}