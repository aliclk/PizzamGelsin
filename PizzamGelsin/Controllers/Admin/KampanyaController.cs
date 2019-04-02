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
    public class KampanyaController : Controller
    {
        // GET: Kampanya
        public ActionResult Index()
        {
            return View(KampanyaUpdateListModel.GetList());
        }

        // GET: Kampanya/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(KampanyaUpdateListModel.GetList().FirstOrDefault(x => x.KampanyaUpdateListModelID == id));
        }

        // GET: Kampanya/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Kampanya/Create
        [HttpPost]
        public ActionResult Create(KampanyaCreateModel kcm)
        {
            try
            {
                Kampanya kampanya = new Kampanya();
                kampanya.Fiyat = kcm.Fiyat;
                kampanya.KampanyaAdi = kcm.KampanyaAdi;
                kampanya.Urunler = kcm.Urunler;
                DbFactory.KampanyaCrud.Insert(kampanya);               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kampanya/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(KampanyaUpdateListModel.GetList().FirstOrDefault(x => x.KampanyaUpdateListModelID == id));
        }

        // POST: Kampanya/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, KampanyaUpdateListModel kulm)
        {
            try
            {

                Kampanya currentkampanya = DbFactory.KampanyaCrud.Find(id);
                currentkampanya.Fiyat = kulm.Fiyat;
                currentkampanya.KampanyaAdi = kulm.KampanyaAdi;
                currentkampanya.Urunler = kulm.Urunler;

                DbFactory.KampanyaCrud.Update(id, currentkampanya);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kampanya/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.KampanyaCrud.Delete(id);
            return RedirectToAction("Index");
        }
  
    }
}
