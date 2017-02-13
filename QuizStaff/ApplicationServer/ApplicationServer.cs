using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizServer;
using Services.Contracts;
using Services.Implementation;
using DAL.Repositories;
using System.ServiceModel;

namespace ApplicationServer
{
    [ServiceBehavior]
    public class ApplicationServer : IApplicationServer
    {
        public ApplicationServer()
        {

        }

        # region Testee 

        public List<TesteeDTO> GetAllTestees()
        {
            return RegistrateDependencies.TesteeService.GetAllTestees(Program.dbContext);
        }

        public TesteeDTO FindByLogin(string login)
        {
            return RegistrateDependencies.TesteeService.FindByLogin(Program.dbContext, login);
        }

        public TesteeDTO SaveTestee(TesteeDTO testee)
        {
            return (testee.Id == Guid.Empty)
                ? RegistrateDependencies.TesteeService.SaveTestee(Program.dbContext, testee)
                : RegistrateDependencies.TesteeService.UpdateTestee(Program.dbContext, testee);
        }

        #endregion

        #region Training

        public List<TrainingDTO> GetAllTrainings()
        {
            return RegistrateDependencies.TrainingService.GetAllTrainings(Program.dbContext);
        }

        public List<TrainingDTO> GetAllActiveTrainings()
        {
            return RegistrateDependencies.TrainingService.GetAllActiveTrainings(Program.dbContext);
        }

        public TrainingDTO SaveTraining(TrainingDTO training)
        {
            return (training.Id == Guid.Empty)
                ? RegistrateDependencies.TrainingService.SaveTraining(Program.dbContext, training)
                : RegistrateDependencies.TrainingService.UpdateTraining(Program.dbContext, training);
        }

        public TrainingDTO FindByTitle(string title)
        {
            return RegistrateDependencies.TrainingService.FindByTitle(Program.dbContext, title);
        }
        #endregion

        #region Question

        public void SaveQuestion(QuestionDTO question)
        {
            RegistrateDependencies.QuestionService.UpdateQuestion(Program.dbContext, question);
        }

        public QuestionDTO GetRandomQuestionForTestee(Guid id)
        {
            return RegistrateDependencies.QuestionService.GetRandomQuestionForTestee(Program.dbContext, id);
        }

        public void UpdateAnswer(AnswerDTO answer)
        {
            RegistrateDependencies.QuestionService.UpdateAnswer(Program.dbContext, answer);
        }

        #endregion Question

        #region ApplicationSettings
        public ApplicationSettingsDTO GetApplicationSettings()
        {
            return RegistrateDependencies.ApplicationSettingsService.GetSettings(Program.dbContext);
        }

        public ApplicationSettingsDTO SaveApplicationSettings(ApplicationSettingsDTO setting)
        {
            return (setting.Id == Guid.Empty)
             ? RegistrateDependencies.ApplicationSettingsService.SaveApplicationSettings(Program.dbContext, setting)
             : RegistrateDependencies.ApplicationSettingsService.UpdateApplicationSettings(Program.dbContext, setting);
        }

        #endregion

        #region Role

        public List<RoleDTO> GetAllRoles()
        {
            return RegistrateDependencies.RoleService.GetAllRoles(Program.dbContext);
        }

        public List<PermissionDTO> GetAllPermissions()
        {
            return RegistrateDependencies.RoleService.GetAllPermissions(Program.dbContext);
        }

        public void SaveRole(RoleDTO role)
        {
            if (role.Id == Guid.Empty)
            {
                RegistrateDependencies.RoleService.SaveRole(Program.dbContext, role);
            }
            else
            {
                RegistrateDependencies.RoleService.UpdateRole(Program.dbContext, role);
            }
        }
        #endregion

        #region Write loaded information

        public void LoadTrainings()
        {
            RegistrateDependencies.LoaderService.LoadTrainings(Program.dbContext);
        }

        public void LoadTesteeFromEPE()
        {
            var loadedTestees = EPELoader.LoadTesteeFromEPE();
            RegistrateDependencies.LoaderService.SynchronizeTestees(Program.dbContext, loadedTestees);
        }

        public void LoadAdditionalQuestions()
        {
            RegistrateDependencies.LoaderService.LoadAdditionalQuestions(Program.dbContext);
        }

        #endregion

        #region TesteeSettings

        public void UpdateSettings(SettingDTO[] settings)
        {
            RegistrateDependencies.TesteeSettingsService.UpdateSettings(Program.dbContext, settings);
        }

        public void UpdateTesteeTrainings(TesteeTrainingDTO[] testeeTrainings)
        {
            RegistrateDependencies.TesteeSettingsService.UpdateTesteeTrainings(Program.dbContext, testeeTrainings);
        }

        #endregion

        #region TesteeAnswer

        public void SaveTesteeAnswer(HistoryDTO history)
        {
            RegistrateDependencies.HistoryService.SaveTesteeAnswer(Program.dbContext, history);
        }

        #endregion

        #region Testee Training

        public void UpdateTesteeTraining(TesteeTrainingDTO testeeTraining)
        {
            RegistrateDependencies.TesteeTrainingService.UpdateTesteeTraining(Program.dbContext, testeeTraining);
        }

        #endregion
    }
}
