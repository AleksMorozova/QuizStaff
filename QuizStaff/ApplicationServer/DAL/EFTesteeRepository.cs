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
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            foreach (var training in entity.Trainings)
            {
                dbContext.Entry(training).State = training.Id == Guid.Empty
                    ? System.Data.Entity.EntityState.Added
                    : System.Data.Entity.EntityState.Modified;
            }

            dbContext.SaveChanges();
        }
    }
}
