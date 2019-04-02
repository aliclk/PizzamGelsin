using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class IcecekBoyutUpdateListModel
    {
        public string IcecekBoyutUpdateListModelID { get; set; }
        [Display(Name = "İçecek Boyutu")]
        public string Boyut { get; set; }
        [Display(Name = "Resim Yolu")]
        public string ResimUrl { get; set; }

        public static List<IcecekBoyutUpdateListModel> GetList()
        {
            List<IcecekBoyutUpdateListModel> returnList = new List<IcecekBoyutUpdateListModel>();
            foreach (var icecekboyut in DbFactory.IcecekBoyutCrud.Records)
            {
                IcecekBoyutUpdateListModel ibulm = new IcecekBoyutUpdateListModel();
                ibulm.IcecekBoyutUpdateListModelID = icecekboyut.ID;
                ibulm.Boyut = icecekboyut.Boyut;
                ibulm.ResimUrl = icecekboyut.Resim.Url;

                returnList.Add(ibulm);
            }
            return returnList;
        }
    }
}