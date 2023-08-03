namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5ad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Districts", "DistrictName", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Districts", "DistrictName", c => c.String(maxLength: 20));
        }
    }
}
