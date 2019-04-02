using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Tatli")]
    public class Tatli:Urun
    {
        public Tatli()
        {

        }
    }
}