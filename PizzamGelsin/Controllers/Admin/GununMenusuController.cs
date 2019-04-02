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
    public class GununMenusuController : Controller
    {
        // GET: GununMenusu
        public ActionResult Index()
        {
            return View(GununMenusuUpdateListModel.GetList());
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

        // POST: GununMenusu/Create
        [HttpPost]
        public ActionResult Create(GununMenusuCreateModel gmcl)
        {
            try
            {
                GununMenusu gununmenusu = new GununMenusu();
                gununmenusu.Tarih = gmcl.Tarih;
                gununmenusu.Urunler = gmcl.Urunler;
                
                var t = DbFactory.GununMenusuCrud.Insert(gununmenusu);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
