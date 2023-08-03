namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Apartmentnumbers", "Apartmentnumber_ApartmentnumberID", "dbo.Apartmentnumbers");
            DropForeignKey("dbo.Apartmentnumbers", "Comment_CommentID", "dbo.Comments");
            DropForeignKey("dbo.Users", "Comment_CommentID", "dbo.Comments");
            DropForeignKey("dbo.Comments", "Apartmentnumber_ApartmentnumberID", "dbo.Apartmentnumbers");
            DropForeignKey("dbo.Comments", "User_UserID", "dbo.Users");
            DropIndex("dbo.Apartmentnumbers", new[] { "Apartmentnumber_ApartmentnumberID" });
            DropIndex("dbo.Apartmentnumbers", new[] { "Comment_CommentID" });
            DropIndex("dbo.Comments", new[] { "Apartmentnumber_ApartmentnumberID" });
            DropIndex("dbo.Comments", new[] { "User_UserID" });
            DropIndex("dbo.Users", new[] { "Comment_CommentID" });
            DropColumn("dbo.Comments", "ApartmentnumberID");
            DropColumn("dbo.Comments", "UserID");
            RenameColumn(table: "dbo.Comments", name: "Apartmentnumber_ApartmentnumberID", newName: "ApartmentnumberID");
            RenameColumn(table: "dbo.Comments", name: "User_UserID", newName: "UserID");
            AlterColumn("dbo.Comments", "ApartmentnumberID", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "UserID");
            CreateIndex("dbo.Comments", "ApartmentnumberID");
            CreateIndex("dbo.Points", "UserID");
            AddForeignKey("dbo.Points", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "ApartmentnumberID", "dbo.Apartmentnumbers", "ApartmentnumberID", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            DropColumn("dbo.Apartmentnumbers", "Apartmentnumber_ApartmentnumberID");
            DropColumn("dbo.Apartmentnumbers", "Comment_CommentID");
            DropColumn("dbo.Users", "Comment_CommentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Comment_CommentID", c => c.Int());
            AddColumn("dbo.Apartmentnumbers", "Comment_CommentID", c => c.Int());
            AddColumn("dbo.Apartmentnumbers", "Apartmentnumber_ApartmentnumberID", c => c.Int());
            DropForeignKey("dbo.Comments", "UserID", "dbo.Users");
            DropForeignKey("dbo.Comments", "ApartmentnumberID", "dbo.Apartmentnumbers");
            DropForeignKey("dbo.Points", "UserID", "dbo.Users");
            DropIndex("dbo.Points", new[] { "UserID" });
            DropIndex("dbo.Comments", new[] { "ApartmentnumberID" });
            DropIndex("dbo.Comments", new[] { "UserID" });
            AlterColumn("dbo.Comments", "UserID", c => c.Int());
            AlterColumn("dbo.Comments", "ApartmentnumberID", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "UserID", newName: "User_UserID");
            RenameColumn(table: "dbo.Comments", name: "ApartmentnumberID", newName: "Apartmentnumber_ApartmentnumberID");
            AddColumn("dbo.Comments", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "ApartmentnumberID", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "Comment_CommentID");
            CreateIndex("dbo.Comments", "User_UserID");
            CreateIndex("dbo.Comments", "Apartmentnumber_ApartmentnumberID");
            CreateIndex("dbo.Apartmentnumbers", "Comment_CommentID");
            CreateIndex("dbo.Apartmentnumbers", "Apartmentnumber_ApartmentnumberID");
            AddForeignKey("dbo.Comments", "User_UserID", "dbo.Users", "UserID");
            AddForeignKey("dbo.Comments", "Apartmentnumber_ApartmentnumberID", "dbo.Apartmentnumbers", "ApartmentnumberID");
            AddForeignKey("dbo.Users", "Comment_CommentID", "dbo.Comments", "CommentID");
            AddForeignKey("dbo.Apartmentnumbers", "Comment_CommentID", "dbo.Comments", "CommentID");
            AddForeignKey("dbo.Apartmentnumbers", "Apartmentnumber_ApartmentnumberID", "dbo.Apartmentnumbers", "ApartmentnumberID");
        }
    }
}
