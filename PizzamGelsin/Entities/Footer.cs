using OhmCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Entities
{
    [Table("Footer")]
    public class Footer : DbObject
    {
        [MaxLength(200)]
        public string Aciklama { get; set; }
        [MaxLength(200)]
        public string Adres { get; set; }
        [MaxLength(200)]
        public string Telefon { get; set; }
        [MaxLength(200)]
        public string EMail { get; set; }
        [MaxLength(200)]
        public string InstagramAdres { get; set; }
        [MaxLength(200)]
        public string FacebookAdres { get; set; }
        [MaxLength(200)]
        public string YoutubeAdres { get; set; }
        [MaxLength(200)]
        public string TwitterAdres { get; set; }
        [MaxLength(200)]
        public string GooglePlusAdres { get; set; }
        [MaxLength(200)]
        public string PinterestAdres { get; set; }
        
    }
}