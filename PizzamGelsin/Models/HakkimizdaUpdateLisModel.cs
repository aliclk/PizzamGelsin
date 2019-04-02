using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class HakkimizdaUpdateLisModel
    {
        public string HakkimizdaUpdateLisModelID { get; set; }
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }
        [Display(Name = "İçerik")]
        public string Icerik { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimUrl { get; set; }

        public static List<HakkimizdaUpdateLisModel> GetList()
        {
            List<HakkimizdaUpdateLisModel> returnList = new List<HakkimizdaUpdateLisModel>();
            foreach (var hakkimizda in DbFactory.HakkimizdaCrud.Records)
            {
                HakkimizdaUpdateLisModel hulm = new HakkimizdaUpdateLisModel();
                hulm.HakkimizdaUpdateLisModelID = hakkimizda.ID;
                hulm.Baslik = hakkimizda.Baslik;
                hulm.Icerik = hakkimizda.Icerik;
                hulm.ResimUrl = hakkimizda.Resim.Url;

                returnList.Add(hulm);
            }
            return returnList;
        }
    }
}