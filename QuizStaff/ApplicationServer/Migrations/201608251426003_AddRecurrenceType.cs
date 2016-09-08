namespace ApplicationServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "Recurrence", c => c.Int(nullable: false));
            DropColumn("dbo.Settings", "WithoutEndDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "WithoutEndDate", c => c.Boolean(nullable: false));
            DropColumn("dbo.Settings", "Recurrence");
        }
    }
}
