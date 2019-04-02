using PizzamGelsin.Classes;
using PizzamGelsin.Entities;
using PizzamGelsin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzamGelsin.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            return View(UrunUpdateListModel.GetList());
        }

        // GET: Urun/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(UrunUpdateListModel.GetList().FirstOrDefault(x => x.UrunUpdateListModelID == id));
        }

        // GET: Urun/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Urun/Create
        [HttpPost]
        public ActionResult Create(UrunCreateModel ucm)
        {
            try
            {
                Urun urun = new Urun();
                urun.UrunAdi = ucm.UrunAdi;
                urun.UrunAciklama = ucm.UrunAciklama;
                urun.UrunFiyat = ucm.UrunFiyat;
                urun.AlinmaAdedi = ucm.AlinmaAdedi;
                urun.Yildiz = ucm.Yildiz;
                //urun.UrunResimleri = ucm.UrunResimleri;
                urun.UrunAdet = ucm.UrunAdet;
                var t = DbFactory.UrunCrud.Insert(urun);
                //file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Urun/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(UrunUpdateListModel.GetList().FirstOrDefault(x => x.UrunUpdateListModelID == id));
        }

        // POST: Urun/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, UrunUpdateListModel uulm)
        {
            try
            {
                Urun currenturun = DbFactory.UrunCrud.Find(id);
                currenturun.UrunAdi = uulm.UrunAdi;
                currenturun.UrunAciklama = uulm.UrunAciklama;
                currenturun.UrunFiyat = uulm.UrunFiyat;
                currenturun.AlinmaAdedi = uulm.AlinmaAdedi;
                currenturun.Yildiz = uulm.Yildiz;
                currenturun.UrunResimleri = uulm.UrunResimleri;
                currenturun.UrunAdet = uulm.UrunAdet;

                DbFactory.UrunCrud.Update(id, currenturun);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Urun/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.UrunCrud.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
