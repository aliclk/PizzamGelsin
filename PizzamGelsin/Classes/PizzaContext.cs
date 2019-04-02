namespace PizzamGelsin.Classes
{
    using PizzamGelsin.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PizzaContext : DbContext
    {
        // Your context has been configured to use a 'PizzaContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PizzamGelsin.Classes.PizzaContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PizzaContext' 
        // connection string in the application configuration file.
        public PizzaContext()
            : base("name=PizzaContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<AdminPanelMenu> AdminPanelMenu { get; set; }
        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Calisan> Calisan { get; set; }
        public virtual DbSet<Favori> Favori { get; set; }
        public virtual DbSet<GununMenusu> GununMenusu { get; set; }
        public virtual DbSet<Hakkimizda> Hakkimizda { get; set; }
        public virtual DbSet<HamurTipi> HamurTipi { get; set; }
        public virtual DbSet<Icecek> Icecek { get; set; }
        public virtual DbSet<Kampanya> Kampanya { get; set; }
        public virtual DbSet<KenarTipi> KenarTipi { get; set; }
        public virtual DbSet<KrediKarti> KrediKarti { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KuponKodu> KuponKodu { get; set; }
        public virtual DbSet<Malzeme> Malzeme { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<PizzaBoyut> PizzaBoyut { get; set; }
        public virtual DbSet<Reklam> Reklam { get; set; }
        public virtual DbSet<Resim> Resim { get; set; }
        public virtual DbSet<Sepet> Sepet { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<Tatli> Tatli { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<WebSite> WebSite { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }
        public virtual DbSet<IcecekBoyut> IcecekBoyutlar { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}