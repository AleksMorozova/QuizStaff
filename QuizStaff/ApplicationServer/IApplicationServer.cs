using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer
{
    [ServiceContract]
    public interface IApplicationServer
    {
        #region Testee 

        [OperationContract]
        List<TesteeDTO> GetAllTestees();

        [OperationContract]
        TesteeDTO FindByLogin(string login);

        [OperationContract]
        TesteeDTO SaveTestee(TesteeDTO testee);
        #endregion

        #region Training 
        [OperationContract]
        List<TrainingDTO> GetAllActiveTrainings();

        [OperationContract]
        List<TrainingDTO> GetAllTrainings();

        [OperationContract]
        TrainingDTO SaveTraining(TrainingDTO training);

        [OperationContract]
        TrainingDTO FindByTitle(string title);
        #endregion

        [OperationContract]
        void SaveQuestion(QuestionDTO training);

        [OperationContract]
        void SaveTesteeAnswer(HistoryDTO history);

        [OperationContract]
        QuestionDTO GetRandomQuestionForTestee(Guid id);

        [OperationContract]
        void UpdateSettings(SettingDTO[] setting);

        [OperationContract]
        void UpdateTesteeTrainings(TesteeTrainingDTO[] testeeTraining);

        [OperationContract]
        void UpdateTesteeTraining(TesteeTrainingDTO testeeTraining);

        [OperationContract]
        List<RoleDTO> GetAllRoles();

        [OperationContract]
        List<PermissionDTO> GetAllPermissions();

        [OperationContract]
        void UpdateRoles(RoleDTO role);

        [OperationContract]
        void AddTesteeRole(TesteeDTO testee, RoleDTO role);

        [OperationContract]
        void UpdateAnswer(AnswerDTO answer);

        [OperationContract]
        void LoadTrainings();

        [OperationContract]
        void LoadTesteeFromEPE();

        [OperationContract]
        void LoadAdditionalQuestions();

        [OperationContract]
        List<TesteeDTO> GetAllTesteesForReport(DateTime from, DateTime to,
            string Company, string OfficeLoc, string Sector, string Division, string Department, string Position);

        [OperationContract]
        ApplicationSettingsDTO SaveApplicationSettings(ApplicationSettingsDTO settings);

        [OperationContract]
        ApplicationSettingsDTO GetApplicationSettings();
    }
}
