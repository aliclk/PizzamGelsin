using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class PizzaBoyutCreateModel
    {
        [Display(Name = "Pizza Boyut Adı")]
        public string BoyutAdi { get; set; }
    }
}