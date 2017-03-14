namespace Business.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassType1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.REGISTRATIONs", "IsNewsletter");
            DropColumn("dbo.REGISTRATIONs", "IsAgree");
        }
        
        public override void Down()
        {
            AddColumn("dbo.REGISTRATIONs", "IsAgree", c => c.Boolean(nullable: false));
            AddColumn("dbo.REGISTRATIONs", "IsNewsletter", c => c.Boolean(nullable: false));
        }
    }
}
