using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using PizzamGelsin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class IcecekUpdateListModel:UrunUpdateListModel
    {
        public string IcecekUpdateListModelId { get; set; }
        public List<IcecekBoyut> Icecekboyutlar { get; set; }

        public static List<IcecekUpdateListModel> GetList()
        {
            List<IcecekUpdateListModel> returnList = new List<IcecekUpdateListModel>();
            foreach (var icecek in DbFactory.IcecekCrud.Records)
            {
                IcecekUpdateListModel iulm = new IcecekUpdateListModel();
                iulm.Icecekboyutlar = icecek.Icecekboyutlar;
            
                iulm.UrunUpdateListModelID = icecek.ID;
                iulm.UrunAdi = icecek.UrunAdi;
                iulm.UrunFiyat = icecek.UrunFiyat;
                iulm.UrunAciklama = icecek.UrunAciklama;
                iulm.UrunAdet = icecek.UrunAdet;
                iulm.UrunResimleri = icecek.UrunResimleri;
                iulm.AlinmaAdedi = icecek.AlinmaAdedi;
                iulm.Yildiz = icecek.Yildiz;
                returnList.Add(iulm);
            }
            return returnList;
        }
    }
}