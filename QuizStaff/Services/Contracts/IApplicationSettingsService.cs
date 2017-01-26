using DAL;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IApplicationSettingsService
    {
        ApplicationSettingsDTO GetSettings(QuizDBContext dbContext);

        ApplicationSettingsDTO SaveApplicationSettings(QuizDBContext dbContext, ApplicationSettingsDTO setting);

        ApplicationSettingsDTO UpdateApplicationSettings(QuizDBContext dbContext, ApplicationSettingsDTO setting);
    }
}
