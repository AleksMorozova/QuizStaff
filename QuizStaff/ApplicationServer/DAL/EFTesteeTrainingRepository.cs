using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    class EFTesteeTrainingRepository : EFRepository<TesteeTraining>
    {
        public override void Update(TesteeTraining entity)
        {
            //dbContext.Entry(entity.Training).State = System.Data.Entity.EntityState.Unchanged;
            //dbContext.Entry(entity.Testee).State = System.Data.Entity.EntityState.Unchanged;

            dbContext.TesteeTrainings.Attach(entity);
            dbContext.Entry(entity).Property(_ => _.IsSelect).IsModified = true;
            dbContext.SaveChanges();
        }
    }
}
