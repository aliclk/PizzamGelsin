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
    public class AdresController : Controller
    {
        // GET: Adres
        public ActionResult Index()
        {
            return View(AdresUpdateListModel.GetList());
        }

        // GET: Adres/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(AdresUpdateListModel.GetList().FirstOrDefault(x => x.AdresUpdateListModelID == id));
        }

        // GET: Adres/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Adres/Create
        [HttpPost]
        public ActionResult Create(AdresCreateModel acm)
        {
            try
            {
                Adres adres = new Adres();
                adres.Adi = acm.Adi;
                adres.AdresIcerik = acm.AdresIcerik;
                var t=DbFactory.AdresCrud.Insert(adres);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Adres/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(AdresUpdateListModel.GetList().FirstOrDefault(x => x.AdresUpdateListModelID == id));
        }

        // POST: Adres/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, AdresUpdateListModel aulm)
        {
            try
            {
                Adres currentadres = DbFactory.AdresCrud.Find(id);
                currentadres.Adi = aulm.Adi;
                currentadres.AdresIcerik = aulm.AdresIcerik;
                
                DbFactory.AdresCrud.Update(id, currentadres);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Adres/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.AdresCrud.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
