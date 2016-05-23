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
        string GetData(int value);

        [OperationContract]
        List<TesteeDTO> GetAllTestees(); 
        
        [OperationContract]
        void SaveAllTestees(ICollection<TesteeDTO> testees);

        [OperationContract]
        Testee GetTestee();

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
        TrainingDTO GetTraining(Guid id);
         
        [OperationContract]
        TesteeDTO FindByLogin(string login);

        [OperationContract]
        QuestionDTO GetQuestion(Guid id);

        [OperationContract]
        void SaveAnswer(QuestionDTO question);

        [OperationContract]
        void SaveAnswer(TrainingDTO training);
    }
   
}
