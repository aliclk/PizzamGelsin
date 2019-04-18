using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using PizzamGelsin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzamGelsin.Controllers.Admin
{
    public class FooterController : Controller
    {
        // GET: Footer
        public ActionResult Index()
        {
            return View(FooterUpdateListModel.GetList());
        }

        // GET: Footer/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(FooterUpdateListModel.GetList().FirstOrDefault(x => x.FooterUpdateListModelID == id));
        }

        // GET: Footer/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Footer/Create
        [HttpPost]
        public ActionResult Create(FooterCreateModel fcm)
        {
            try
            {
                Footer footer = new Footer();
                
                footer.Aciklama = fcm.Aciklama;
                footer.EMail = fcm.EMail;
                footer.Adres = fcm.Adres;
                footer.FacebookAdres = fcm.FacebookAdres;
                footer.InstagramAdres = fcm.InstagramAdres;
                footer.GooglePlusAdres = fcm.GooglePlusAdres;
                footer.TwitterAdres = fcm.TwitterAdres;
                footer.PinterestAdres = fcm.PinterestAdres;
                footer.YoutubeAdres = fcm.YoutubeAdres;
                footer.Telefon = fcm.Telefon;
                
                
                var t = DbFactory.FooterCrud.Insert(footer);
                TempData["sweetalert"] = "<script>swal('Eklendi','Footer" + " Eklendi', 'success');" + "</script>";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Footer/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(FooterUpdateListModel.GetList().FirstOrDefault(x => x.FooterUpdateListModelID == id));
        }

        // POST: Footer/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FooterUpdateListModel fulm)
        {
            try
            {
                Footer currentfooter = DbFactory.FooterCrud.Find(id);
                currentfooter.ID = id;
                currentfooter.Aciklama = fulm.Aciklama;
                currentfooter.EMail = fulm.EMail;
                currentfooter.Adres = fulm.Adres;
                currentfooter.FacebookAdres = fulm.FacebookAdres;
                currentfooter.InstagramAdres = fulm.InstagramAdres;
                currentfooter.GooglePlusAdres = fulm.GooglePlusAdres;
                currentfooter.TwitterAdres = fulm.TwitterAdres;
                currentfooter.PinterestAdres = fulm.PinterestAdres;
                currentfooter.YoutubeAdres = fulm.YoutubeAdres;
                currentfooter.Telefon = fulm.Telefon;

                var isok=  DbFactory.FooterCrud.Update(id, currentfooter);
                TempData["sweetalert"] = "<script>swal('Güncellendi','Çalışan" + " Güncellendi', 'success');" + "</script>";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Footer/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.FooterCrud.Delete(id);
            TempData["sweetalert"] = "<script>swal('Silindi','Çalışan" + " Silindi', 'success');" + "</script>";
            return RedirectToAction("Index");
        }

        
    }
}
