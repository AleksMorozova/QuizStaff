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
        List<TrainingDTO> GetAllTrainings();

        [OperationContract]
        List<TrainingDTO> GetAllActiveTrainings();

        [OperationContract]
        TrainingDTO SaveTraining(TrainingDTO training);

        [OperationContract]
        TrainingDTO FindByTitle(string title);

        #endregion

        #region Question

        [OperationContract]
        void SaveQuestion(QuestionDTO question);

        [OperationContract]
        QuestionDTO GetRandomQuestionForTestee(Guid id);

        [OperationContract]
        void UpdateAnswer(AnswerDTO answer);

        #endregion Question

        #region ApplicationSettings

        [OperationContract]
        ApplicationSettingsDTO GetApplicationSettings();

        [OperationContract]
        ApplicationSettingsDTO SaveApplicationSettings(ApplicationSettingsDTO setting);

        #endregion

        #region Role

        [OperationContract]
        List<RoleDTO> GetAllRoles();

        [OperationContract]
        List<PermissionDTO> GetAllPermissions();

        [OperationContract]
        void SaveRole(RoleDTO role);

        #endregion

        #region Write loaded information

        [OperationContract]
        void LoadTrainings();

        [OperationContract]
        void LoadTesteeFromEPE();

        [OperationContract]
        void LoadAdditionalQuestions();

        #endregion

        #region TesteeSettings

        [OperationContract]
        void UpdateSettings(SettingDTO[] settings);

        [OperationContract]
        void UpdateTesteeTrainings(TesteeTrainingDTO[] testeeTrainings);

        #endregion

        #region TesteeAnswer

        [OperationContract]
        void SaveTesteeAnswer(HistoryDTO history);

        #endregion

        #region Testee Training

        [OperationContract]
        void UpdateTesteeTraining(TesteeTrainingDTO testeeTraining);

        #endregion
    }
}
