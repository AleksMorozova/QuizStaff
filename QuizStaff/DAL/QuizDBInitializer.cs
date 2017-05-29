using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class QuizDBInitializer : CreateDatabaseIfNotExists<QuizDBContext>
    {
        protected override void Seed(QuizDBContext context)
        {
            #region add permissions
            Permission createAdministrator = new Permission() { Title = "Create administrator", Type = PermissionType.CreateAdministrator };
            context.Permissions.Add(createAdministrator);

            Permission editSetting = new Permission() { Title = "Edit setting", Type = PermissionType.EditSetUp };
            context.Permissions.Add(editSetting);

            Permission editTestee = new Permission() { Title = "Edit testee", Type = PermissionType.EditTestee };
            context.Permissions.Add(editTestee);

            Permission editTraining = new Permission() { Title = "Edit training", Type = PermissionType.EditTraining };
            context.Permissions.Add(editTraining);

            Permission getQuestion = new Permission() { Title = "Get question", Type = PermissionType.GetQuestion };
            context.Permissions.Add(getQuestion);

            context.SaveChanges();
            #endregion

            #region add roles
            Role mainAdministratorRole = new Role() { Name = "Super administrator", Description = "" };
            context.Roles.Add(mainAdministratorRole);

            Role administratorRole = new Role() { Name = "Admin", Description = "" };
            context.Roles.Add(administratorRole);

            Role testeeRole = new Role() { Name = "Testee", Description = "" };
            context.Roles.Add(testeeRole);

            context.SaveChanges();
            #endregion

            RolePermission p1 = new RolePermission() { Permission = editSetting, Role = administratorRole};
            context.RolePermissions.Add(p1);
            RolePermission p2 = new RolePermission() { Permission = editTestee, Role = administratorRole };
            context.RolePermissions.Add(p2);
            RolePermission p3 = new RolePermission() { Permission = editTraining, Role = administratorRole };
            context.RolePermissions.Add(p3);
            RolePermission p4 = new RolePermission() { Permission = getQuestion, Role = testeeRole };
            context.RolePermissions.Add(p4);
            RolePermission p5 = new RolePermission() { Permission = createAdministrator, Role = mainAdministratorRole };
            context.RolePermissions.Add(p5);
            context.SaveChanges();

            DaysOfUpdate monday = new DaysOfUpdate() { Day = DayOfWeek.Monday, IsSelect = false };
            context.DaysOfUpdate.Add(monday);
            DaysOfUpdate tuesday = new DaysOfUpdate() { Day = DayOfWeek.Tuesday, IsSelect = true };
            context.DaysOfUpdate.Add(tuesday);
            DaysOfUpdate wednesday = new DaysOfUpdate() { Day = DayOfWeek.Wednesday, IsSelect = false };
            context.DaysOfUpdate.Add(wednesday);
            DaysOfUpdate thursday = new DaysOfUpdate() { Day = DayOfWeek.Thursday, IsSelect = false };
            context.DaysOfUpdate.Add(thursday);
            DaysOfUpdate friday = new DaysOfUpdate() { Day = DayOfWeek.Friday, IsSelect = false };
            context.DaysOfUpdate.Add(friday);
            DaysOfUpdate sunday = new DaysOfUpdate() { Day = DayOfWeek.Sunday, IsSelect = false };
            context.DaysOfUpdate.Add(sunday);
            DaysOfUpdate saturday = new DaysOfUpdate() { Day = DayOfWeek.Saturday, IsSelect = false };
            context.DaysOfUpdate.Add(saturday);
            context.SaveChanges();

            ApplicationSettings settings = new ApplicationSettings();
       
            settings.AdditionalQuestionsPath = @"C:\QuizTrainings\GeneralQuestions";
            settings.LMSReportFileName = "ISD_Report.xlsx";
            settings.LMSReportPath = @"C:\QuizTrainings";
            settings.TimeOfUpdating = DateTime.Now;
            settings.TrainingsQuestionsPath = @"C:\QuizTrainings\Questions";
            settings.Days = new BindingList<DaysOfUpdate>();
            settings.Days.Add(monday);
            settings.Days.Add(tuesday);
            settings.Days.Add(thursday);
            settings.Days.Add(friday);
            settings.Days.Add(saturday);
            settings.Days.Add(sunday);

            context.ApplicationSettings.Add(settings);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
