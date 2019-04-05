namespace PizzamGelsin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Urun", "GununMenusu_ID", "dbo.GununMenusu");
            DropForeignKey("dbo.Tatli", "ID", "dbo.Urun");
            DropIndex("dbo.Urun", new[] { "GununMenusu_ID" });
            DropIndex("dbo.Tatli", new[] { "ID" });
            DropColumn("dbo.Urun", "GununMenusu_ID");
            DropTable("dbo.GununMenusu");
            DropTable("dbo.Tatli");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tatli",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
            AddColumn("dbo.Urun", "GununMenusu_ID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Tatli", "ID");
            CreateIndex("dbo.Urun", "GununMenusu_ID");
            AddForeignKey("dbo.Tatli", "ID", "dbo.Urun", "ID");
            AddForeignKey("dbo.Urun", "GununMenusu_ID", "dbo.GununMenusu", "ID");
        }
    }
}
