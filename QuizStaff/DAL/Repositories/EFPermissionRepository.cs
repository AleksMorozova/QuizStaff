using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFPermissionRepository : EFRepository<Permission>
    {
        public EFPermissionRepository(QuizDBContext dbContext)
            : base(dbContext)
        {

        }

        public override void Update(Permission entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}