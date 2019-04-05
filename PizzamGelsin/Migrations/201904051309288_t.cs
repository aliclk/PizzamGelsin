namespace PizzamGelsin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminPanelMenu",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Url = c.String(nullable: false, maxLength: 1000),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(nullable: false, maxLength: 30),
                        AdresIcerik = c.String(nullable: false, maxLength: 200),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Kullanici_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanici", t => t.Kullanici_ID)
                .Index(t => t.Kullanici_ID);
            
            CreateTable(
                "dbo.Calisan",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Ozgecmis = c.String(nullable: false, maxLength: 300),
                        Unvan = c.String(nullable: false, maxLength: 50),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Resim_ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resim", t => t.Resim_ID, cascadeDelete: true)
                .Index(t => t.Resim_ID);
            
            CreateTable(
                "dbo.Resim",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Url = c.String(nullable: false, maxLength: 1000),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Urun_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Urun", t => t.Urun_ID)
                .Index(t => t.Urun_ID);
            
            CreateTable(
                "dbo.Favori",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Urunler_ID = c.String(maxLength: 128),
                        Kullanici_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Urun", t => t.Urunler_ID)
                .ForeignKey("dbo.Kullanici", t => t.Kullanici_ID)
                .Index(t => t.Urunler_ID)
                .Index(t => t.Kullanici_ID);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        UrunAdi = c.String(nullable: false, maxLength: 50),
                        UrunFiyat = c.Double(nullable: false),
                        UrunAciklama = c.String(nullable: false, maxLength: 1000),
                        UrunAdet = c.Int(nullable: false),
                        AlinmaAdedi = c.Int(nullable: false),
                        Yildiz = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        GununMenusu_ID = c.String(maxLength: 128),
                        Kampanya_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GununMenusu", t => t.GununMenusu_ID)
                .ForeignKey("dbo.Kampanya", t => t.Kampanya_ID)
                .Index(t => t.GununMenusu_ID)
                .Index(t => t.Kampanya_ID);
            
            CreateTable(
                "dbo.IcecekBoyutlari",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Boyut = c.String(nullable: false, maxLength: 50),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Resim_ID = c.String(nullable: false, maxLength: 128),
                        Icecek_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resim", t => t.Resim_ID, cascadeDelete: true)
                .ForeignKey("dbo.Icecek", t => t.Icecek_ID)
                .Index(t => t.Resim_ID)
                .Index(t => t.Icecek_ID);
            
            CreateTable(
                "dbo.PizzaBoyut",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        BoyutAdi = c.String(nullable: false, maxLength: 100),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Pizza_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pizza", t => t.Pizza_ID)
                .Index(t => t.Pizza_ID);
            
            CreateTable(
                "dbo.HamurTipi",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        HamurAdi = c.String(nullable: false, maxLength: 50),
                        EkFiyat = c.Double(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Resim_ID = c.String(nullable: false, maxLength: 128),
                        Pizza_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resim", t => t.Resim_ID, cascadeDelete: true)
                .ForeignKey("dbo.Pizza", t => t.Pizza_ID)
                .Index(t => t.Resim_ID)
                .Index(t => t.Pizza_ID);
            
            CreateTable(
                "dbo.KenarTipi",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        KenarAdi = c.String(nullable: false, maxLength: 50),
                        EkFiyat = c.Double(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        KenarResim_ID = c.String(nullable: false, maxLength: 128),
                        Pizza_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resim", t => t.KenarResim_ID, cascadeDelete: true)
                .ForeignKey("dbo.Pizza", t => t.Pizza_ID)
                .Index(t => t.KenarResim_ID)
                .Index(t => t.Pizza_ID);
            
            CreateTable(
                "dbo.Malzeme",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        EkFiyat = c.Double(nullable: false),
                        MalzemeAdi = c.String(nullable: false, maxLength: 100),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Resim_ID = c.String(nullable: false, maxLength: 128),
                        Pizza_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resim", t => t.Resim_ID, cascadeDelete: true)
                .ForeignKey("dbo.Pizza", t => t.Pizza_ID)
                .Index(t => t.Resim_ID)
                .Index(t => t.Pizza_ID);
            
            CreateTable(
                "dbo.GununMenusu",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Tarih = c.DateTime(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hakkimizda",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Baslik = c.String(nullable: false, maxLength: 50),
                        Icerik = c.String(nullable: false, maxLength: 300),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Resim_ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resim", t => t.Resim_ID, cascadeDelete: true)
                .Index(t => t.Resim_ID);
            
            CreateTable(
                "dbo.Kampanya",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Fiyat = c.Double(nullable: false),
                        KampanyaAdi = c.String(nullable: false, maxLength: 100),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KrediKarti",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        KisiAdSoyad = c.String(nullable: false, maxLength: 50),
                        Yil = c.Int(nullable: false),
                        Ay = c.Int(nullable: false),
                        KrediKartNo = c.String(nullable: false, maxLength: 100),
                        Cvv = c.String(nullable: false, maxLength: 50),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Soyadi = c.String(nullable: false, maxLength: 50),
                        Telefon = c.String(nullable: false, maxLength: 50),
                        Eposta = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 50),
                        KullaniciTipi = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        SiparisDurumu = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Adres_ID = c.String(maxLength: 128),
                        Kullanici_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Adres", t => t.Adres_ID)
                .ForeignKey("dbo.Kullanici", t => t.Kullanici_ID)
                .Index(t => t.Adres_ID)
                .Index(t => t.Kullanici_ID);
            
            CreateTable(
                "dbo.Sepet",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Fiyat = c.Double(nullable: false),
                        Adet = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Urun_ID = c.String(maxLength: 128),
                        Siparis_ID = c.String(maxLength: 128),
                        Kullanici_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Urun", t => t.Urun_ID)
                .ForeignKey("dbo.Siparis", t => t.Siparis_ID)
                .ForeignKey("dbo.Kullanici", t => t.Kullanici_ID)
                .Index(t => t.Urun_ID)
                .Index(t => t.Siparis_ID)
                .Index(t => t.Kullanici_ID);
            
            CreateTable(
                "dbo.Yorum",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        YorumIcerigi = c.String(nullable: false, maxLength: 3000),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Urun_ID = c.String(maxLength: 128),
                        Kullanici_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Urun", t => t.Urun_ID)
                .ForeignKey("dbo.Kullanici", t => t.Kullanici_ID)
                .Index(t => t.Urun_ID)
                .Index(t => t.Kullanici_ID);
            
            CreateTable(
                "dbo.KuponKodu",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        KuponKod = c.String(nullable: false, maxLength: 50),
                        Value = c.Int(nullable: false),
                        IndirimTuru = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reklam",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        ReklamLink = c.String(nullable: false, maxLength: 700),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Resim_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resim", t => t.Resim_ID)
                .Index(t => t.Resim_ID);
            
            CreateTable(
                "dbo.WebSite",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        WebAdi = c.String(nullable: false, maxLength: 200),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Logo_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resim", t => t.Logo_ID)
                .Index(t => t.Logo_ID);
            
            CreateTable(
                "dbo.Icecek",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Urun", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Pizza",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Urun", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Tatli",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Urun", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tatli", "ID", "dbo.Urun");
            DropForeignKey("dbo.Pizza", "ID", "dbo.Urun");
            DropForeignKey("dbo.Icecek", "ID", "dbo.Urun");
            DropForeignKey("dbo.WebSite", "Logo_ID", "dbo.Resim");
            DropForeignKey("dbo.Reklam", "Resim_ID", "dbo.Resim");
            DropForeignKey("dbo.Yorum", "Kullanici_ID", "dbo.Kullanici");
            DropForeignKey("dbo.Yorum", "Urun_ID", "dbo.Urun");
            DropForeignKey("dbo.Sepet", "Kullanici_ID", "dbo.Kullanici");
            DropForeignKey("dbo.Siparis", "Kullanici_ID", "dbo.Kullanici");
            DropForeignKey("dbo.Sepet", "Siparis_ID", "dbo.Siparis");
            DropForeignKey("dbo.Sepet", "Urun_ID", "dbo.Urun");
            DropForeignKey("dbo.Siparis", "Adres_ID", "dbo.Adres");
            DropForeignKey("dbo.Favori", "Kullanici_ID", "dbo.Kullanici");
            DropForeignKey("dbo.Adres", "Kullanici_ID", "dbo.Kullanici");
            DropForeignKey("dbo.Urun", "Kampanya_ID", "dbo.Kampanya");
            DropForeignKey("dbo.Hakkimizda", "Resim_ID", "dbo.Resim");
            DropForeignKey("dbo.Urun", "GununMenusu_ID", "dbo.GununMenusu");
            DropForeignKey("dbo.Favori", "Urunler_ID", "dbo.Urun");
            DropForeignKey("dbo.Malzeme", "Pizza_ID", "dbo.Pizza");
            DropForeignKey("dbo.Malzeme", "Resim_ID", "dbo.Resim");
            DropForeignKey("dbo.KenarTipi", "Pizza_ID", "dbo.Pizza");
            DropForeignKey("dbo.KenarTipi", "KenarResim_ID", "dbo.Resim");
            DropForeignKey("dbo.HamurTipi", "Pizza_ID", "dbo.Pizza");
            DropForeignKey("dbo.HamurTipi", "Resim_ID", "dbo.Resim");
            DropForeignKey("dbo.PizzaBoyut", "Pizza_ID", "dbo.Pizza");
            DropForeignKey("dbo.IcecekBoyutlari", "Icecek_ID", "dbo.Icecek");
            DropForeignKey("dbo.IcecekBoyutlari", "Resim_ID", "dbo.Resim");
            DropForeignKey("dbo.Resim", "Urun_ID", "dbo.Urun");
            DropForeignKey("dbo.Calisan", "Resim_ID", "dbo.Resim");
            DropIndex("dbo.Tatli", new[] { "ID" });
            DropIndex("dbo.Pizza", new[] { "ID" });
            DropIndex("dbo.Icecek", new[] { "ID" });
            DropIndex("dbo.WebSite", new[] { "Logo_ID" });
            DropIndex("dbo.Reklam", new[] { "Resim_ID" });
            DropIndex("dbo.Yorum", new[] { "Kullanici_ID" });
            DropIndex("dbo.Yorum", new[] { "Urun_ID" });
            DropIndex("dbo.Sepet", new[] { "Kullanici_ID" });
            DropIndex("dbo.Sepet", new[] { "Siparis_ID" });
            DropIndex("dbo.Sepet", new[] { "Urun_ID" });
            DropIndex("dbo.Siparis", new[] { "Kullanici_ID" });
            DropIndex("dbo.Siparis", new[] { "Adres_ID" });
            DropIndex("dbo.Hakkimizda", new[] { "Resim_ID" });
            DropIndex("dbo.Malzeme", new[] { "Pizza_ID" });
            DropIndex("dbo.Malzeme", new[] { "Resim_ID" });
            DropIndex("dbo.KenarTipi", new[] { "Pizza_ID" });
            DropIndex("dbo.KenarTipi", new[] { "KenarResim_ID" });
            DropIndex("dbo.HamurTipi", new[] { "Pizza_ID" });
            DropIndex("dbo.HamurTipi", new[] { "Resim_ID" });
            DropIndex("dbo.PizzaBoyut", new[] { "Pizza_ID" });
            DropIndex("dbo.IcecekBoyutlari", new[] { "Icecek_ID" });
            DropIndex("dbo.IcecekBoyutlari", new[] { "Resim_ID" });
            DropIndex("dbo.Urun", new[] { "Kampanya_ID" });
            DropIndex("dbo.Urun", new[] { "GununMenusu_ID" });
            DropIndex("dbo.Favori", new[] { "Kullanici_ID" });
            DropIndex("dbo.Favori", new[] { "Urunler_ID" });
            DropIndex("dbo.Resim", new[] { "Urun_ID" });
            DropIndex("dbo.Calisan", new[] { "Resim_ID" });
            DropIndex("dbo.Adres", new[] { "Kullanici_ID" });
            DropTable("dbo.Tatli");
            DropTable("dbo.Pizza");
            DropTable("dbo.Icecek");
            DropTable("dbo.WebSite");
            DropTable("dbo.Reklam");
            DropTable("dbo.KuponKodu");
            DropTable("dbo.Yorum");
            DropTable("dbo.Sepet");
            DropTable("dbo.Siparis");
            DropTable("dbo.Kullanici");
            DropTable("dbo.KrediKarti");
            DropTable("dbo.Kampanya");
            DropTable("dbo.Hakkimizda");
            DropTable("dbo.GununMenusu");
            DropTable("dbo.Malzeme");
            DropTable("dbo.KenarTipi");
            DropTable("dbo.HamurTipi");
            DropTable("dbo.PizzaBoyut");
            DropTable("dbo.IcecekBoyutlari");
            DropTable("dbo.Urun");
            DropTable("dbo.Favori");
            DropTable("dbo.Resim");
            DropTable("dbo.Calisan");
            DropTable("dbo.Adres");
            DropTable("dbo.AdminPanelMenu");
        }
    }
}
