using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFApplicationSettingsRepository : EFRepository<ApplicationSettings>
    {
        public EFApplicationSettingsRepository(QuizDBContext dbContext)
            : base(dbContext)
        {

        }

        public override void Update(ApplicationSettings entity)
        {
            var dbTApplicationSettings = dbContext.ApplicationSettings
                .Single(applicationSettings => applicationSettings.Id == entity.Id);

            dbContext.Entry(dbTApplicationSettings).CurrentValues.SetValues(entity);

            if (entity.Days != null)
                foreach (var day in entity.Days)
                {
                    if (day.Id != Guid.Empty)
                    {
                        var dbDay = dbContext.DaysOfUpdate
                            .Single(t => t.Id == day.Id);
                        dbDay.IsSelect = day.IsSelect;
                        dbContext.Entry(dbDay).CurrentValues.SetValues(day);
                    }
                }

            dbContext.SaveChanges();
        }
    }
}
