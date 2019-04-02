using PizzamGelsin.Classes;
using PizzamGelsin.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KuponKoduUpdateListModel
    {
        public string KuponKoduUpdateListModelID { get; set; }
        [Display(Name = "Kupon Kodu")]
        public string KuponKod { get; set; }
        [Display(Name = "Kupon İndirim Değeri")]
        public int Value { get; set; }
        [Display(Name = "İndirim Türü")]
        public IndirimTuru IndirimTuru { get; set; }

        public static List<KuponKoduUpdateListModel> GetList()
        {
            List<KuponKoduUpdateListModel> returnList = new List<KuponKoduUpdateListModel>();
            foreach (var kupon in DbFactory.KuponKoduCrud.Records)
            {
                KuponKoduUpdateListModel kkulm = new KuponKoduUpdateListModel();
                kkulm.KuponKoduUpdateListModelID = kupon.ID;
                kkulm.KuponKod = kupon.KuponKod;
                kkulm.Value = kupon.Value;
                kkulm.IndirimTuru = kupon.IndirimTuru;
                
                returnList.Add(kkulm);
            }
            return returnList;
        }
    }
}