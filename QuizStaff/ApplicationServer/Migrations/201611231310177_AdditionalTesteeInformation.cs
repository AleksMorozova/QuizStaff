namespace QuizServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalTesteeInformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Testees", "Attribute11", c => c.String());
            AddColumn("dbo.Testees", "Attribute12", c => c.String());
            AddColumn("dbo.Testees", "Attribute13", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Testees", "Attribute13");
            DropColumn("dbo.Testees", "Attribute12");
            DropColumn("dbo.Testees", "Attribute11");
        }
    }
}
