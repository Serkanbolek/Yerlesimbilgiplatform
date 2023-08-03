namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6ad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Provinces", "PlakaKodu", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Provinces", "PlakaKodu");
        }
    }
}
