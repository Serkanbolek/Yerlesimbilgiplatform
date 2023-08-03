namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmig5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserImage", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserImage", c => c.String(maxLength: 100));
        }
    }
}
