using PizzamGelsin.Enums;
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
        public static SelectList MalzemeSelectList = new SelectList(DbFactory.MalzemeCrud.Records);
        public static SelectList PizzaBoyutSelectList = new SelectList(DbFactory.PizzaBoyutCrud.Records);
        public static SelectList PizzaBoyutEnumSelectList
        {
            get
            {
                return new SelectList(Enum.GetNames(typeof(PizzaBoyut)));
            }
        }
        public static SelectList IcecekSelectList
        {
            get
            {
                return new SelectList(DbFactory.IcecekCrud.Records);
            }
        }
        public static SelectList HamurEnumSelectList
        {
            get
            {
                return new SelectList(Enum.GetNames(typeof(HamurTipi)));
            }
        }
        public static SelectList KenarEnumSelectList
        {
            get
            {
                return new SelectList(Enum.GetNames(typeof(Kenartipi)));
            }
        }
    }
}