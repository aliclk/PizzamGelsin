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
    public class SiparisController : Controller
    {
        // GET: Siparis
        public ActionResult Index()
        {
            return View(SiparisUpdateListModel.GetList());
        }

        // GET: Siparis/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(SiparisUpdateListModel.GetList().FirstOrDefault(x => x.SiparisUpdateListModelID == id));
        }

        // GET: Siparis/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Siparis/Create
        [HttpPost]
        public ActionResult Create(SiparisCreateModel scm)
        {
            try
            {
                Siparis siparis = new Siparis();
                siparis.Adres = scm.Adres;
                siparis.SiparisDurumu = scm.SiparisDurumu;
                siparis.Urunler = scm.Urunler;
                DbFactory.SiparisCrud.Insert(siparis);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Siparis/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(SiparisUpdateListModel.GetList().FirstOrDefault(x => x.SiparisUpdateListModelID == id));
        }

        // POST: Siparis/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, SiparisUpdateListModel sulm)
        {
            try
            {
                Siparis currentsiparis = DbFactory.SiparisCrud.Find(id);
                currentsiparis.Adres = sulm.Adres;
                currentsiparis.SiparisDurumu = sulm.SiparisDurumu;
                currentsiparis.Urunler = sulm.Urunler;

                DbFactory.SiparisCrud.Update(id, currentsiparis);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Siparis/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.SiparisCrud.Delete(id);
            return RedirectToAction("Index");
        }
	  
    }
}
