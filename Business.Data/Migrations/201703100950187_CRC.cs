namespace Business.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CITATIONs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CIT_NAME = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.REFERENCES",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        REF_NAME = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Order_warehouse", "ReferenceID", c => c.Int(nullable: true));
            AddColumn("dbo.Order_warehouse", "CitationID", c => c.Int(nullable: true));
            CreateIndex("dbo.Order_warehouse", "ReferenceID");
            CreateIndex("dbo.Order_warehouse", "CitationID");
            AddForeignKey("dbo.Order_warehouse", "CitationID", "dbo.CITATIONs", "ID");
            AddForeignKey("dbo.Order_warehouse", "ReferenceID", "dbo.REFERENCES", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order_warehouse", "ReferenceID", "dbo.REFERENCES");
            DropForeignKey("dbo.Order_warehouse", "CitationID", "dbo.CITATIONs");
            DropIndex("dbo.Order_warehouse", new[] { "CitationID" });
            DropIndex("dbo.Order_warehouse", new[] { "ReferenceID" });
            DropColumn("dbo.Order_warehouse", "CitationID");
            DropColumn("dbo.Order_warehouse", "ReferenceID");
            DropTable("dbo.REFERENCES");
            DropTable("dbo.CITATIONs");
        }
    }
}
