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
    public class ResimController : Controller
    {
        // GET: Resim
        public ActionResult Index()
        {
            return View(ResimUpdateListModel.GetList());
        }

        // GET: Resim/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(ResimUpdateListModel.GetList().FirstOrDefault(x => x.ResimUpdateListModelID == id));
        }

        // GET: Resim/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Resim/Create
        [HttpPost]
        public ActionResult Create(ResimCreateModel rcm)
        {
            try
            {
                Resim resim = new Resim();

                resim.Url = rcm.Url;
                    
                var t = DbFactory.ResimCrud.Insert(resim);
               // file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Resim/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(ResimUpdateListModel.GetList().FirstOrDefault(x => x.ResimUpdateListModelID == id));
        }

        // POST: Resim/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, ResimUpdateListModel rulm)
        {
            try
            {
                Resim currentresim = new Resim();

                currentresim.Url = rulm.Url;

                DbFactory.ResimCrud.Update(id, currentresim);
                // file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Resim/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.ResimCrud.Delete(id);
            return RedirectToAction("Index");
        }
 
    }
}
