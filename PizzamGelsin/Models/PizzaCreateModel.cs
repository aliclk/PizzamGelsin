using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class PizzaCreateModel:UrunCreateModel
    {
        public List<PizzaBoyut> Boyutlar { get; set; }
        public List<KenarTipi> Kenarlar { get; set; }
        public List<HamurTipi> Hamurlar { get; set; }
        public List<Malzeme> Malzemeler { get; set; }
    }
}