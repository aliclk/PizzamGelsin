using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzamGelsin.Classes
{
    public class SelectListFactory
    {
        public static SelectList PizzaSelectList = new SelectList(DbFactory.PizzaCrud.Records);
        public static SelectList HamurSelectList = new SelectList(DbFactory.HamurTipiCrud.Records);
        public static SelectList KenarSelectList = new SelectList(DbFactory.KenarTipi.Records);
        public static SelectList MalzemeSelectList = new SelectList(DbFactory.MalzemeCrud.Records);
        public static SelectList PizzaBoyutSelectList = new SelectList(DbFactory.PizzaBoyutCrud.Records);
        public static SelectList IcecekSelectList = new SelectList(DbFactory.IcecekCrud.Records);

    }
}