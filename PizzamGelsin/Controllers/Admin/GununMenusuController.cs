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
    public class GununMenusuController : Controller
    {
        // GET: GununMenusu
        public ActionResult Index()
        {
            Session["CurrentMenuUrunler"] = new List<Urun>();
            return View(GununMenusuUpdateListModel.GetList());
        }
        [HttpPost]
        public void UrunEkle(string urunAdi)
        {
           var currentUrunler = Session["CurrentMenuUrunler"] as List<Urun>;
            Pizza veriTabanındanPizza = DbFactory.PizzaCrud.Records.FirstOrDefault(x => x.UrunAdi == urunAdi);

            Pizza pizza = new Pizza();
            pizza.UrunAdi = urunAdi;
            pizza.UrunAciklama = veriTabanındanPizza.UrunAciklama;
            pizza.UrunFiyat = veriTabanındanPizza.UrunFiyat;
            currentUrunler.Add(pizza);
            Session["CurrentMenuUrunler"] = currentUrunler;
        }

        [HttpPost]
        public void UrunSil(string id)
        {
            var currentUrunler = Session["CurrentMenuUrunler"] as List<Urun>;
            currentUrunler.RemoveAll(x => x.ID == id);
            Session["CurrentMenuUrunler"] = currentUrunler;
        }
        // GET: GununMenusu/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(GununMenusuUpdateListModel.GetList().FirstOrDefault(x => x.GununMenusuUpdateListModelID == id));
        }

        // GET: GununMenusu/Create
        public ActionResult Create()
        {
            return PartialView();
        }
        public PartialViewResult UrunGuncellePartial()
        {
            return PartialView();
        }
        // POST: GununMenusu/Create
        [HttpPost]
        public ActionResult Create(GununMenusuCreateModel gmcl)
        {
              var currentUrunler = Session["CurrentMenuUrunler"] as List<Urun>;

                GununMenusu gununmenusu = new GununMenusu();
                gununmenusu.Tarih = gmcl.Tarih;
                gununmenusu.Urunler = currentUrunler;

                PizzaContext ctx = new PizzaContext();
                ctx.GununMenusu.Add(gununmenusu);
                ctx.SaveChanges();
               // var t = DbFactory.GununMenusuCrud.Insert(gununmenusu);
                
                return RedirectToAction("Index");
          
        }

        // GET: GununMenusu/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(GununMenusuUpdateListModel.GetList().FirstOrDefault(x => x.GununMenusuUpdateListModelID == id));
        }

        // POST: GununMenusu/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, GununMenusuUpdateListModel gmulm)
        {
            try
            {
                GununMenusu currentgununmenusu = DbFactory.GununMenusuCrud.Find(id);
                currentgununmenusu.Urunler = gmulm.Urunler;
                currentgununmenusu.Tarih = gmulm.Tarih;
                

                DbFactory.GununMenusuCrud.Update(id, currentgununmenusu);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GununMenusu/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.GununMenusuCrud.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
