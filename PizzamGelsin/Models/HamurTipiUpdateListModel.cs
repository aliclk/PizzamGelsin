using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class HamurTipiUpdateListModel
    {
        public string HamurTipiUpdateListModelID { get; set; }
        [Display(Name = "Hamur Adı")]
        public string HamurAdi { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimUrl { get; set; }
        [Display(Name = "Ek Fiyat")]
        public double EkFiyat { get; set; }

        public static List<HamurTipiUpdateListModel> GetList()
        {
            List<HamurTipiUpdateListModel> returnList = new List<HamurTipiUpdateListModel>();
            foreach (var hamurtipi in DbFactory.HamurTipiCrud.Records)
            {
                HamurTipiUpdateListModel htulm = new HamurTipiUpdateListModel();
                htulm.HamurTipiUpdateListModelID = hamurtipi.ID;
                htulm.HamurAdi = hamurtipi.HamurAdi;
                htulm.ResimUrl = hamurtipi.Resim.Url;
                htulm.EkFiyat = hamurtipi.EkFiyat;

                returnList.Add(htulm);
            }
            return returnList;
        }
    }
}