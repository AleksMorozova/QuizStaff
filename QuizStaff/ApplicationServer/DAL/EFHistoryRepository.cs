using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    public class EFHistoryRepository : EFRepository<History>
    {
        public override void Create(History entity)
        {
            dbContext.Entry(entity.Testee).State = System.Data.Entity.EntityState.Unchanged;
            dbContext.Entry(entity.Question).State = System.Data.Entity.EntityState.Unchanged;
            foreach (var a in entity.Answers)
            {
                dbContext.Entry(a).State = System.Data.Entity.EntityState.Added;
                dbContext.Entry(a.Answer).State = System.Data.Entity.EntityState.Unchanged;
            }

            base.Create(entity);
            dbContext.SaveChanges();
        }
    }
}
