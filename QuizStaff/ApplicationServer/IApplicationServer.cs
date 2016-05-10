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
        Boolean SetUsersSettings(SettingDTO sets, Guid id);

        [OperationContract]
        SettingDTO GetUsersSettings(Guid id);

        List<Question> GetTrainingQuestions(Training training);
        void SaveAllQuestions(Training training, List<Question> questions);

    }
   
}
