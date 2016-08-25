using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
     public enum RecurrenceType
     {
         None = -1,
         WithoutEnding = 0,
         WithExactRepeated = 1,
         WithSpecifiedEndDate = 2,
    }
}
