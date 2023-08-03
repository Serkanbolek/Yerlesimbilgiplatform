namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migradd4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "ApartmentnumberID", "dbo.Apartmentnumbers");
            DropIndex("dbo.Comments", new[] { "ApartmentnumberID" });
            DropColumn("dbo.Comments", "ApartmentnumberID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "ApartmentnumberID", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "ApartmentnumberID");
            AddForeignKey("dbo.Comments", "ApartmentnumberID", "dbo.Apartmentnumbers", "ApartmentnumberID", cascadeDelete: true);
        }
    }
}
