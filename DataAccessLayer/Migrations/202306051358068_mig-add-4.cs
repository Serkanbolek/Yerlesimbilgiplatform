namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migadd4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Comments", "UserID");
            AddForeignKey("dbo.Comments", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            DropColumn("dbo.Users", "ApartmentnumberID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "ApartmentnumberID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Comments", "UserID", "dbo.Users");
            DropIndex("dbo.Comments", new[] { "UserID" });
        }
    }
}
