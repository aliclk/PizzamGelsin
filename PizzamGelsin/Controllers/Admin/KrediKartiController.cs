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
    public class KrediKartiController : Controller
    {
        // GET: KrediKarti
        public ActionResult Index()
        {
            return View(KrediKartiUpdateListModel.GetList());
        }

        // GET: KrediKarti/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(KrediKartiUpdateListModel.GetList().FirstOrDefault(x => x.KrediKartiUpdateListModelID == id));
        }

        // GET: KrediKarti/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: KrediKarti/Create
        [HttpPost]
        public ActionResult Create(KrediKartiCreateModel kkcm)
        {
            try
            {
                KrediKarti kredikarti = new KrediKarti();
                kredikarti.KisiAdSoyad = kkcm.KisiAdSoyad;
                kredikarti.Ay = kkcm.Ay;
                kredikarti.Yil = kkcm.Yil;
                kredikarti.Cvv = kkcm.Cvv;
                kredikarti.KrediKartNo = kkcm.KrediKartNo;
                DbFactory.KrediKarti.Insert(kredikarti);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KrediKarti/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(KrediKartiUpdateListModel.GetList().FirstOrDefault(x => x.KrediKartiUpdateListModelID == id));
        }

        // POST: KrediKarti/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, KrediKartiUpdateListModel kkulm)
        {
            try
            {
                KrediKarti currentkredikarti = DbFactory.KrediKarti.Find(id);
                currentkredikarti.KisiAdSoyad = kkulm.KisiAdSoyad;
                currentkredikarti.Ay = kkulm.Ay;
                currentkredikarti.Yil = kkulm.Yil;
                currentkredikarti.Cvv = kkulm.Cvv;
                currentkredikarti.KrediKartNo = kkulm.KrediKartNo;
                

                DbFactory.KrediKarti.Update(id, currentkredikarti);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KrediKarti/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.KrediKarti.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
