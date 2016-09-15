namespace QuizServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDuplicateInformation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Testees", "Password");
            DropColumn("dbo.Settings", "StartDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Testees", "Password", c => c.String());
        }
    }
}
