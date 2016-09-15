using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public enum ActivityStatus
    {
        None = -1,
        Satisfied = 0,
        Overdue = 1,
        InProgress = 2,
        Assigned = 3
    }
}
