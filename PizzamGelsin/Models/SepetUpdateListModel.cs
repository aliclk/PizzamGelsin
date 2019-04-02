using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class SepetUpdateListModel
    {
        public string SepetUpdateListModelID { get; set; }
        [Display(Name = "Sepetteki Ürünler")]
        public Urun Urun { get; set; }
        [Display(Name = "Toplam Fiyat")]
        public double Fiyat { get; set; }
        [Display(Name = "Adet")]
        public int Adet { get; set; }

        public static List<SepetUpdateListModel> GetList()
        {
            List<SepetUpdateListModel> returnList = new List<SepetUpdateListModel>();
            foreach (var sepet in DbFactory.SepetCrud.Records)
            {
                SepetUpdateListModel sulm = new SepetUpdateListModel();
                sulm.SepetUpdateListModelID = sepet.ID;
                sulm.Urun = sepet.Urun;
                sulm.Fiyat = sepet.Fiyat;
                sulm.Adet = sepet.Adet;

                returnList.Add(sulm);
            }
            return returnList;
        }

    }
}