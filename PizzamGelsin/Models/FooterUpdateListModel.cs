using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class FooterUpdateListModel
    {
        public string FooterUpdateListModelID { get; set; }
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        [Display(Name = "Adres")]
        public string Adres { get; set; }
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }
        [Display(Name = "E-Mail Adresi")]
        public string EMail { get; set; }
        [Display(Name = "Instagram ")]
        public string InstagramAdres { get; set; }
        [Display(Name = "Facebook ")]
        public string FacebookAdres { get; set; }
        [Display(Name = "Youtube")]
        public string YoutubeAdres { get; set; }
        [Display(Name = "Twitter")]
        public string TwitterAdres { get; set; }
        [Display(Name = "GooglePlus")]
        public string GooglePlusAdres { get; set; }
        [Display(Name = "Pinterest")]
        public string PinterestAdres { get; set; }

        public static List<FooterUpdateListModel> GetList()
        {
            List<FooterUpdateListModel> returnList = new List<FooterUpdateListModel>();
            foreach (Footer footer in DbFactory.FooterCrud.Records)
            {
                FooterUpdateListModel fulm = new FooterUpdateListModel();
                fulm.FooterUpdateListModelID = footer.ID;
                fulm.Aciklama = footer.Aciklama;
                fulm.EMail = footer.EMail;
                fulm.Adres = footer.Adres;
                fulm.FacebookAdres = footer.FacebookAdres;
                fulm.InstagramAdres = footer.InstagramAdres;
                fulm.GooglePlusAdres = footer.GooglePlusAdres;
                fulm.TwitterAdres = footer.TwitterAdres;
                fulm.PinterestAdres = footer.PinterestAdres;
                fulm.YoutubeAdres = footer.YoutubeAdres;
                fulm.Telefon = footer.Telefon;
               
                returnList.Add(fulm);
            }
            return returnList;
        }
    }
}