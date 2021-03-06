﻿using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KampanyaUpdateListModel
    {
        public string KampanyaUpdateListModelID { get; set; }
        [Display(Name = "Kampanya Fiyatı")]
        public double Fiyat { get; set; }
        [Display(Name = "Kampanya Adı")]
        public string KampanyaAdi { get; set; }
        [Display(Name = "Kampanyaya Pizza Ekle")]
        public Pizza Pizza { get; set; }
        [Display(Name = "Kampanyaya Icecek Ekle")]
        public Icecek Icecek { get; set; }


        public static List<KampanyaUpdateListModel> GetList()
        {
            List<KampanyaUpdateListModel> returnList = new List<KampanyaUpdateListModel>();
            foreach (var kampanya in DbFactory.KampanyaCrud.Records)
            {
                KampanyaUpdateListModel kulm = new KampanyaUpdateListModel();
                kulm.KampanyaUpdateListModelID = kampanya.ID;
                kulm.Fiyat = kampanya.Fiyat;
                kulm.KampanyaAdi = kampanya.KampanyaAdi;
                kulm.Pizza = kampanya.Pizza;
                kulm.Icecek = kampanya.Icecek;

                returnList.Add(kulm);
            }
            return returnList;
        }

    }
}