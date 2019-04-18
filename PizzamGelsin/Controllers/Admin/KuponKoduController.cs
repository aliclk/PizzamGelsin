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
    public class KuponKoduController : Controller
    {
        // GET: KuponKodu
        public ActionResult Index()
        {
            return View(KuponKoduUpdateListModel.GetList());
        }

        // GET: KuponKodu/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(KuponKoduUpdateListModel.GetList().FirstOrDefault(x => x.KuponKoduUpdateListModelID == id));
        }

        // GET: KuponKodu/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: KuponKodu/Create
        [HttpPost]
        public ActionResult Create(KuponKoduCreateModel kkcm)
        {
            try
            {
                KuponKodu kuponkodu = new KuponKodu();
                kuponkodu.IndirimTuru = kkcm.IndirimTuru;
                kuponkodu.KuponKod = kkcm.KuponKod;
                kuponkodu.Value = kkcm.Value;
                var t = DbFactory.KuponKoduCrud.Insert(kuponkodu);
                TempData["sweetalert"] = "<script>swal('Eklendi','Kupon Kodu" + " Eklendi', 'success');" + "</script>";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KuponKodu/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(KuponKoduUpdateListModel.GetList().FirstOrDefault(x => x.KuponKoduUpdateListModelID == id));
        }

        // POST: KuponKodu/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, KuponKoduUpdateListModel kkulm)
        {
            try
            {
                KuponKodu currentkuponkodu = DbFactory.KuponKoduCrud.Find(id);
                currentkuponkodu.IndirimTuru = kkulm.IndirimTuru;
                currentkuponkodu.KuponKod = kkulm.KuponKod;
                currentkuponkodu.Value = kkulm.Value;

                DbFactory.KuponKoduCrud.Update(id, currentkuponkodu);
                TempData["sweetalert"] = "<script>swal('Güncellendi','Kupon Kodu" + " Güncellendi', 'success');" + "</script>";
                return RedirectToAction("Index"); ;
            }
            catch
            {
                return View();
            }
        }

        // GET: KuponKodu/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.KuponKoduCrud.Delete(id);
            TempData["sweetalert"] = "<script>swal('Silindi','Kupon Kodu" + " Silindi', 'success');" + "</script>";
            return RedirectToAction("Index");
        }

    }
}
