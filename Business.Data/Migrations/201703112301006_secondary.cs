namespace Business.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LANGUAGEs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DESCRIPTION = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Order_warehouse", "LanguageID", c => c.Int(nullable: true));
            CreateIndex("dbo.Order_warehouse", "LanguageID");
            AddForeignKey("dbo.Order_warehouse", "LanguageID", "dbo.LANGUAGEs", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order_warehouse", "LanguageID", "dbo.LANGUAGEs");
            DropIndex("dbo.Order_warehouse", new[] { "LanguageID" });
            DropColumn("dbo.Order_warehouse", "LanguageID");
            DropTable("dbo.LANGUAGEs");
        }
    }
}
