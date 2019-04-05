
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
    public class IcecekController : Controller
    {
        // GET: Icecek
        public ActionResult Index()
        {
            return View(IcecekUpdateListModel.GetList());
        }

        // GET: Icecek/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(IcecekUpdateListModel.GetList().FirstOrDefault(x => x.IcecekUpdateListModelId == id));
        }

        // GET: Icecek/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Icecek/Create
        [HttpPost]
        public ActionResult Create(IcecekCreateModel iulm,IEnumerable<HttpPostedFileBase> images)
        {
            try
            {
                Icecek icecek = new Icecek();
                foreach (var image in images)
                {
                    string serverPath = Server.MapPath("~/Images/" + Guid.NewGuid().ToString().Replace("-","") + ".png");
                    icecek.UrunResimleri.Add(new Resim { Url = serverPath });
                    image.SaveAs(serverPath);

                }
               // icecek.Icecekboyutlar = iulm.Icecekboyutlar;
                icecek.AlinmaAdedi = iulm.AlinmaAdedi;
                
                icecek.UrunAciklama = iulm.UrunAciklama;
                icecek.UrunAdet = iulm.UrunAdet;
                icecek.UrunAdi = iulm.UrunAdi;
                icecek.UrunFiyat = iulm.UrunFiyat;
                icecek.Yildiz = iulm.Yildiz;
                

                DbFactory.IcecekCrud.Insert(icecek);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Icecek/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(IcecekUpdateListModel.GetList().FirstOrDefault(x => x.IcecekUpdateListModelId == id));
        }

        // POST: Icecek/Edit/5
        [HttpPost]


        public ActionResult Edit(string id, IcecekUpdateListModel iulm)
        {
            try
            {
                Icecek icecek = DbFactory.IcecekCrud.Find(id);
                //foreach (var image in images)
                //{
                //    string serverPath = Server.MapPath("~/Images/" + Guid.NewGuid().ToString() + ".png");
                //    icecek.UrunResimleri.Add(new Resim { Url = serverPath });
                //    image.SaveAs(serverPath);

                //}
                icecek.Icecekboyutlar = iulm.Icecekboyutlar;
                icecek.AlinmaAdedi = iulm.AlinmaAdedi;

                icecek.UrunAciklama = iulm.UrunAciklama;
                icecek.UrunAdet = iulm.UrunAdet;
                icecek.UrunAdi = iulm.UrunAdi;
                icecek.UrunFiyat = iulm.UrunFiyat;
                icecek.Yildiz = iulm.Yildiz;

                DbFactory.IcecekCrud.Update(id,icecek);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Icecek/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.UrunCrud.Delete(id);
            DbFactory.IcecekCrud.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
