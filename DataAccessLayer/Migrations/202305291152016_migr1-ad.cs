namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr1ad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Neighbourhoods", "NeighbourhoodName", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Neighbourhoods", "NeighbourhoodName", c => c.String(maxLength: 20));
        }
    }
}
