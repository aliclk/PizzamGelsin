using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class PizzaUpdateListModel
    {
        public string UrunUpdateListModelID { get; set; }
        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }
        [Display(Name = "Ürün Fiyatı")]
        public double UrunFiyat { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string UrunAciklama { get; set; }
        [Display(Name = "Adet")]
        public int UrunAdet { get; set; }
        [Display(Name = "Ürün Resimleri")]
        public List<Resim> UrunResimleri { get; set; }
        [Display(Name = "Ürün Alınma Adedi")]
        public int AlinmaAdedi { get; set; }
        [Display(Name = "Ürün Yıldız")]
        public int Yildiz { get; set; }

        public List<PizzaBoyut> Boyutlar { get; set; }
        public List<KenarTipi> Kenarlar { get; set; }
        public List<HamurTipi> Hamurlar { get; set; }
        public List<Malzeme> Malzemeler { get; set; }

        public static List<PizzaUpdateListModel> GetList()
        {
            List<PizzaUpdateListModel> returnList = new List<PizzaUpdateListModel>();
            foreach (var pizza in DbFactory.PizzaCrud.Records)
            {
                PizzaUpdateListModel pulm = new PizzaUpdateListModel();
                pulm.Boyutlar = pizza.Boyutlar;
                pulm.Hamurlar = pizza.Hamurlar;
                pulm.Kenarlar = pizza.Kenarlar;
                pulm.Malzemeler = pizza.Malzemeler;
                pulm.UrunUpdateListModelID = pizza.ID;
                pulm.UrunAdi = pizza.UrunAdi;
                pulm.UrunFiyat = pizza.UrunFiyat;
                pulm.UrunAciklama = pizza.UrunAciklama;
                pulm.UrunAdet = pizza.UrunAdet;
                pulm.UrunResimleri = pizza.UrunResimleri;
                pulm.AlinmaAdedi = pizza.AlinmaAdedi;
                pulm.Yildiz = pizza.Yildiz;
                returnList.Add(pulm);
            }
            return returnList;
        }
    }
}