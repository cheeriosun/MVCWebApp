namespace MVCWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blog", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blog", "Url");
        }
    }
}
