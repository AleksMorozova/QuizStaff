using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFTrainingRepository : EFRepository<Training>
    {
        public EFTrainingRepository(QuizDBContext dbContext)
            : base(dbContext)
        {

        }

        public override void Update(Training entity)
        {

            var dbTraining = dbContext.Trainings
               .Single(c => c.Id == entity.Id);

            dbContext.Entry(dbTraining).CurrentValues.SetValues(entity);

            if (entity.Questions != null)
                foreach (var question in entity.Questions)
                {
                    if (question.Id != Guid.Empty)
                    {
                        var dbQuestion = dbContext.Questions
                            .Single(t => t.Id == question.Id);

                        dbContext.Entry(dbQuestion).CurrentValues.SetValues(question);

                        foreach (var answer in question.Answers)
                        {
                            if (answer.Id != Guid.Empty)
                            {
                                var dbAnswer = dbContext.Answers
                                .Single(t => t.Id == answer.Id);

                                dbContext.Entry(dbAnswer).CurrentValues.SetValues(answer);
                            
                            }
                            else
                            {
                                dbQuestion.Answers.Add(answer);
                            }
                        }
                    }
                    else
                    {
                        dbContext.Entry(dbTraining).State = System.Data.Entity.EntityState.Unchanged;
                        dbTraining.Questions.Add(question);
                    }
                }
            dbContext.SaveChanges();
        }
    }
}
