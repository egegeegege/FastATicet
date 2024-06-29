namespace frmKullaniciKayıt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ucuslars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UcusID = c.Int(nullable: false),
                        YoneticiID = c.Int(nullable: false),
                        AlisTarihi = c.DateTime(nullable: false),
                        BinisTarihi = c.DateTime(nullable: false),
                        FaturaTutarı = c.Double(nullable: false),
                        Addtime = c.DateTime(),
                        Updatetime = c.DateTime(),
                        Deletetime = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yoneticilers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adı = c.String(),
                        Soyadı = c.String(),
                        TC = c.String(),
                        Telefon = c.String(),
                        Email = c.String(),
                        Adres = c.String(),
                        Sifre = c.String(),
                        Addtime = c.DateTime(),
                        Updatetime = c.DateTime(),
                        Deletetime = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Yoneticilers");
            DropTable("dbo.Ucuslars");
        }
    }
}
