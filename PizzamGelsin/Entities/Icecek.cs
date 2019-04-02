using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Icecek")]
    public class Icecek:Urun
    {
        public List<IcecekBoyut> Icecekboyutlar { get; set; }

        public Icecek()
        {
            Icecekboyutlar = new List<IcecekBoyut>();
        }
    }
}