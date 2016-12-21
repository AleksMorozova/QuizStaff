using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFHistoryRepository : EFRepository<History>
    {
        public EFHistoryRepository(QuizDBContext dbContext)
            : base(dbContext)
        {

        }

        public override void Create(History entity)
        {
            var dbTestee = dbContext.Testees
                            .Single(t => t.Id == entity.Testee.Id);
            entity.Testee = dbTestee;
            dbContext.Entry(dbTestee).State = System.Data.Entity.EntityState.Unchanged;

            var dbQuestion = dbContext.Questions
                          .Single(t => t.Id == entity.Question.Id);
            entity.Question = dbQuestion;
            dbContext.Entry(dbQuestion).State = System.Data.Entity.EntityState.Unchanged;


            var answers = entity.Answers;
            entity.Answers = new System.ComponentModel.BindingList<TesteeAnswer>();
            foreach (var a in answers)
            {
                var dbAnswers = dbContext.Answers
                            .Single(t => t.Id == a.Answer.Id);
                a.Answer = dbAnswers;
                dbContext.Entry(dbAnswers).State = System.Data.Entity.EntityState.Unchanged;
                entity.Answers.Add(a);
            }

            dbContext.Histories.Add(entity);
            dbContext.SaveChanges();
        }
    }
}
