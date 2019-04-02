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
    public class MalzemeController : Controller
    {
        // GET: Malzeme
        public ActionResult Index()
        {
            return View(MalzemeUpdateListModel.GetList());
        }

        // GET: Malzeme/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(MalzemeUpdateListModel.GetList().FirstOrDefault(x=>x.MalzemeUpdateListModelID
            == id));
        }

        // GET: Malzeme/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Malzeme/Create
        [HttpPost]
        public ActionResult Create(MalzemeCreateModel mcm, HttpPostedFileBase file)
        {
            try
            {
                Malzeme malzeme = new Malzeme();
                malzeme.EkFiyat = mcm.EkFiyat;
                malzeme.MalzemeAdi = mcm.MalzemeAdi;
                
                

                malzeme.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                var t = DbFactory.MalzemeCrud.Insert(malzeme);
                //file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Malzeme/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(MalzemeUpdateListModel.GetList().FirstOrDefault(x => x.MalzemeUpdateListModelID == id));
        }

        // POST: Malzeme/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, MalzemeUpdateListModel mulm)
        {
            try
            {
                Malzeme currentmalzeme = DbFactory.MalzemeCrud.Find(id);
                currentmalzeme.EkFiyat = mulm.EkFiyat;
                currentmalzeme.MalzemeAdi = mulm.MalzemeAdi;
                currentmalzeme.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };

                DbFactory.MalzemeCrud.Update(id, currentmalzeme);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Malzeme/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.MalzemeCrud.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
