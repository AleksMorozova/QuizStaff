using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    public class EFTrainingRepository : EFRepository<Training>
    {
        public override void Update(Training entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            foreach (var question in entity.Questions)
            {
                if (question.Id == Guid.Empty)
                {
                    dbContext.Entry(question).State = System.Data.Entity.EntityState.Added;
                    foreach (var answer in question.Answers)
                    {
                        dbContext.Entry(answer).State = System.Data.Entity.EntityState.Added;
                    }
                }
                
                else 
                {
                    dbContext.Entry(question).State = System.Data.Entity.EntityState.Modified;

                    foreach (var answer in question.Answers)
                    {
                         dbContext.Entry(answer).State = answer.Id == Guid.Empty 
                             ? System.Data.Entity.EntityState.Added
                             : System.Data.Entity.EntityState.Modified;
                    }
                }
            }
            
            dbContext.SaveChanges();
        }
    }
}
