namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7ad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Districts", "İlceID", c => c.Int(nullable: false));
            AddColumn("dbo.Districts", "ilID", c => c.Int(nullable: false));
            DropColumn("dbo.Districts", "ProvinceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Districts", "ProvinceID", c => c.Int(nullable: false));
            DropColumn("dbo.Districts", "ilID");
            DropColumn("dbo.Districts", "İlceID");
        }
    }
}
