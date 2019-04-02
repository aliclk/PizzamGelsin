
using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class AdminPanelMenuUpdateListModel
    {
        public string AdminPanelMenuUpdateListModelID { get; set; }
        [Display(Name = "Adı")]
        public string Adi { get; set; }
        [Display(Name = "Resim Yolu")]
        public string Url { get; set; }

        public static List<AdminPanelMenuUpdateListModel> GetList()
        {
            List<AdminPanelMenuUpdateListModel> returnList = new List<AdminPanelMenuUpdateListModel>();
            foreach (AdminPanelMenu adminpanelmenu in DbFactory.AdminPanelMenuCrud.Records)
            {
                AdminPanelMenuUpdateListModel apm = new AdminPanelMenuUpdateListModel();
                apm.AdminPanelMenuUpdateListModelID = adminpanelmenu.ID;
                apm.Adi = adminpanelmenu.Adi;

                returnList.Add(apm);
            }
            return returnList;
        }
    }
}