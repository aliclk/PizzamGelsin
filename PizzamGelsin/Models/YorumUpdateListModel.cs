using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class YorumUpdateListModel
    {
        public string YorumUpdateListModelID { get; set; }
        [Display(Name = "Ürün")]
        public Urun Urun { get; set; }
        [Display(Name = "Yorum İçeriği")]
        public string YorumIcerigi { get; set; }

        public static List<YorumUpdateListModel> GetList()
        {
            List<YorumUpdateListModel> returnList = new List<YorumUpdateListModel>();
            foreach (var yorum in DbFactory.YorumCrud.Records)
            {
                YorumUpdateListModel yulm = new YorumUpdateListModel();
                yulm.YorumUpdateListModelID = yorum.ID;
                yulm.Urun = yorum.Urun;
                yulm.YorumIcerigi = yorum.YorumIcerigi;

                returnList.Add(yulm);
            }
            return returnList;
        }
    }
}