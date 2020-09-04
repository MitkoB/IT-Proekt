namespace WebApplicationOglasi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kategorijaDodadena : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Oglas", "kategorija", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Oglas", "kategorija");
        }
    }
}
