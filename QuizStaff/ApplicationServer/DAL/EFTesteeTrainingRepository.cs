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
        //public override void Update(TesteeTraining entity)
        //{
        //    dbContext.Set<TesteeTraining>().AddOrUpdate(entity);
        //    dbContext.SaveChanges();
        //}
    }
}
