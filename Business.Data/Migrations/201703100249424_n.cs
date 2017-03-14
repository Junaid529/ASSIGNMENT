namespace Business.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Order_warehouse", "Country_ID", "dbo.TBL_COUNTRY");
            DropIndex("dbo.Order_warehouse", new[] { "Country_ID" });
        }
        
        public override void Down()
        {
            AddColumn("dbo.Order_warehouse", "Country_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Order_warehouse", "Country_ID");
            AddForeignKey("dbo.Order_warehouse", "Country_ID", "dbo.TBL_COUNTRY", "ID");
        }
    }
}
