using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class ReklamUpdateListModel
    {
        public string ReklamUpdateListModelID { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimURL { get; set; }
        [Display(Name = "Reklam Linki")]
        public string ReklamLink { get; set; }

        public static List<ReklamUpdateListModel> GetList()
        {
            List<ReklamUpdateListModel> returnList = new List<ReklamUpdateListModel>();
            foreach (var reklam in DbFactory.ReklamCrud.Records)
            {
                ReklamUpdateListModel rulm = new ReklamUpdateListModel();
                rulm.ReklamUpdateListModelID = reklam.ID;
                rulm.ResimURL = reklam.Resim.Url;
                rulm.ReklamLink = reklam.ReklamLink;
                

                returnList.Add(rulm);
            }
            return returnList;
        }
    }
}