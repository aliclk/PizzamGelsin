using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class IcecekBoyutCreateModel
    {
        [Display(Name = "İçecek Boyutu")]
        public string Boyut { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimUrl { get; set; }
    }
}