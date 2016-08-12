using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    public class EFTesteeRepository : EFRepository<Testee>
    {
        public override void Update(Testee entity)
        {     
            dbContext.Entry(entity.UserSetting).State = System.Data.Entity.EntityState.Modified;

            if (entity.Trainings!=null)
            foreach (var training in entity.Trainings)
            {
                dbContext.Entry(training).State = training.Id == Guid.Empty
                    ? System.Data.Entity.EntityState.Added
                    : System.Data.Entity.EntityState.Modified;

                dbContext.Entry(training.Training).State = System.Data.Entity.EntityState.Unchanged;
            }

            foreach (var role in entity.Roles)
            {
                if (role.Id == Guid.Empty)
                    dbContext.Entry(role).State = System.Data.Entity.EntityState.Added;
                else
                    dbContext.Entry(role).State = System.Data.Entity.EntityState.Modified;
            }

            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
