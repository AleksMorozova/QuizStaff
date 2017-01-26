using DAL;
using DAL.Repositories;
using DataTransferObject;
using DomainModel;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class ApplicationSettingsService: IApplicationSettingsService
    {
        public ApplicationSettingsDTO GetSettings(QuizDBContext dbContext)
        {
            EFApplicationSettingsRepository repo = new EFApplicationSettingsRepository(dbContext);
            var setting = repo.ReadAll().FirstOrDefault();
            return Conversion.ConvertApplicationSettingsToDTO(setting);
        }

        public ApplicationSettingsDTO SaveApplicationSettings(QuizDBContext dbContext, ApplicationSettingsDTO setting)
        {
            EFApplicationSettingsRepository repo = new EFApplicationSettingsRepository(dbContext);
            ApplicationSettings savedSettings = Conversion.ConvertApplicationSettingsFromDTO(setting);
            repo.Create(savedSettings);
            return Conversion.ConvertApplicationSettingsToDTO(savedSettings);
        }

        public ApplicationSettingsDTO UpdateApplicationSettings(QuizDBContext dbContext, ApplicationSettingsDTO setting)
        {
            EFApplicationSettingsRepository repo = new EFApplicationSettingsRepository(dbContext);
            ApplicationSettings savedSettings = Conversion.ConvertApplicationSettingsFromDTO(setting);
            repo.Update(savedSettings);
            return Conversion.ConvertApplicationSettingsToDTO(savedSettings);
        }
    }
}
