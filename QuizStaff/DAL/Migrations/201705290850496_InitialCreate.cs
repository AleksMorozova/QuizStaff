namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AnswerText = c.String(),
                        IsCorrect = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Question_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        QuestionText = c.String(),
                        Training_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainings", t => t.Training_Id)
                .Index(t => t.Training_Id);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        TrainingTitle = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsAdditional = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TesteeTrainings",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        IsSelect = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Testee_Id = c.Guid(),
                        Training_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Testees", t => t.Testee_Id)
                .ForeignKey("dbo.Trainings", t => t.Training_Id)
                .Index(t => t.Testee_Id)
                .Index(t => t.Training_Id);
            
            CreateTable(
                "dbo.Testees",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Login = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsSelected = c.Boolean(nullable: false),
                        Attribute1 = c.String(),
                        Attribute2 = c.String(),
                        Attribute3 = c.String(),
                        Attribute4 = c.String(),
                        Attribute5 = c.String(),
                        Attribute6 = c.String(),
                        Attribute7 = c.String(),
                        Attribute8 = c.String(),
                        Attribute9 = c.String(),
                        Attribute10 = c.String(),
                        Attribute11 = c.String(),
                        Attribute12 = c.String(),
                        Attribute13 = c.String(),
                        Role_Id = c.Guid(),
                        UserSetting_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .ForeignKey("dbo.Settings", t => t.UserSetting_Id)
                .Index(t => t.Role_Id)
                .Index(t => t.UserSetting_Id);
            
            CreateTable(
                "dbo.Histories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AnsweringDate = c.DateTime(nullable: false),
                        IsAnswerCorrect = c.Boolean(nullable: false),
                        Question_Id = c.Guid(),
                        Testee_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .ForeignKey("dbo.Testees", t => t.Testee_Id)
                .Index(t => t.Question_Id)
                .Index(t => t.Testee_Id);
            
            CreateTable(
                "dbo.TesteeAnswers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Answer_Id = c.Guid(),
                        History_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.Answer_Id)
                .ForeignKey("dbo.Histories", t => t.History_Id)
                .Index(t => t.Answer_Id)
                .Index(t => t.History_Id);
            
            CreateTable(
                "dbo.TesteeRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        Role_Id = c.Guid(),
                        Testee_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .ForeignKey("dbo.Testees", t => t.Testee_Id)
                .Index(t => t.Role_Id)
                .Index(t => t.Testee_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolePermissions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Permission_Id = c.Guid(),
                        Role_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permissions", t => t.Permission_Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.Permission_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Title = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AmountOfQuestionsPerDay = c.Int(nullable: false),
                        Hours = c.Int(nullable: false),
                        Minutes = c.Int(nullable: false),
                        Seconds = c.Int(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Recurrence = c.Int(nullable: false),
                        TimeOfStart = c.DateTime(nullable: false),
                        CanUserEdit = c.Boolean(nullable: false),
                        ShowCorrectAnswer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ApplicationSettings",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        TimeOfUpdating = c.DateTime(nullable: false),
                        LMSReportFileName = c.String(),
                        LMSReportPath = c.String(),
                        TrainingsQuestionsPath = c.String(),
                        AdditionalQuestionsPath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DaysOfUpdates",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Day = c.Int(nullable: false),
                        IsSelect = c.Boolean(nullable: false),
                        Settings_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationSettings", t => t.Settings_Id)
                .Index(t => t.Settings_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DaysOfUpdates", "Settings_Id", "dbo.ApplicationSettings");
            DropForeignKey("dbo.TesteeTrainings", "Training_Id", "dbo.Trainings");
            DropForeignKey("dbo.Testees", "UserSetting_Id", "dbo.Settings");
            DropForeignKey("dbo.TesteeTrainings", "Testee_Id", "dbo.Testees");
            DropForeignKey("dbo.TesteeRoles", "Testee_Id", "dbo.Testees");
            DropForeignKey("dbo.TesteeRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Testees", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.RolePermissions", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.RolePermissions", "Permission_Id", "dbo.Permissions");
            DropForeignKey("dbo.Histories", "Testee_Id", "dbo.Testees");
            DropForeignKey("dbo.Histories", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.TesteeAnswers", "History_Id", "dbo.Histories");
            DropForeignKey("dbo.TesteeAnswers", "Answer_Id", "dbo.Answers");
            DropForeignKey("dbo.Questions", "Training_Id", "dbo.Trainings");
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropIndex("dbo.DaysOfUpdates", new[] { "Settings_Id" });
            DropIndex("dbo.RolePermissions", new[] { "Role_Id" });
            DropIndex("dbo.RolePermissions", new[] { "Permission_Id" });
            DropIndex("dbo.TesteeRoles", new[] { "Testee_Id" });
            DropIndex("dbo.TesteeRoles", new[] { "Role_Id" });
            DropIndex("dbo.TesteeAnswers", new[] { "History_Id" });
            DropIndex("dbo.TesteeAnswers", new[] { "Answer_Id" });
            DropIndex("dbo.Histories", new[] { "Testee_Id" });
            DropIndex("dbo.Histories", new[] { "Question_Id" });
            DropIndex("dbo.Testees", new[] { "UserSetting_Id" });
            DropIndex("dbo.Testees", new[] { "Role_Id" });
            DropIndex("dbo.TesteeTrainings", new[] { "Training_Id" });
            DropIndex("dbo.TesteeTrainings", new[] { "Testee_Id" });
            DropIndex("dbo.Questions", new[] { "Training_Id" });
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            DropTable("dbo.DaysOfUpdates");
            DropTable("dbo.ApplicationSettings");
            DropTable("dbo.Settings");
            DropTable("dbo.Permissions");
            DropTable("dbo.RolePermissions");
            DropTable("dbo.Roles");
            DropTable("dbo.TesteeRoles");
            DropTable("dbo.TesteeAnswers");
            DropTable("dbo.Histories");
            DropTable("dbo.Testees");
            DropTable("dbo.TesteeTrainings");
            DropTable("dbo.Trainings");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
