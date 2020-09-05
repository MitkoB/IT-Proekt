namespace WebApplicationOglasi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categorychange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Oglas", "kategorija_Id", c => c.Int());
            CreateIndex("dbo.Oglas", "kategorija_Id");
            AddForeignKey("dbo.Oglas", "kategorija_Id", "dbo.Categories", "Id");
            DropColumn("dbo.Oglas", "kategorija");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Oglas", "kategorija", c => c.String());
            DropForeignKey("dbo.Oglas", "kategorija_Id", "dbo.Categories");
            DropIndex("dbo.Oglas", new[] { "kategorija_Id" });
            DropColumn("dbo.Oglas", "kategorija_Id");
        }
    }
}
