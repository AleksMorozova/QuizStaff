using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFSettingRepository : EFRepository<Setting>
    {
        public EFSettingRepository(QuizDBContext dbContext)
            : base(dbContext)
        {

        }

        public override void Update(Setting entity)
        {
            var dbSetting = dbContext.Settings
                .Single(setting => setting.Id == entity.Id);

            dbContext.Entry(dbSetting).CurrentValues.SetValues(entity);
            dbContext.SaveChanges();
        }
    }
}
