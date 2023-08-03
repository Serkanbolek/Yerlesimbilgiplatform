namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migadd6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "UserID", "dbo.Users");
            DropIndex("dbo.Comments", new[] { "UserID" });
            AddColumn("dbo.Users", "CommentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "CommentID");
            AddForeignKey("dbo.Users", "CommentID", "dbo.Comments", "CommentID", cascadeDelete: true);
            DropColumn("dbo.Comments", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "UserID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "CommentID", "dbo.Comments");
            DropIndex("dbo.Users", new[] { "CommentID" });
            DropColumn("dbo.Users", "CommentID");
            CreateIndex("dbo.Comments", "UserID");
            AddForeignKey("dbo.Comments", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
