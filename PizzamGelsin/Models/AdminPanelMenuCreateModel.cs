using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class AdminPanelMenuCreateModel
    {
        [Display(Name = "Adı")]
        public string Adi { get; set; }
        [Display(Name = "Resim Yolu")]
        public string Url { get; set; }
    }
}