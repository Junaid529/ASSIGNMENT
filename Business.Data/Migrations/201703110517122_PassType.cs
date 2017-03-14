namespace Business.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.REGISTRATIONs", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.REGISTRATIONs", "Password", c => c.Byte(nullable: false));
        }
    }
}
