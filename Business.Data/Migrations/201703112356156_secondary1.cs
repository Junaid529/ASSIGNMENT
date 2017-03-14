namespace Business.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondary1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Order_warehouse", "LanguageID", "dbo.LANGUAGEs");
            DropIndex("dbo.Order_warehouse", new[] { "LanguageID" });
            AlterColumn("dbo.Order_warehouse", "LanguageID", c => c.Int());
            CreateIndex("dbo.Order_warehouse", "LanguageID");
            AddForeignKey("dbo.Order_warehouse", "LanguageID", "dbo.LANGUAGEs", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order_warehouse", "LanguageID", "dbo.LANGUAGEs");
            DropIndex("dbo.Order_warehouse", new[] { "LanguageID" });
            AlterColumn("dbo.Order_warehouse", "LanguageID", c => c.Int(nullable: false));
            CreateIndex("dbo.Order_warehouse", "LanguageID");
            AddForeignKey("dbo.Order_warehouse", "LanguageID", "dbo.LANGUAGEs", "ID", cascadeDelete: true);
        }
    }
}
