using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class WebSiteUpdateListModel
    {
        public string WebSiteUpdateListModelID { get; set; }
        [Display(Name = "Logo Url")]
        public string LogoUrl { get; set; }
        [Display(Name = "Web Site Adı")]
        public string WebAdi { get; set; }

        public static List<WebSiteUpdateListModel> GetList()
        {
            List<WebSiteUpdateListModel> returnList = new List<WebSiteUpdateListModel>();
            foreach (var website in DbFactory.WebSiteCrud.Records)
            {
                WebSiteUpdateListModel wbulm = new WebSiteUpdateListModel();
                wbulm.WebSiteUpdateListModelID = website.ID;
                wbulm.LogoUrl = website.Logo.Url;
                wbulm.WebAdi = website.WebAdi;

                returnList.Add(wbulm);
            }
            return returnList;
        }
    }
}