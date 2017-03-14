namespace Business.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class H_Reg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HOW_YOU_KNOW",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.REGISTRATIONs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Full_Name = c.String(),
                        Email_Address = c.String(),
                        Username = c.String(),
                        Password = c.Byte(nullable: false),
                        CountryID = c.Int(nullable: false),
                        Phone_Number = c.String(),
                        How_You_KnowID = c.Int(nullable: true),
                        IsNewsletter = c.Boolean(nullable: true),
                        IsAgree = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HOW_YOU_KNOW", t => t.How_You_KnowID)
                .ForeignKey("dbo.TBL_COUNTRY", t => t.CountryID)
                .Index(t => t.CountryID)
                .Index(t => t.How_You_KnowID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.REGISTRATIONs", "CountryID", "dbo.TBL_COUNTRY");
            DropForeignKey("dbo.REGISTRATIONs", "How_You_KnowID", "dbo.HOW_YOU_KNOW");
            DropIndex("dbo.REGISTRATIONs", new[] { "How_You_KnowID" });
            DropIndex("dbo.REGISTRATIONs", new[] { "CountryID" });
            DropTable("dbo.REGISTRATIONs");
            DropTable("dbo.HOW_YOU_KNOW");
        }
    }
}
