namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admigra2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Streets", "StreetName", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Streets", "StreetName", c => c.String(maxLength: 20));
        }
    }
}
