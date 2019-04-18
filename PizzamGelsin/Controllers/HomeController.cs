using PizzamGelsin.Classes;
using PizzamGelsin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzamGelsin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Urunler()
        {
            return View(UrunUpdateListModel.Getlist());
        }
        public ActionResult Product(string id)
        {
            return View(UrunUpdateListModel.Getlist().FirstOrDefault(x=>x.UrunUpdateListModelID==id));
        }
        [HttpPost]
        public ActionResult SepeteEkle(CartModel cartModel)
        {
            return RedirectToAction("Cart");
        }
        public ActionResult Cart()
        {
            CartModel cm = new CartModel();
            cm.PizzaId = DbFactory.PizzaCrud.Records.First().ID;
            cm.Adet = 3;
            List<CartModel> cmlist = new List<CartModel>();
            cmlist.Add(cm);
            cmlist.Add(cm);
            cmlist.Add(cm);
            cmlist.Add(cm);
            cmlist.Add(cm);
            cmlist.Add(cm);
            return View(cmlist);
        }
    }
}