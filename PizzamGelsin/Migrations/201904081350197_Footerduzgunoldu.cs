namespace PizzamGelsin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Footerduzgunoldu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footer",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Aciklama = c.String(maxLength: 200),
                        Adres = c.String(maxLength: 200),
                        Telefon = c.String(maxLength: 200),
                        EMail = c.String(maxLength: 200),
                        InstagramAdres = c.String(maxLength: 200),
                        FacebookAdres = c.String(maxLength: 200),
                        YoutubeAdres = c.String(maxLength: 200),
                        TwitterAdres = c.String(maxLength: 200),
                        GooglePlusAdres = c.String(maxLength: 200),
                        PinterestAdres = c.String(maxLength: 200),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Footer");
        }
    }
}
