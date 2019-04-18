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
    public class PizzaBoyutController : Controller
    {
        // GET: PizzaBoyut
        public ActionResult Index()
        {
            return View(PizzaBoyutUpdateListModel.GetList());
        }

        // GET: PizzaBoyut/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(PizzaBoyutUpdateListModel.GetList().FirstOrDefault(x => x.PizzaBoyutUpdateListModelID == id));
        }

        // GET: PizzaBoyut/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: PizzaBoyut/Create
        [HttpPost]
        public ActionResult Create(PizzaBoyutCreateModel pbcm)
        {
            try
            {
                PizzaBoyut pizzaboyut = new PizzaBoyut();
                pizzaboyut.BoyutAdi = pbcm.BoyutAdi;
                
               
                var t = DbFactory.PizzaBoyutCrud.Insert(pizzaboyut);

                TempData["sweetalert"] = "<script>swal('Eklendi','Pizza Boyutu" + " Eklendi', 'success');" + "</script>";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaBoyut/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(PizzaBoyutUpdateListModel.GetList().FirstOrDefault(x => x.PizzaBoyutUpdateListModelID == id));
        }

        // POST: PizzaBoyut/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, PizzaBoyutUpdateListModel pbulm)
        {
            try
            {
                PizzaBoyut currentpizzaboyut = DbFactory.PizzaBoyutCrud.Find(id);
                currentpizzaboyut.BoyutAdi = pbulm.BoyutAdi;
                

                DbFactory.PizzaBoyutCrud.Update(id, currentpizzaboyut);
                TempData["sweetalert"] = "<script>swal('Güncellendi','Pizza Boyutu" + " Güncellendi', 'success');" + "</script>";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaBoyut/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.PizzaBoyutCrud.Delete(id);
            TempData["sweetalert"] = "<script>swal('Silindi','Pizza Boyutu" + " Silindi', 'success');" + "</script>";
            return RedirectToAction("Index");
        }


    }
}
