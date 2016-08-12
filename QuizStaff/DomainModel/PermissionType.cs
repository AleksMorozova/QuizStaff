using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public enum PermissionType
    {
        None = -1,
        EditTestee = 0,
        EditTraining = 1,
        EditSetUp = 2,
        GetQuestion = 3,
        CreateAdministrator = 4
    }
}
