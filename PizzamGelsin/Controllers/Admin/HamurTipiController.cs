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
    public class HamurTipiController : Controller
    {
        // GET: HamurTipi
        public ActionResult Index()
        {
            return View(HamurTipiUpdateListModel.GetList());
        }

        // GET: HamurTipi/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(HamurTipiUpdateListModel.GetList().FirstOrDefault(x=>x.HamurTipiUpdateListModelID==id));
        }

        // GET: HamurTipi/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: HamurTipi/Create
        [HttpPost]
        public ActionResult Create(HamurTipiCreateModel htcm,HttpPostedFileBase file)
        {
            try
            {
                HamurTipi hamurtipi = new HamurTipi();
                hamurtipi.HamurAdi = htcm.HamurAdi;
                hamurtipi.EkFiyat = htcm.EkFiyat;
                hamurtipi.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                var t = DbFactory.HamurTipiCrud.Insert(hamurtipi);
                file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HamurTipi/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(HamurTipiUpdateListModel.GetList().FirstOrDefault(x => x.HamurTipiUpdateListModelID == id));
        }

        // POST: HamurTipi/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, HamurTipiUpdateListModel htumlm)
        {
            try
            {
                HamurTipi currenthamurtipi = DbFactory.HamurTipiCrud.Find(id);
                currenthamurtipi.HamurAdi = htumlm.HamurAdi;
                currenthamurtipi.EkFiyat = htumlm.EkFiyat;
                currenthamurtipi.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                
                DbFactory.HamurTipiCrud.Update(id, currenthamurtipi);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HamurTipi/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.HamurTipiCrud.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
