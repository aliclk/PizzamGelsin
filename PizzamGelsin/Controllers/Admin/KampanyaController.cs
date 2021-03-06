﻿using PizzamGelsin.Classes;
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
                kampanya.Pizza = DbFactory.PizzaCrud.Records.FirstOrDefault(x=>x.UrunAdi==kcm.Pizza.UrunAdi);
                kampanya.Icecek = DbFactory.IcecekCrud.Records.FirstOrDefault(x => x.UrunAdi == kcm.Icecek.UrunAdi);
                TempData["sweetalert"] = "<script>swal('Eklendi','Kampanya" + " Eklendi', 'success');" + "</script>";
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
                currentkampanya.Pizza = kulm.Pizza;
                currentkampanya.Icecek = kulm.Icecek;

                DbFactory.KampanyaCrud.Update(id, currentkampanya);
                TempData["sweetalert"] = "<script>swal('Güncellendi','Kampanya" + " Güncellendi', 'success');" + "</script>";

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
            TempData["sweetalert"] = "<script>swal('Silindi','Kampanya" + " Silindi', 'success');" + "</script>";
            return RedirectToAction("Index");
        }
  
    }
}
