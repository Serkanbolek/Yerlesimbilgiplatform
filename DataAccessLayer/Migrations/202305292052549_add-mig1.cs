namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmig1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Districts", "İlceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Districts", "İlceID", c => c.Int(nullable: false));
        }
    }
}
