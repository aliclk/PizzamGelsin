
using OhmCrud;
using PizzamGelsin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzamGelsin.Classes
{
    public class DbFactory
    {
        private static volatile PizzaContext _db = new PizzaContext();
        private static volatile GenelCrud<AdminPanelMenu> _adminPanelMenuCrud = null;

        public static GenelCrud<AdminPanelMenu> AdminPanelMenuCrud
        {
            get
            {
                if (_adminPanelMenuCrud == null)
                {
                    _adminPanelMenuCrud = new GenelCrud<AdminPanelMenu>(_db, _db.AdminPanelMenu);
                    _adminPanelMenuCrud.CheckConnection();
                }
                return _adminPanelMenuCrud;
            }
        }
        private static volatile GenelCrud<Adres> _adresCrud = null;

        public static GenelCrud<Adres> AdresCrud
        {
            get
            {
                if (_adresCrud == null)
                {
                    _adresCrud = new GenelCrud<Adres>(_db, _db.Adres);
                    _adresCrud.CheckConnection();
                }
                return _adresCrud;
            }
        }

        private static volatile GenelCrud<Calisan> _calisanCrud = null;

        public static GenelCrud<Calisan> CalisanCrud
        {
            get
            {
                if (_calisanCrud == null)
                {
                    _calisanCrud = new GenelCrud<Calisan>(_db, _db.Calisan);
                    _calisanCrud.CheckConnection();
                }
                return _calisanCrud;
            }
        }
        private static volatile GenelCrud<Favori> _favoriCrud = null;

        public static GenelCrud<Favori> FavoriCrud
        {
            get
            {
                if (_favoriCrud == null)
                {
                    _favoriCrud = new GenelCrud<Favori>(_db, _db.Favori);
                    _favoriCrud.CheckConnection();
                }
                return _favoriCrud;
            }
        }

    

        private static volatile GenelCrud<Hakkimizda> _hakkimizdaCrud = null;

        public static GenelCrud<Hakkimizda> HakkimizdaCrud
        {
            get
            {
                if (_hakkimizdaCrud == null)
                {
                    _hakkimizdaCrud = new GenelCrud<Hakkimizda>(_db, _db.Hakkimizda);
                    _hakkimizdaCrud.CheckConnection();
                }
                return _hakkimizdaCrud;
            }
        }

        private static volatile GenelCrud<HamurTipi> _hamurTipiCrud = null;

        public static GenelCrud<HamurTipi> HamurTipiCrud
        {
            get
            {
                if (_hamurTipiCrud == null)
                {
                    _hamurTipiCrud = new GenelCrud<HamurTipi>(_db, _db.HamurTipi);
                    _hamurTipiCrud.CheckConnection();
                }
                return _hamurTipiCrud;
            }
        }

        private static volatile GenelCrud<Icecek> _icecekCrud = null;

        public static GenelCrud<Icecek> IcecekCrud
        {
            get
            {
                if (_icecekCrud == null)
                {
                    _icecekCrud = new GenelCrud<Icecek>(_db, _db.Icecek);
                    _icecekCrud.CheckConnection();
                }
                return _icecekCrud;
            }
        }

        private static volatile GenelCrud<IcecekBoyut> _icecekBoyutCrud = null;

        public static GenelCrud<IcecekBoyut> IcecekBoyutCrud
        {
            get
            {
                if (_icecekBoyutCrud == null)
                {
                    _icecekBoyutCrud = new GenelCrud<IcecekBoyut>(_db, _db.IcecekBoyutlar);
                    _icecekBoyutCrud.CheckConnection();
                }
                return _icecekBoyutCrud;
            }
        }

        private static volatile GenelCrud<Kampanya> _kampanyaCrud = null;

        public static GenelCrud<Kampanya> KampanyaCrud
        {
            get
            {
                if (_kampanyaCrud == null)
                {
                    _kampanyaCrud = new GenelCrud<Kampanya>(_db, _db.Kampanya);
                    _kampanyaCrud.CheckConnection();
                }
                return _kampanyaCrud;
            }
        }

        private static volatile GenelCrud<KenarTipi> _kenarTipiCrud = null;

        public static GenelCrud<KenarTipi> KenarTipi
        {
            get
            {
                if (_kenarTipiCrud == null)
                {
                    _kenarTipiCrud = new GenelCrud<KenarTipi>(_db, _db.KenarTipi);
                    _kenarTipiCrud.CheckConnection();
                }
                return _kenarTipiCrud;
            }
        }

        private static volatile GenelCrud<KrediKarti> _krediKartiCrud = null;

        public static GenelCrud<KrediKarti> KrediKarti
        {
            get
            {
                if (_krediKartiCrud == null)
                {
                    _krediKartiCrud = new GenelCrud<KrediKarti>(_db, _db.KrediKarti);
                    _krediKartiCrud.CheckConnection();
                }
                return _krediKartiCrud;
            }
        }
        private static volatile GenelCrud<Kullanici> _kullaniciCrud = null;

        public static GenelCrud<Kullanici> KullaniciCrud
        {
            get
            {
                if (_kullaniciCrud == null)
                {
                    _kullaniciCrud = new GenelCrud<Kullanici>(_db, _db.Kullanici);
                    _kullaniciCrud.CheckConnection();
                }
                return _kullaniciCrud;
            }
        }

        private static volatile GenelCrud<KuponKodu> _kuponKoduCrud = null;

        public static GenelCrud<KuponKodu> KuponKoduCrud
        {
            get
            {
                if (_kuponKoduCrud == null)
                {
                    _kuponKoduCrud = new GenelCrud<KuponKodu>(_db, _db.KuponKodu);
                    _kuponKoduCrud.CheckConnection();
                }
                return _kuponKoduCrud;
            }
        }

        private static volatile GenelCrud<Malzeme> _malzemeCrud = null;

        public static GenelCrud<Malzeme> MalzemeCrud
        {
            get
            {
                if (_malzemeCrud == null)
                {
                    _malzemeCrud = new GenelCrud<Malzeme>(_db, _db.Malzeme);
                    _malzemeCrud.CheckConnection();
                }
                return _malzemeCrud;
            }
        }

        private static volatile GenelCrud<Pizza> _pizzaCrud = null;

        public static GenelCrud<Pizza> PizzaCrud
        {
            get
            {
                if (_pizzaCrud == null)
                {
                    _pizzaCrud = new GenelCrud<Pizza>(_db, _db.Pizza);
                    _pizzaCrud.CheckConnection();
                }
                return _pizzaCrud;
            }
        }

        private static volatile GenelCrud<PizzaBoyut> _pizzaBoyutCrud = null;

        public static GenelCrud<PizzaBoyut> PizzaBoyutCrud
        {
            get
            {
                if (_pizzaBoyutCrud == null)
                {
                    _pizzaBoyutCrud = new GenelCrud<PizzaBoyut>(_db, _db.PizzaBoyut);
                    _pizzaBoyutCrud.CheckConnection();
                }
                return _pizzaBoyutCrud;
            }
        }

        private static volatile GenelCrud<Reklam> _reklamCrud = null;

        public static GenelCrud<Reklam> ReklamCrud
        {
            get
            {
                if (_reklamCrud == null)
                {
                    _reklamCrud = new GenelCrud<Reklam>(_db, _db.Reklam);
                    _reklamCrud.CheckConnection();
                }
                return _reklamCrud;
            }
        }

        private static volatile GenelCrud<Resim> _resimCrud = null;

        public static GenelCrud<Resim> ResimCrud
        {
            get
            {
                if (_resimCrud == null)
                {
                    _resimCrud = new GenelCrud<Resim>(_db, _db.Resim);
                    _resimCrud.CheckConnection();
                }
                return _resimCrud;
            }
        }

        private static volatile GenelCrud<Sepet> _sepetCrud = null;

        public static GenelCrud<Sepet> SepetCrud
        {
            get
            {
                if (_sepetCrud == null)
                {
                    _sepetCrud = new GenelCrud<Sepet>(_db, _db.Sepet);
                    _sepetCrud.CheckConnection();
                }
                return _sepetCrud;
            }
        }

        private static volatile GenelCrud<Siparis> _siparisCrud = null;

        public static GenelCrud<Siparis> SiparisCrud
        {
            get
            {
                if (_siparisCrud == null)
                {
                    _siparisCrud = new GenelCrud<Siparis>(_db, _db.Siparis);
                    _siparisCrud.CheckConnection();
                }
                return _siparisCrud;
            }
        }



        private static volatile GenelCrud<Urun> _urunCrud = null;

        public static GenelCrud<Urun> UrunCrud
        {
            get
            {
                if (_urunCrud == null)
                {
                    _urunCrud = new GenelCrud<Urun>(_db, _db.Urun);
                    _urunCrud.CheckConnection();
                }
                return _urunCrud;
            }
        }

        private static volatile GenelCrud<WebSite> _webSiteCrud = null;

        public static GenelCrud<WebSite> WebSiteCrud
        {
            get
            {
                if (_webSiteCrud == null)
                {
                    _webSiteCrud = new GenelCrud<WebSite>(_db, _db.WebSite);
                    _webSiteCrud.CheckConnection();
                }
                return _webSiteCrud;
            }
        }

        private static volatile GenelCrud<Yorum> _yorumCrud = null;

        public static GenelCrud<Yorum> YorumCrud
        {
            get
            {
                if (_yorumCrud == null)
                {
                    _yorumCrud = new GenelCrud<Yorum>(_db, _db.Yorum);
                    _yorumCrud.CheckConnection();
                }
                return _yorumCrud;
            }
        }
    }
}

