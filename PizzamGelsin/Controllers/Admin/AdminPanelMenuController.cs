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
    public class AdminPanelMenuController : Controller
    {
        // GET: AdminPanelMenu
        public ActionResult Index()
        {
            return View(AdminPanelMenuUpdateListModel.GetList());
        }

        // GET: AdminPanelMenu/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(AdminPanelMenuUpdateListModel.GetList().FirstOrDefault(x => x.AdminPanelMenuUpdateListModelID == id));
        }

        // GET: AdminPanelMenu/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: AdminPanelMenu/Create
        [HttpPost]
        public ActionResult Create(AdminPanelMenuCreateModel apmcm)
        {
            try
            {
                AdminPanelMenu adminpanelmenu = new AdminPanelMenu();
                adminpanelmenu.Adi = apmcm.Adi;
                adminpanelmenu.Url = apmcm.Url;
                DbFactory.AdminPanelMenuCrud.Insert(adminpanelmenu);
                TempData["sweetalert"] = "<script>swal('Eklendi','Admin Panel Menü " + " Eklendi', 'success');" + "</script>";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminPanelMenu/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(AdminPanelMenuUpdateListModel.GetList().FirstOrDefault(x => x.AdminPanelMenuUpdateListModelID == id));
        }

        // POST: AdminPanelMenu/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, AdminPanelMenuUpdateListModel apmulm)
        {
            try
            {
                AdminPanelMenu currentadminpanelmenu = DbFactory.AdminPanelMenuCrud.Find(id);
                currentadminpanelmenu.Adi = apmulm.Adi;
                currentadminpanelmenu.Url = apmulm.Url;

                DbFactory.AdminPanelMenuCrud.Update(id, currentadminpanelmenu);
                TempData["sweetalert"] = "<script>swal('Güncellendi','Admin Panel Menü " + " Güncellendi', 'success');" + "</script>";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminPanelMenu/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.AdminPanelMenuCrud.Delete(id);
            TempData["sweetalert"] = "<script>swal('Silindi','Admin Panel Menü " + " Silindi', 'success');" + "</script>";
            return RedirectToAction("Index");
        }

    }
}
