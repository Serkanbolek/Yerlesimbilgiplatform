namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmig2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Provinces", "PlakaKodu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Provinces", "PlakaKodu", c => c.Int(nullable: false));
        }
    }
}
