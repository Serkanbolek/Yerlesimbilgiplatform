namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add2migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "StreetID", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "ApartmentnumberID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "ApartmentnumberID", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "StreetID");
        }
    }
}
