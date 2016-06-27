using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class TesteeTraining: Entity
    {
        public virtual Testee Testee { get; set; }
        public virtual Training Training { get; set; }
        public bool IsActive { get; set; }
    }
}
