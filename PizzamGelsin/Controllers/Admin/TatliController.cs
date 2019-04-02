using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzamGelsin.Controllers
{
    public class TatliController : Controller
    {
        // GET: Tatli
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tatli/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: Tatli/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tatli/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tatli/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: Tatli/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tatli/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

    }
}
