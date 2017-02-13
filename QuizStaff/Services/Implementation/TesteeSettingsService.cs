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
    public class TesteeSettingsService: ITesteeSettingsService
    {
        public void UpdateSettings(QuizDBContext context, SettingDTO[] settings)
        {
            EFSettingRepository repo = new EFSettingRepository(context);
            foreach (var setting in settings.ToList())
            {
                Setting newSetting = new Setting();
                newSetting.Id = setting.Id;
                newSetting.Hours = setting.Hours;
                newSetting.Minutes = setting.Minutes;
                newSetting.Seconds = setting.Seconds;
                newSetting.EndDate = DateTime.Now;
                newSetting.Recurrence = setting.Recurrence;
                newSetting.AmountOfQuestionsPerDay = setting.AmountOfQuestionsPerDay;
                newSetting.TimeOfStart = setting.TimeOfStart;
                newSetting.CanUserEdit = setting.CanUserEdit;
                newSetting.ShowCorrectAnswer = setting.ShowCorrectAnswer;

                repo.Update(newSetting);
            }
        }

        public void UpdateTesteeTrainings(QuizDBContext context, TesteeTrainingDTO[] testeeTrainings)
        {
            EFTesteeTrainingRepository repo = new EFTesteeTrainingRepository(context);
            foreach (var testeeTraining in testeeTrainings)
            {
                TesteeTraining updateTesteeTraining = Conversion.ConvertTesteeTrainingFromDTO(testeeTraining);
                repo.Update(updateTesteeTraining);
            }
        }

    }
}
