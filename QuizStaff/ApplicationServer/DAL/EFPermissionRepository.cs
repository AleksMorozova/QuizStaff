using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    public class EFPermissionRepository : EFRepository<Permission>
    {
        public override void Update(Permission entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public override void Create(Permission entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Added;
            dbContext.SaveChanges();
        }
    }
}