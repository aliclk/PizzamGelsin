using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("GununMenusu")]
    public class GununMenusu : DbObject
    {
        public DateTime Tarih { get; set; }
        public List<Urun> Urunler { get; set; }

        public GununMenusu()
        {
            Urunler = new List<Urun>();
        }
    }
}