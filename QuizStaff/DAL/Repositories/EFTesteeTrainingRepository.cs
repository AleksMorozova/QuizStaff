using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFTesteeTrainingRepository : EFRepository<TesteeTraining>
    {
        public EFTesteeTrainingRepository(QuizDBContext dbContext)
            : base(dbContext)
        {

        }

        public override void Update(TesteeTraining entity)
        {
            var dbTesteeTraining = dbContext.TesteeTrainings
                .Single(testeeTraining => testeeTraining.Id == entity.Id);

            var dbTraining = dbContext.Trainings
                        .Single(t => t.Id == entity.Training.Id);
            entity.Training = dbTraining;
            dbContext.Entry(dbTraining).State = System.Data.Entity.EntityState.Unchanged;

            dbContext.Entry(dbTesteeTraining).CurrentValues.SetValues(entity);
            dbContext.SaveChanges();
        }
    }
}
