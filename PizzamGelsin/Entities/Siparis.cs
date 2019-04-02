using OhmCrud;
using PizzamGelsin.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Siparis")]
    public class Siparis : DbObject

    {
        public List<Sepet> Urunler{ get; set; }
        public Adres Adres { get; set; }
        [Required]
        public SiparisDurumu SiparisDurumu { get; set; }

        public Siparis()
        {
            Urunler = new List<Sepet>();
        }
    }
}