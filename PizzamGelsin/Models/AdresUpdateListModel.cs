using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class AdresUpdateListModel
    {
        public string AdresUpdateListModelID { get; set; }
        [Display(Name = "Adres Gir")]
        public string AdresIcerik { get; set; }
        [Display(Name = "Adres Adı")]
        public string Adi { get; set; }
        public static List<AdresUpdateListModel> GetList()
        {
            List<AdresUpdateListModel> returnList = new List<AdresUpdateListModel>();
            foreach (var adres in DbFactory.AdresCrud.Records)
            {
                AdresUpdateListModel aulm= new AdresUpdateListModel();
                aulm.AdresUpdateListModelID = adres.ID;
                aulm.Adi = adres.Adi;
                aulm.AdresIcerik = adres.AdresIcerik;

                returnList.Add(aulm);
            }
            return returnList;
        }
    }
}