using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class YorumCreateModel
    {
        [Display(Name = "Ürün")]
        public Urun Urun { get; set; }
        [Display(Name = "Yorum İçeriği")]
        public string YorumIcerigi { get; set; }
    }
}