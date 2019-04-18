using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KenarTipiUpdateListModel
    {
        public string KenarTipiUpdateListModelID { get; set; }
        [Display(Name = "Pizza Kenar Adı")]
        public string KenarAdi { get; set; }
        [Display(Name = "Resim Yolu")]
        public string KenarResimUrl { get; set; }
        [Display(Name = "Pizza Kenarı Ek Fiyat")]
        public double EkFiyat { get; set; }

        public static List<KenarTipiUpdateListModel> GetList()
        {
            List<KenarTipiUpdateListModel> returnList = new List<KenarTipiUpdateListModel>();
            foreach (var kenartipi in DbFactory.KenarTipiCrud.Records)
            {
                KenarTipiUpdateListModel ktulm = new KenarTipiUpdateListModel();
                ktulm.KenarTipiUpdateListModelID = kenartipi.ID;
                ktulm.KenarAdi = kenartipi.KenarAdi;
                ktulm.KenarResimUrl = kenartipi.KenarResim.Url;
                ktulm.EkFiyat = kenartipi.EkFiyat;

                returnList.Add(ktulm);
            }
            return returnList;
        }
    }
}