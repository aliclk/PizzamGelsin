using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class CartModel
    {
        public string PizzaId { get; set; }
        [Required]
        public string PizzaBoyut { get; set; }
        [Required]
        public string PizzaKenar { get; set; }
        [Required]
        public string PizzaHamur { get; set; }
        [Required]
        public int Adet { get; set; }
        [Required]
        public string IcecekAdi { get; set; }
    }
}