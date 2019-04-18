using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class FooterCreateModel
    {
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        [Display(Name = "Adres")]
        public string Adres { get; set; }
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }
        [Display(Name = "E-Mail Adresi")]
        public string EMail { get; set; }
        [Display(Name = "Instagram ")]
        public string InstagramAdres { get; set; }
        [Display(Name = "Facebook ")]
        public string FacebookAdres { get; set; }
        [Display(Name = "Youtube")]
        public string YoutubeAdres { get; set; }
        [Display(Name = "Twitter")]
        public string TwitterAdres { get; set; }
        [Display(Name = "GooglePlus")]
        public string GooglePlusAdres { get; set; }
        [Display(Name = "Pinterest")]
        public string PinterestAdres { get; set; }
    }
}