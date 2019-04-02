using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("IcecekBoyutlari")]
    public class IcecekBoyut : DbObject
    {
        [Required]
        [MaxLength(50)]
        public string Boyut { get; set; }
        [Required]
        public Resim Resim { get; set; }

        public IcecekBoyut()
        {

        }
    }
}