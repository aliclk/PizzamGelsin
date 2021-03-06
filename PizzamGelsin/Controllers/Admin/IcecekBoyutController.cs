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
    public class IcecekBoyutController : Controller
    {
        // GET: IcecekBoyut
        public ActionResult Index()
        {
            return View(IcecekBoyutUpdateListModel.GetList());
        }

        // GET: IcecekBoyut/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(IcecekBoyutUpdateListModel.GetList().FirstOrDefault(x => x.IcecekBoyutUpdateListModelID == id));
        }

        // GET: IcecekBoyut/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: IcecekBoyut/Create
        [HttpPost]
        public ActionResult Create(IcecekBoyutCreateModel ibcm, HttpPostedFileBase file)
        {
            try
            {
                IcecekBoyut icecekBoyut = new IcecekBoyut();
                icecekBoyut.Boyut = ibcm.Boyut;
                string serverPath = Server.MapPath("~/Images/" + Guid.NewGuid().ToString() + ".png");
                icecekBoyut.Resim = new Resim { Url = serverPath };
                var t = DbFactory.IcecekBoyutCrud.Insert(icecekBoyut);
                TempData["sweetalert"] = "<script>swal('Eklendi','İçeçek Boyutu" + " Eklendi', 'success');" + "</script>";
                file.SaveAs(serverPath);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: IcecekBoyut/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(IcecekBoyutUpdateListModel.GetList().FirstOrDefault(x => x.IcecekBoyutUpdateListModelID == id));
        }

        // POST: IcecekBoyut/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, IcecekBoyutUpdateListModel ibulm)
        {
            try
            {
                IcecekBoyut currenticecekBoyut = DbFactory.IcecekBoyutCrud.Find(id);
                currenticecekBoyut.Boyut = ibulm.Boyut;

                //currenticecekBoyut.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                TempData["sweetalert"] = "<script>swal('Güncellendi','İçecek Boyutu" + " Güncellendi', 'success');" + "</script>";
                DbFactory.IcecekBoyutCrud.Update(id, currenticecekBoyut);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: IcecekBoyut/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.IcecekBoyutCrud.Delete(id);
            TempData["sweetalert"] = "<script>swal('Silindi','İçecek Boyutu" + " Silindi', 'success');" + "</script>";
            return RedirectToAction("Index");
        }

    }
}
