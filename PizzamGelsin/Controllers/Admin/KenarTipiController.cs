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
    public class KenarTipiController : Controller
    {
        // GET: KenarTipi
        public ActionResult Index()
        {
            return View(KenarTipiUpdateListModel.GetList());
        }

        // GET: KenarTipi/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(KenarTipiUpdateListModel.GetList().FirstOrDefault(x => x.KenarTipiUpdateListModelID == id));
        }

        // GET: KenarTipi/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: KenarTipi/Create
        [HttpPost]
        public ActionResult Create(KenarTipiCreateModel ktcm, HttpPostedFileBase file)
        {
            try
            {
                KenarTipi kenartipi = new KenarTipi();
                kenartipi.KenarAdi = ktcm.KenarAdi;
                kenartipi.EkFiyat = ktcm.EkFiyat;
                kenartipi.KenarResim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                DbFactory.KenarTipi.Insert(kenartipi);
                //file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KenarTipi/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(KenarTipiUpdateListModel.GetList().FirstOrDefault(x => x.KenarTipiUpdateListModelID == id));
        }

        // POST: KenarTipi/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, KenarTipiUpdateListModel ktulm)
        {
            try
            {
                KenarTipi currentkenartipi = DbFactory.KenarTipi.Find(id);
                currentkenartipi.KenarAdi = ktulm.KenarAdi;
                currentkenartipi.EkFiyat = ktulm.EkFiyat;
                currentkenartipi.KenarResim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };

                DbFactory.KenarTipi.Update(id, currentkenartipi);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KenarTipi/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }
    }
}
