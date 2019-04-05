namespace PizzamGelsin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Urun", "Kampanya_ID", "dbo.Kampanya");
            DropIndex("dbo.Urun", new[] { "Kampanya_ID" });
            AddColumn("dbo.Kampanya", "Icecek_ID", c => c.String(maxLength: 128));
            AddColumn("dbo.Kampanya", "Pizza_ID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Kampanya", "Icecek_ID");
            CreateIndex("dbo.Kampanya", "Pizza_ID");
            AddForeignKey("dbo.Kampanya", "Icecek_ID", "dbo.Icecek", "ID");
            AddForeignKey("dbo.Kampanya", "Pizza_ID", "dbo.Pizza", "ID");
            DropColumn("dbo.Urun", "Kampanya_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urun", "Kampanya_ID", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Kampanya", "Pizza_ID", "dbo.Pizza");
            DropForeignKey("dbo.Kampanya", "Icecek_ID", "dbo.Icecek");
            DropIndex("dbo.Kampanya", new[] { "Pizza_ID" });
            DropIndex("dbo.Kampanya", new[] { "Icecek_ID" });
            DropColumn("dbo.Kampanya", "Pizza_ID");
            DropColumn("dbo.Kampanya", "Icecek_ID");
            CreateIndex("dbo.Urun", "Kampanya_ID");
            AddForeignKey("dbo.Urun", "Kampanya_ID", "dbo.Kampanya", "ID");
        }
    }
}
