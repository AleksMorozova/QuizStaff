using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;
using DataTransferObject;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IApplicationServer
    {
        [OperationContract]
        List<TesteeDTO> GetAllTestees(); 
        
        [OperationContract]
        void SaveAllTestees(ICollection<TesteeDTO> testees);

        [OperationContract]
        TesteeDTO GetTesteeByID(Guid id);

        [OperationContract]
        Boolean SetUsersSettings(SettingDTO sets, Guid id);

        [OperationContract]
        List<QuestionDTO> GetTrainingQuestions(TrainingDTO training);

        [OperationContract]
        SettingDTO GetUsersSettings(Guid id);
        
        [OperationContract]
        void SaveTesteeAnswer(Guid testeeID, Guid questionID, DateTime date, List<Guid> answersID);

        [OperationContract]
        QuestionDTO GetRandomQuestionForTestee(Guid id);

        [OperationContract]
        string LoginTestee(TesteeDTO testee);

        [OperationContract]
        List<TrainingDTO> GetAllTrainings();

        [OperationContract]
        void SaveAllTrainings(ICollection<TrainingDTO> trainings);
         
        [OperationContract]
        TesteeDTO FindByLogin(string login);

        [OperationContract]
        void SaveAnswer(QuestionDTO question);

        [OperationContract]
        void UpdateTraining(TrainingDTO training);
        
        [OperationContract]
        void SaveTraining(TrainingDTO training);

        [OperationContract]
        void UpdateQuestion(QuestionDTO training);

        [OperationContract]
        void SaveQuestion(QuestionDTO training);
    }
}
