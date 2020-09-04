namespace WebApplicationOglasi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class slikaDodadena : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Oglas", "slikaUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Oglas", "slikaUrl");
        }
    }
}
