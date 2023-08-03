namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4ad : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BuildingNumbers", "StreetID", "dbo.Streets");
            DropForeignKey("dbo.Neighbourhoods", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Districts", "ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Streets", "NeighbourhoodID", "dbo.Neighbourhoods");
            DropForeignKey("dbo.Apartmentnumbers", "BuildingNumberID", "dbo.BuildingNumbers");
            DropForeignKey("dbo.Comments", "UserID", "dbo.Users");
            DropIndex("dbo.Apartmentnumbers", new[] { "BuildingNumberID" });
            DropIndex("dbo.BuildingNumbers", new[] { "StreetID" });
            DropIndex("dbo.Streets", new[] { "NeighbourhoodID" });
            DropIndex("dbo.Neighbourhoods", new[] { "DistrictID" });
            DropIndex("dbo.Districts", new[] { "ProvinceID" });
            DropIndex("dbo.Comments", new[] { "UserID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Comments", "UserID");
            CreateIndex("dbo.Districts", "ProvinceID");
            CreateIndex("dbo.Neighbourhoods", "DistrictID");
            CreateIndex("dbo.Streets", "NeighbourhoodID");
            CreateIndex("dbo.BuildingNumbers", "StreetID");
            CreateIndex("dbo.Apartmentnumbers", "BuildingNumberID");
            AddForeignKey("dbo.Comments", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.Apartmentnumbers", "BuildingNumberID", "dbo.BuildingNumbers", "BuildingNumberID", cascadeDelete: true);
            AddForeignKey("dbo.Streets", "NeighbourhoodID", "dbo.Neighbourhoods", "NeighbourhoodID", cascadeDelete: true);
            AddForeignKey("dbo.Districts", "ProvinceID", "dbo.Provinces", "ProvinceID", cascadeDelete: true);
            AddForeignKey("dbo.Neighbourhoods", "DistrictID", "dbo.Districts", "DistrictID", cascadeDelete: true);
            AddForeignKey("dbo.BuildingNumbers", "StreetID", "dbo.Streets", "StreetID", cascadeDelete: true);
        }
    }
}
