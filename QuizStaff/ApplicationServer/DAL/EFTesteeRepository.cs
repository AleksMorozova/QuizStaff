using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    public class EFTesteeRepository : EFRepository<Testee>
    {
        public override void Update(Testee entity)
        {
            //dbContext.Entry(entity.UserSetting).State = EntityState.Detached;
            //dbContext.Entry(entity.UserSetting).State = EntityState.Modified;
            //dbContext.Settings.Attach(entity.UserSetting);

   
            dbContext.Entry(entity.UserSetting).State = EntityState.Modified;

            if (entity.Trainings != null)
                foreach (var training in entity.Trainings)
                {
                    dbContext.Entry(training).State = training.Id == Guid.Empty
                        ? System.Data.Entity.EntityState.Added
                        : System.Data.Entity.EntityState.Modified;

                    dbContext.Entry(training.Training).State = System.Data.Entity.EntityState.Unchanged;
                }

            if (entity.Roles != null)
                foreach (var role in entity.Roles)
                {
                    foreach (var permission in role.Role.Permissions)
                    {
                        dbContext.Entry(permission).State = System.Data.Entity.EntityState.Unchanged;
                    }

                    dbContext.Entry(role.Role).State = System.Data.Entity.EntityState.Unchanged;

                    dbContext.Entry(role).State = role.Id == Guid.Empty
                      ? System.Data.Entity.EntityState.Added
                      : System.Data.Entity.EntityState.Modified;
                }
            dbContext.Testees.Attach(entity);
            //dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public override void Create(Testee entity)
        {
            dbContext.Entry(entity.UserSetting).State = System.Data.Entity.EntityState.Added;

            if (entity.Trainings != null)
                foreach (var training in entity.Trainings)
                {
                    dbContext.Entry(training).State = training.Id == Guid.Empty
                        ? System.Data.Entity.EntityState.Added
                        : System.Data.Entity.EntityState.Modified;

                    dbContext.Entry(training.Training).State = System.Data.Entity.EntityState.Unchanged;
                }

            foreach (var role in entity.Roles)
            {
                foreach (var permission in role.Role.Permissions)
                {
                    dbContext.Entry(permission).State = System.Data.Entity.EntityState.Unchanged;
                }

                dbContext.Entry(role.Role).State = System.Data.Entity.EntityState.Unchanged;

                dbContext.Entry(role).State = role.Id == Guid.Empty
                    ? System.Data.Entity.EntityState.Added
                    : System.Data.Entity.EntityState.Modified;
            }

            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Added;
            dbContext.SaveChanges();
        }
    }
}
