using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IApplicationServer
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Testee> GetAllTestees();
        void SaveAllTestees(List<Testee> testees);

        [OperationContract]
        void SetUsersSettings(UsersSettings sets);
        [OperationContract]
        UsersSettings GetUsersSettings();
        // TODO: Add your service operations here
    }
   
}
