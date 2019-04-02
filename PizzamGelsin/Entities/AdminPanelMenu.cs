using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("AdminPanelMenu")]
    public class AdminPanelMenu:DbObject
    {
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Url { get; set; }

        public AdminPanelMenu()
        {

        }
    }
}