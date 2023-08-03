namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migradd5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "BuildingNumber_BuildingNumberID", "dbo.BuildingNumbers");
            DropIndex("dbo.Comments", new[] { "BuildingNumber_BuildingNumberID" });
            AddColumn("dbo.Comments", "ApartmentnumberID", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "ApartmentnumberID");
            AddForeignKey("dbo.Comments", "ApartmentnumberID", "dbo.Apartmentnumbers", "ApartmentnumberID", cascadeDelete: true);
            DropColumn("dbo.Comments", "BuildingNumber_BuildingNumberID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "BuildingNumber_BuildingNumberID", c => c.Int());
            DropForeignKey("dbo.Comments", "ApartmentnumberID", "dbo.Apartmentnumbers");
            DropIndex("dbo.Comments", new[] { "ApartmentnumberID" });
            DropColumn("dbo.Comments", "ApartmentnumberID");
            CreateIndex("dbo.Comments", "BuildingNumber_BuildingNumberID");
            AddForeignKey("dbo.Comments", "BuildingNumber_BuildingNumberID", "dbo.BuildingNumbers", "BuildingNumberID");
        }
    }
}
