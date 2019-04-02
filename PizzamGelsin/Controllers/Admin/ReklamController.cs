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
    public class ReklamController : Controller
    {
        // GET: Reklam
        public ActionResult Index()
        {
            return View(ReklamUpdateListModel.GetList());
        }

        // GET: Reklam/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(ReklamUpdateListModel.GetList().FirstOrDefault(x => x.ReklamUpdateListModelID == id));
        }

        // GET: Reklam/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Reklam/Create
        [HttpPost]
        public ActionResult Create(ReklamCreateModel rcm, HttpPostedFileBase file)
        {
            try
            {
                Reklam reklam = new Reklam();
                reklam.ReklamLink = rcm.ReklamLink;

                reklam.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                var t = DbFactory.ReklamCrud.Insert(reklam);
               // file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reklam/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(ReklamUpdateListModel.GetList().FirstOrDefault(x => x.ReklamUpdateListModelID == id));
        }

        // POST: Reklam/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, ReklamUpdateListModel rulm)
        {
            try
            {
                Reklam currentreklam = new Reklam();
                currentreklam.ReklamLink = rulm.ReklamLink;

                currentreklam.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                var t = DbFactory.ReklamCrud.Insert(currentreklam);
                // file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reklam/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.ReklamCrud.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
