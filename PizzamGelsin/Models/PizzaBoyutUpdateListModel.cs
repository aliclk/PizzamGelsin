using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class PizzaBoyutUpdateListModel
    {
        public string PizzaBoyutUpdateListModelID { get; set; }
        [Display(Name = "Pizza Boyut Adı")]
        public string BoyutAdi { get; set; }

        public static List<PizzaBoyutUpdateListModel> GetList()
        {
            List<PizzaBoyutUpdateListModel> returnList = new List<PizzaBoyutUpdateListModel>();
            foreach (var pizzaboy in DbFactory.PizzaBoyutCrud.Records)
            {
                PizzaBoyutUpdateListModel pbulm = new PizzaBoyutUpdateListModel();
                pbulm.PizzaBoyutUpdateListModelID = pizzaboy.ID;
                pbulm.BoyutAdi = pizzaboy.BoyutAdi;
                
               

                returnList.Add(pbulm);
            }
            return returnList;
        }
    }
}