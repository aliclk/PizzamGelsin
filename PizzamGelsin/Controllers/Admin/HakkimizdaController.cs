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
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        public ActionResult Index()
        {
            return View(HakkimizdaUpdateLisModel.GetList());
        }

        // GET: Hakkimizda/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(HakkimizdaUpdateLisModel.GetList().FirstOrDefault(x => x.HakkimizdaUpdateLisModelID == id));
        }

        // GET: Hakkimizda/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Hakkimizda/Create
        [HttpPost]
        public ActionResult Create(HakkimizdaCreateModel hcm, HttpPostedFileBase file)
        {
            try
            {
                Hakkimizda hakkimizda = new Hakkimizda();
                hakkimizda.Baslik = hcm.Baslik;
                hakkimizda.Icerik = hcm.Icerik;
                
                
                hakkimizda.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                var t = DbFactory.HakkimizdaCrud.Insert(hakkimizda);
                //file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hakkimizda/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(HakkimizdaUpdateLisModel.GetList().FirstOrDefault(x => x.HakkimizdaUpdateLisModelID == id));
        }

        // POST: Hakkimizda/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, HakkimizdaUpdateLisModel hulm)
        {
            try
            {
                Hakkimizda currenthakkimizda = DbFactory.HakkimizdaCrud.Find(id);
                currenthakkimizda.Baslik = hulm.Baslik;
                currenthakkimizda.Icerik = hulm.Icerik;
                currenthakkimizda.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };

                DbFactory.HakkimizdaCrud.Update(id, currenthakkimizda);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hakkimizda/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.HakkimizdaCrud.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
