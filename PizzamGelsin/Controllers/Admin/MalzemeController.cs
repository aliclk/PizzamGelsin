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


                string serverPath = Server.MapPath("~/Images/" + Guid.NewGuid().ToString() + ".png");
                malzeme.Resim = new Resim { Url = serverPath };
                var t = DbFactory.MalzemeCrud.Insert(malzeme);
                TempData["sweetalert"] = "<script>swal('Eklendi','Malzeme" + " Eklendi', 'success');" + "</script>";
                file.SaveAs(serverPath);
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
                TempData["sweetalert"] = "<script>swal('Güncellendi','Malzeme" + " Güncellendi', 'success');" + "</script>";

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
            TempData["sweetalert"] = "<script>swal('Silindi','Malzeme" + " Silindi', 'success');" + "</script>";
            return RedirectToAction("Index");
        }

    }
}
