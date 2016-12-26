using DomainModel;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFTesteeRepository : EFRepository<Testee>
    {

        public EFTesteeRepository(QuizDBContext dbContext)
            : base(dbContext)
        {

        }

        public override void Update(Testee entity)
        {
            var dbTestee = dbContext.Testees
                .Single(c => c.Id == entity.Id);

            dbContext.Entry(dbTestee).CurrentValues.SetValues(entity);
            dbContext.Entry(dbTestee.UserSetting).CurrentValues.SetValues(entity.UserSetting);

            if (entity.Roles != null)
                foreach (var role in entity.Roles)
                {
                    if (role.Id != Guid.Empty)
                    {
                        var dbRole = dbContext.TesteeRoles
                            .Single(t => t.Id == role.Id);
                        dbRole.IsActive = role.IsActive;
                        dbContext.Entry(dbRole).CurrentValues.SetValues(role);
                    }
                }

            if (entity.Trainings != null)
                foreach (var training in entity.Trainings)
                {
                    if (training.Id != Guid.Empty)
                    {
                        var dbTraining = dbContext.TesteeTrainings
                            .Single(t => t.Id == training.Id);

                        dbContext.Entry(dbTraining).CurrentValues.SetValues(training);
                    }
                    else
                    {
                        var dbTraining = dbContext.Trainings
                            .Single(t => t.Id == training.Training.Id);
                        training.Training = dbTraining;
                        dbContext.Entry(dbTraining).State = System.Data.Entity.EntityState.Unchanged;
                        dbTestee.Trainings.Add(training);
                    }
                }

            dbContext.SaveChanges();
        }
    }
}