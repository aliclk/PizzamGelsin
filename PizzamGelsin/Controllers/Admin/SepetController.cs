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
	public class SepetController : Controller
	{
		// GET: Sepet
		public ActionResult Index()
		{
            return View(SepetUpdateListModel.GetList());
        }

		// GET: Sepet/Details/5
		public ActionResult Details(string id)
		{
            return PartialView(SepetUpdateListModel.GetList().FirstOrDefault(x => x.SepetUpdateListModelID == id));
        }

		// GET: Sepet/Create
		public ActionResult Create()
		{
			return PartialView();
		}

		// POST: Sepet/Create
		[HttpPost]
		public ActionResult Create(SepetCreateModel scm)
		{
			try
			{
                Sepet sepet = new Sepet();
                sepet.Adet = scm.Adet;
                sepet.Fiyat = scm.Fiyat;
                sepet.Urun = scm.Urun;
                
                var t = DbFactory.SepetCrud.Insert(sepet);
                //file.SaveAs(Server.MapPath("~/classes/m.jpg"));
                return RedirectToAction("Index");
            }
			catch
			{
				return View();
			}
		}

		// GET: Sepet/Edit/5
		public ActionResult Edit(string id)
		{
            return PartialView(SepetUpdateListModel.GetList().FirstOrDefault(x => x.SepetUpdateListModelID == id));
        }

		// POST: Sepet/Edit/5
		[HttpPost]
		public ActionResult Edit(string id, SepetUpdateListModel sulm)
		{
			try
			{
                Sepet currentsepet = DbFactory.SepetCrud.Find(id);

                currentsepet.Adet = sulm.Adet;
                currentsepet.Fiyat = sulm.Fiyat;
                currentsepet.Urun = sulm.Urun;
                

                DbFactory.SepetCrud.Update(id, currentsepet);

                return RedirectToAction("Index");
            }
			catch
			{
				return View();
			}
		}

		// GET: Sepet/Delete/5
		public ActionResult Delete(string id)
		{
            DbFactory.SepetCrud.Delete(id);
            return RedirectToAction("Index");
        }
	}

}
