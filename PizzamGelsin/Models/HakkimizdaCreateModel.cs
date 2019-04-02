using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class HakkimizdaCreateModel
    {
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }
        [Display(Name = "İçerik")]
        public string Icerik { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimUrl { get; set; }
    }
}