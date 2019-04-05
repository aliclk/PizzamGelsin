using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class UrunUpdateListModel
    {
        public string UrunUpdateListModelID { get; set; }
        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }
        [Display(Name = "Ürün Fiyatı")]
        public double UrunFiyat { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string UrunAciklama { get; set; }
        [Display(Name = "Adet")]
        public int UrunAdet { get; set; }
        [Display(Name = "Ürün Resimleri")]
        public List<Resim> UrunResimleri { get; set; }
        [Display(Name = "Ürün Alınma Adedi")]
        public int AlinmaAdedi { get; set; }
        [Display(Name = "Ürün Yıldız")]
        public int Yildiz { get; set; }

        //    public static List<UrunUpdateListModel> GetList()
        //    {
        //        List<UrunUpdateListModel> returnList = new List<UrunUpdateListModel>();
        //        foreach (var urun in DbFactory.UrunCrud.Records)
        //        {
        //            UrunUpdateListModel uulm = new UrunUpdateListModel();
        //            uulm.UrunUpdateListModelID = urun.ID;
        //            uulm.UrunAdi = urun.UrunAdi;
        //            uulm.UrunFiyat = urun.UrunFiyat;
        //            uulm.UrunAciklama = urun.UrunAciklama;
        //            uulm.UrunAdet = urun.UrunAdet;
        //            uulm.UrunResimleri = urun.UrunResimleri;
        //            uulm.AlinmaAdedi = urun.AlinmaAdedi;
        //            uulm.Yildiz = urun.Yildiz;

        //            returnList.Add(uulm);
        //        }
        //        return returnList;
        //    }
    }
}