using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    public class EFRoleRepository : EFRepository<Role>
    {
        public override void Update(Role entity)
        {
            if (entity.Permissions != null)
            {
                foreach (var permission in entity.Permissions)
                {
                    dbContext.Entry(permission).State = permission.Id == Guid.Empty
                        ? System.Data.Entity.EntityState.Added
                        : System.Data.Entity.EntityState.Modified;

                    dbContext.Entry(permission.Permission).State = System.Data.Entity.EntityState.Unchanged;
                }
            }


            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public override void Create(Role entity)
        {
            if (entity.Permissions != null)
            {
                foreach (var permission in entity.Permissions)
                {
                    dbContext.Entry(permission).State = permission.Id == Guid.Empty
                        ? System.Data.Entity.EntityState.Added
                        : System.Data.Entity.EntityState.Modified;

                    dbContext.Entry(permission.Permission).State = System.Data.Entity.EntityState.Unchanged;
                }
            }


            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Added;
            dbContext.SaveChanges();
        }
    }
}