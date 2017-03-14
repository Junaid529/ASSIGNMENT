namespace Business.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order_warehouse", "CountryID", c => c.Int());
            CreateIndex("dbo.Order_warehouse", "CountryID");
            AddForeignKey("dbo.Order_warehouse", "CountryID", "dbo.TBL_COUNTRY", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order_warehouse", "CountryID", "dbo.TBL_COUNTRY");
            DropIndex("dbo.Order_warehouse", new[] { "CountryID" });
            DropColumn("dbo.Order_warehouse", "CountryID");
        }
    }
}
