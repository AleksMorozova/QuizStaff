namespace ApplicationServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateParametersOfAskingQuestion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "Hours", c => c.Int(nullable: false));
            AddColumn("dbo.Settings", "Minutes", c => c.Int(nullable: false));
            AddColumn("dbo.Settings", "Seconds", c => c.Int(nullable: false));
            AddColumn("dbo.Settings", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Settings", "EndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Settings", "WithoutEndDate", c => c.Boolean(nullable: false));
            DropColumn("dbo.Settings", "FrequencyOfAsking");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "FrequencyOfAsking", c => c.Int(nullable: false));
            DropColumn("dbo.Settings", "WithoutEndDate");
            DropColumn("dbo.Settings", "EndDate");
            DropColumn("dbo.Settings", "StartDate");
            DropColumn("dbo.Settings", "Seconds");
            DropColumn("dbo.Settings", "Minutes");
            DropColumn("dbo.Settings", "Hours");
        }
    }
}
