using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [DataContract]
    public class TesteeAnswer : Entity
    {
        public TesteeAnswer()
        { 
        }

        public virtual ICollection<Answer> Answer { get; set; }
    }
}
