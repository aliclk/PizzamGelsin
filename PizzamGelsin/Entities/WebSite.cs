using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("WebSite")]
    public class WebSite : DbObject
    {
        public Resim Logo { get; set; }
        [Required]
        [MaxLength(200)]
        public string WebAdi { get; set; }

        public WebSite()
        {

        }
    }
}