using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class CalisanUpdateListModel
    {
        public string CalisanUpdateListModelID { get; set; }
        [Display(Name = "Adı")]
        public string Adi { get; set; }
        [Display(Name = "Özgeçmiş")]
        public string Ozgecmis { get; set; }
        [Display(Name = "Ünvan")]
        public string Unvan { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimURL { get; set; }

        public static List<CalisanUpdateListModel> GetList()
        {
            List<CalisanUpdateListModel> returnList = new List<CalisanUpdateListModel>();
            foreach (var calisan in DbFactory.CalisanCrud.Records)
            {
                CalisanUpdateListModel culm = new CalisanUpdateListModel();
                culm.CalisanUpdateListModelID = calisan.ID;
                culm.Adi = calisan.Adi;
                culm.Ozgecmis = calisan.Ozgecmis;
                culm.Unvan = calisan.Unvan;
                culm.ResimURL = calisan.Resim.Url;

                returnList.Add(culm);
            }
            return returnList;
        }


    }
}