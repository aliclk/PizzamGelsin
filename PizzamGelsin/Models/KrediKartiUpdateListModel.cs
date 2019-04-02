using PizzamGelsin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Models
{
    public class KrediKartiUpdateListModel
    {
        public string KrediKartiUpdateListModelID { get; set; }
        [Display(Name = "Kartı Kullanan Adı Soyadı")]
        public string KisiAdSoyad { get; set; }
        [Display(Name = "Son Kullanma Tarihi Yıl")]
        public int Yil { get; set; }
        [Display(Name = "Son Kullanma Tarihi Ay")]
        public int Ay { get; set; }
        [Display(Name = "Kredi Kartı No")]
        public string KrediKartNo { get; set; }
        [Display(Name = "Cvv(Kartın Arkasındaki 3 Hane)")]
        public string Cvv { get; set; }

        public static List<KrediKartiUpdateListModel> GetList()
        {
            List<KrediKartiUpdateListModel> returnList = new List<KrediKartiUpdateListModel>();
            foreach (var kredikarti in DbFactory.KrediKarti.Records)
            {
                KrediKartiUpdateListModel kkulm = new KrediKartiUpdateListModel();
                kkulm.KrediKartiUpdateListModelID = kredikarti.ID;
                kkulm.KisiAdSoyad = kredikarti.KisiAdSoyad;
                kkulm.Yil = kredikarti.Yil;
                kkulm.Ay = kredikarti.Ay;
                kkulm.KrediKartNo = kredikarti.KrediKartNo;
                kkulm.Cvv = kredikarti.Cvv;

                returnList.Add(kkulm);
            }
            return returnList;
        }


    }
}