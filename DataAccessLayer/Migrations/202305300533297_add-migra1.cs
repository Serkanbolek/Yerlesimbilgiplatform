namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigra1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Neighbourhoods", "mahalleID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Neighbourhoods", "mahalleID", c => c.Int(nullable: false));
        }
    }
}
