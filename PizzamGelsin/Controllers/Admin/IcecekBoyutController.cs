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
    public class IcecekBoyutController : Controller
    {
        // GET: IcecekBoyut
        public ActionResult Index()
        {
            return View(IcecekBoyutUpdateListModel.GetList());
        }

        // GET: IcecekBoyut/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(IcecekBoyutUpdateListModel.GetList().FirstOrDefault(x => x.IcecekBoyutUpdateListModelID == id));
        }

        // GET: IcecekBoyut/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: IcecekBoyut/Create
        [HttpPost]
        public ActionResult Create(IcecekBoyutCreateModel ibcm, HttpPostedFileBase file)
        {
            try
            {
                IcecekBoyut icecekBoyut = new IcecekBoyut();
                icecekBoyut.Boyut = ibcm.Boyut;
                
                icecekBoyut.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };
                var t = DbFactory.IcecekBoyutCrud.Insert(icecekBoyut);
                //file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: IcecekBoyut/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(IcecekBoyutUpdateListModel.GetList().FirstOrDefault(x => x.IcecekBoyutUpdateListModelID == id));
        }

        // POST: IcecekBoyut/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, IcecekBoyutUpdateListModel ibulm)
        {
            try
            {
                IcecekBoyut currenticecekBoyut = DbFactory.IcecekBoyutCrud.Find(id);
                currenticecekBoyut.Boyut = ibulm.Boyut;
               
                //currenticecekBoyut.Resim = new Resim { Url = Server.MapPath("~/classes/m.jpg") };

                DbFactory.IcecekBoyutCrud.Update(id, currenticecekBoyut);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: IcecekBoyut/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.IcecekBoyutCrud.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
