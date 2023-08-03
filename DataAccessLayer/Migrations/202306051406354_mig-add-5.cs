namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migadd5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ApartmentnumberID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ApartmentnumberID");
        }
    }
}
