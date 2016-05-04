using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [DataContract]
    public class TesteeTraining: Entity
    {
        public Guid TesteeID { get; set; }
        public Guid TrainingID { get; set; }
        public virtual Testee Testee { get; set; }
        public virtual Training Training { get; set; }

        public TesteeTraining()
        { 
        }
    }
}
