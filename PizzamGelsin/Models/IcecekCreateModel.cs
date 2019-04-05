using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class IcecekCreateModel:UrunCreateModel
    {
        public List<IcecekBoyut> Icecekboyutlar { get; set; }
    }
}