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
    public class WebSiteController : Controller
    {
        // GET: WebSite
        public ActionResult Index()
        {
            return View(WebSiteUpdateListModel.GetList());
        }

        // GET: WebSite/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(WebSiteUpdateListModel.GetList().FirstOrDefault(x => x.WebSiteUpdateListModelID == id));
        }

        // GET: WebSite/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: WebSite/Create
        [HttpPost]
        public ActionResult Create(WebSiteCreateModel wscm, HttpPostedFileBase file)
        {
            try
            {
                WebSite website = new WebSite();
                website.WebAdi = wscm.WebAdi;
                string serverPath = Server.MapPath("~/Images/" + Guid.NewGuid().ToString() + ".png");
                website.Logo = new Resim { Url = serverPath };
                DbFactory.WebSiteCrud.Insert(website);
              file.SaveAs(serverPath);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WebSite/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(WebSiteUpdateListModel.GetList().FirstOrDefault(x => x.WebSiteUpdateListModelID == id));
        }

        // POST: WebSite/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, WebSiteUpdateListModel wbulm)
        {
            try
            {
                WebSite currentwebsite = DbFactory.WebSiteCrud.Find(id);
                currentwebsite.WebAdi = wbulm.WebAdi;
                //currentwebsite.Logo.Url = wbulm.LogoUrl;
                currentwebsite.Logo = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
               

                DbFactory.WebSiteCrud.Update(id, currentwebsite);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WebSite/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.WebSiteCrud.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
