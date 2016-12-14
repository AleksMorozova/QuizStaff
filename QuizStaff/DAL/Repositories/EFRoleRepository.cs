using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFRoleRepository : EFRepository<Role>
    {
        public EFRoleRepository(QuizDBContext dbContext)
            : base(dbContext)
        {

        }

        public override void Update(Role entity)
        {
            var dbRole = dbContext.Roles
              .Single(c => c.Id == entity.Id);

            dbContext.Entry(dbRole).CurrentValues.SetValues(entity);

            if (entity.Permissions != null)
                foreach (var permission in entity.Permissions)
                {
                    if (permission.Id != Guid.Empty)
                    {
                        var dbPermission = dbContext.RolePermissions
                            .Single(t => t.Id == permission.Id);

                        dbContext.Entry(dbPermission).CurrentValues.SetValues(permission);
                    }
                    else
                    {
                        var dbPermissin = dbContext.Permissions
                            .Single(t => t.Id == permission.Permission.Id);
                        permission.Permission = dbPermissin;
                        dbContext.Entry(dbPermissin).State = System.Data.Entity.EntityState.Unchanged;
                        dbRole.Permissions.Add(permission);
                    }
                }

            dbContext.SaveChanges();
        }
    }
}