namespace WebApplicationOglasi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oglasModelDodaden : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Oglas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        zanimanje = c.String(nullable: false),
                        pocetnaData = c.DateTime(nullable: false),
                        krajnaData = c.DateTime(nullable: false),
                        pravnoLice = c.String(nullable: false),
                        opstina = c.String(nullable: false),
                        adresa = c.String(nullable: false),
                        email = c.String(nullable: false),
                        telBroj = c.String(nullable: false),
                        opis = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Oglas");
        }
    }
}
