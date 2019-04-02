using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Pizza")]
    public class Pizza:Urun
    {
        public List<PizzaBoyut> Boyutlar { get; set; }
        public List<KenarTipi> Kenarlar { get; set; }
        public List<HamurTipi> Hamurlar { get; set; }
        public List<Malzeme> Malzemeler { get; set; }
        public Pizza()
        {
            Boyutlar = new List<PizzaBoyut>();
            Kenarlar = new List<KenarTipi>();
            Hamurlar = new List<HamurTipi>();
            Malzemeler = new List<Malzeme>();
        }
    }
}