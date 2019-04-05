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
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Index()
        {
            return View(KullaniciUpdateListModel.GetList());
        }

        // GET: Kullanici/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(KullaniciUpdateListModel.GetList().FirstOrDefault(x => x.KullaniciUpdateListModelID == id));
        }

        // GET: Kullanici/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Kullanici/Create
        [HttpPost]
        public ActionResult Create(KullaniciCreateModel kcm)
        {
            try
            {
                Kullanici kullanici = new Kullanici();
                kullanici.Adi = kcm.Adi;
                //kullanici.Adresler = kcm.Adresler;
                kullanici.Eposta = kcm.Eposta;
                kullanici.Sifre = kcm.Sifre;
                //kullanici.Yorumlar = kcm.Yorumlar;
                //kullanici.Favoriler = kcm.Favoriler;
                //kullanici.GecmisSiparisler = kcm.GecmisSiparisler;
                //kullanici.Sepet = kcm.Sepet;
                kullanici.Telefon = kcm.Telefon;
                kullanici.Soyadi = kcm.Soyadi;
                kullanici.KullaniciTipi = kcm.KullaniciTipi;


                DbFactory.KullaniciCrud.Insert(kullanici);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kullanici/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(KullaniciUpdateListModel.GetList().FirstOrDefault(x => x.KullaniciUpdateListModelID == id));
        }

        // POST: Kullanici/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, KullaniciUpdateListModel kulm)
        {
            try
            {
                Kullanici currentkullanici = DbFactory.KullaniciCrud.Find(id);
                currentkullanici.Adi = kulm.Adi;
                //currentkullanici.Adresler = kulm.Adresler;
                currentkullanici.Eposta = kulm.Eposta;
                currentkullanici.Sifre = kulm.Sifre;
                //currentkullanici.Yorumlar = kulm.Yorumlar;
                //currentkullanici.Favoriler = kulm.Favoriler;
                //currentkullanici.GecmisSiparisler = kulm.GecmisSiparisler;
                //currentkullanici.Sepet = kulm.Sepet;
                currentkullanici.Telefon = kulm.Telefon;
                currentkullanici.Soyadi = kulm.Soyadi;
                currentkullanici.KullaniciTipi = kulm.KullaniciTipi;

                DbFactory.KullaniciCrud.Update(id, currentkullanici);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kullanici/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.KullaniciCrud.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
