using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class GununMenusuUpdateListModel
    {
        public string GununMenusuUpdateListModelID { get; set; }
        [Display(Name = "Tarih")]
        public DateTime Tarih { get; set; }
        [Display(Name = "Ürün Ekle")]
        public List<Urun> Urunler { get; set; }

        public static List<GununMenusuUpdateListModel> GetList()
        {
            List<GununMenusuUpdateListModel> returnList = new List<GununMenusuUpdateListModel>();
            foreach (var gununmenusu in DbFactory.GununMenusuCrud.Records)
            {
                GununMenusuUpdateListModel gnulm = new GununMenusuUpdateListModel();
                gnulm.GununMenusuUpdateListModelID = gununmenusu.ID;
                gnulm.Tarih = gununmenusu.Tarih;
                gnulm.Urunler = gununmenusu.Urunler;

                returnList.Add(gnulm);
            }
            return returnList;
        }
    }
}