using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class AdresCreateModel
    {
        [Display(Name = "Adres Gir")]
        public string AdresIcerik { get; set; }
        [Display(Name = "Adres Adı")]
        public string Adi { get; set; }
    }
}