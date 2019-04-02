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
    public class CalisanController : Controller
    {
        // GET: Calisan
        public ActionResult Index()
        {
            return View(CalisanUpdateListModel.GetList());
        }

        // GET: Calisan/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(CalisanUpdateListModel.GetList().FirstOrDefault(x => x.CalisanUpdateListModelID == id));
        }

        // GET: Calisan/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Calisan/Create
        [HttpPost]
        public ActionResult Create(CalisanCreateModel ccm, HttpPostedFileBase file)
        {
            try
            {
                Calisan calisan = new Calisan();
                calisan.Adi = ccm.Adi;
                calisan.Ozgecmis = ccm.Ozgecmis;
                calisan.Unvan = ccm.Unvan;
                
                calisan.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                var t = DbFactory.CalisanCrud.Insert(calisan);
                //file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calisan/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(CalisanUpdateListModel.GetList().FirstOrDefault(x => x.CalisanUpdateListModelID == id));
        }

        // POST: Calisan/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, CalisanUpdateListModel culm)
        {
            try
            {
                Calisan currentcalisan = DbFactory.CalisanCrud.Find(id);
                currentcalisan.Adi = culm.Adi;
                currentcalisan.Ozgecmis = culm.Ozgecmis;
                currentcalisan.Unvan = culm.Unvan; ;
                currentcalisan.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };

                DbFactory.CalisanCrud.Update(id, currentcalisan);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calisan/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.CalisanCrud.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
