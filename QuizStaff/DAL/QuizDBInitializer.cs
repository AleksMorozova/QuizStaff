using DomainModel;
using System;
using System.Collections.Generic;
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
            Role mainAdministratorRole = new Role() { Name = "Main Admin", Description = "" };
            mainAdministratorRole.Permissions.Add(createAdministrator);
            context.Roles.Add(mainAdministratorRole);

            Role administratorRole = new Role() { Name = "Admin", Description =""};
            administratorRole.Permissions.Add(editTestee);
            administratorRole.Permissions.Add(editTraining);
            administratorRole.Permissions.Add(editSetting);
            context.Roles.Add(administratorRole);

            Role testeeRole = new Role() { Name = "Testee", Description = "" };
            testeeRole.Permissions.Add(getQuestion);
            context.Roles.Add(testeeRole);

            context.SaveChanges();
            #endregion

            //RolePermission p1 = new RolePermission() { Role = administratorRole, Permission = editSetting };
            //context.RolePermissions.Add(p1);
            //RolePermission p2 = new RolePermission() { Role = administratorRole, Permission = editTestee };
            //context.RolePermissions.Add(p2);
            //RolePermission p3 = new RolePermission() { Role = administratorRole, Permission = editTraining };
            //context.RolePermissions.Add(p3);
            //RolePermission p4 = new RolePermission() { Role = testeeRole, Permission = getQuestion };
            //context.RolePermissions.Add(p4);
            //RolePermission p5 = new RolePermission() { Role = mainAdministratorRole, Permission = createAdministrator };
            //context.RolePermissions.Add(p5);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
