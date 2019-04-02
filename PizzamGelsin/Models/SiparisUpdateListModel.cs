using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using PizzamGelsin.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class SiparisUpdateListModel
    {
        public string SiparisUpdateListModelID { get; set; }
        [Display(Name = "Ürün Listesi")]
        public List<Sepet> Urunler { get; set; }
        [Display(Name = "Adres")]
        public Adres Adres { get; set; }
        [Display(Name = "Sipariş Durumu")]
        public SiparisDurumu SiparisDurumu { get; set; }


        public static List<SiparisUpdateListModel> GetList()
        {
            List<SiparisUpdateListModel> returnList = new List<SiparisUpdateListModel>();
            foreach (var siparis in DbFactory.SiparisCrud.Records)
            {
                SiparisUpdateListModel sulm = new SiparisUpdateListModel();
                sulm.SiparisUpdateListModelID = siparis.ID;
                sulm.Urunler = siparis.Urunler;
                sulm.Adres = siparis.Adres;
                sulm.SiparisDurumu = siparis.SiparisDurumu;

                returnList.Add(sulm);
            }
            return returnList;
        }
    }
}