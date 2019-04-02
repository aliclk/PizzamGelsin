using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class MalzemeUpdateListModel
    {
        public string MalzemeUpdateListModelID { get; set; }
        [Display(Name = "Malzeme Ek Fiyatı")]
        public double EkFiyat { get; set; }
        [Display(Name = "Malzeme Adı")]
        public string MalzemeAdi { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimUrl { get; set; }

        public static List<MalzemeUpdateListModel> GetList()
        {
            List<MalzemeUpdateListModel> returnList = new List<MalzemeUpdateListModel>();
            foreach (var malzeme in DbFactory.MalzemeCrud.Records)
            {
                MalzemeUpdateListModel mulm = new MalzemeUpdateListModel();
                mulm.MalzemeUpdateListModelID = malzeme.ID;
                mulm.EkFiyat = malzeme.EkFiyat;
                mulm.MalzemeAdi = malzeme.MalzemeAdi;
                mulm.ResimUrl = malzeme.Resim.Url;

                returnList.Add(mulm);
            }
            return returnList;
        }
    }
}