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
            foreach (var item in entity.Questions)
            {
                
                if (item.Id == Guid.Empty)
                {
                    foreach (var answer in item.Answers)
                    {
                        dbContext.Entry(item).State = System.Data.Entity.EntityState.Added;
                    }

                    dbContext.Entry(item).State = System.Data.Entity.EntityState.Added;   
                }
                else
                {
                    foreach (var answer in item.Answers)
                    {
                        dbContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    }

                    dbContext.Entry(item).State = System.Data.Entity.EntityState.Modified;   
                }
            }

            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
