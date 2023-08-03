namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admig4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "CommentContents", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentContents", c => c.String(maxLength: 500));
        }
    }
}
