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
    public class YorumController : Controller
    {
        // GET: Yorum
        public ActionResult Index()
        {
            return View(YorumUpdateListModel.GetList());
        }

        // GET: Yorum/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(YorumUpdateListModel.GetList().FirstOrDefault(x => x.YorumUpdateListModelID == id));
        }

        // GET: Yorum/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Yorum/Create
        [HttpPost]
        public ActionResult Create(YorumCreateModel ycm)
        {
            try
            {
                Yorum yorum = new Yorum();
                yorum.Urun = ycm.Urun;
                yorum.YorumIcerigi = ycm.YorumIcerigi;
                
                var t = DbFactory.YorumCrud.Insert(yorum);
            
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Yorum/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(YorumUpdateListModel.GetList().FirstOrDefault(x => x.YorumUpdateListModelID == id));
        }

        // POST: Yorum/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, YorumUpdateListModel yulm)
        {
            try
            {
                Yorum currentyorum = DbFactory.YorumCrud.Find(id);
                currentyorum.Urun = yulm.Urun;
                currentyorum.YorumIcerigi = yulm.YorumIcerigi;
                
                DbFactory.YorumCrud.Update(id, currentyorum);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Yorum/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.YorumCrud.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
