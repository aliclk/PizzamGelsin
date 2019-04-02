using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class ResimUpdateListModel
    {
        public string ResimUpdateListModelID { get; set; }
        [Display(Name = "Resim Yolu")]
        public string Url { get; set; }

        public static List<ResimUpdateListModel> GetList()
        {
            List<ResimUpdateListModel> returnList = new List<ResimUpdateListModel>();
            foreach (var resim in DbFactory.ResimCrud.Records)
            {
                ResimUpdateListModel rulm = new ResimUpdateListModel();
                rulm.ResimUpdateListModelID = resim.ID;
                rulm.Url = resim.Url;

                returnList.Add(rulm);
            }
            return returnList;
        }
    }
}