using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class WebSiteCreateModel
    {
        [Display(Name = "Logo Url")]
        public string LogoUrl { get; set; }
        [Display(Name = "Web Site Adı")]
        public string WebAdi { get; set; }
    }
}