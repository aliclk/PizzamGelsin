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
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View(PizzaUpdateListModel.GetList());
        }

        // GET: Pizza/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(PizzaUpdateListModel.GetList().FirstOrDefault(x => x.UrunUpdateListModelID == id));
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(PizzaCreateModel pcm, IEnumerable<HttpPostedFileBase> images)
        {
            try
            {
                Pizza pizza = new Pizza();

                foreach (var image in images)
                {
                    string serverPath = Server.MapPath("~/Images/" + Guid.NewGuid().ToString() + ".png");
                    pizza.UrunResimleri.Add(new Resim { Url = serverPath });
                    image.SaveAs(serverPath);

                }
                pizza.AlinmaAdedi = pcm.AlinmaAdedi;
                pizza.Boyutlar = pcm.Boyutlar;
                pizza.Hamurlar = pcm.Hamurlar;
                pizza.Kenarlar = pcm.Kenarlar;
                pizza.Malzemeler = pcm.Malzemeler;
                pizza.UrunAciklama = pcm.UrunAciklama;
                pizza.UrunAdet = pcm.UrunAdet;
                pizza.UrunAdi = pcm.UrunAdi;
                pizza.UrunFiyat = pcm.UrunFiyat;
                pizza.Yildiz = pcm.Yildiz;

                DbFactory.PizzaCrud.Insert(pizza);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(PizzaUpdateListModel.GetList().FirstOrDefault(x => x.UrunUpdateListModelID == id));
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, PizzaUpdateListModel pulm)
        {
            try
            {
                Pizza currentpizza = DbFactory.PizzaCrud.Find(id);
                currentpizza.AlinmaAdedi = pulm.AlinmaAdedi;
                currentpizza.Boyutlar = pulm.Boyutlar;
                currentpizza.Hamurlar = pulm.Hamurlar;
                currentpizza.Kenarlar = pulm.Kenarlar;
                currentpizza.Malzemeler = pulm.Malzemeler;
                currentpizza.UrunAciklama = pulm.UrunAciklama;
                currentpizza.UrunAdet = pulm.UrunAdet;
                currentpizza.UrunAdi = pulm.UrunAdi;
                currentpizza.UrunFiyat = pulm.UrunFiyat;
                currentpizza.UrunResimleri = pulm.UrunResimleri;
                currentpizza.Yildiz = pulm.Yildiz;

                DbFactory.PizzaCrud.Update(id, currentpizza);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.PizzaCrud.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
