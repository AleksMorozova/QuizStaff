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

            foreach (var item in entity.Questions)
            {
                dbContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
            }

            dbContext.SaveChanges();
        }
    }
}
