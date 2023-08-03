namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9ad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Neighbourhoods", "mahalleID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Neighbourhoods", "mahalleID");
        }
    }
}
