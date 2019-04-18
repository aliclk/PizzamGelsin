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

        
        // GET: Resim/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.ResimCrud.Delete(id);
            return RedirectToAction("Index");
        }
 
    }
}
