using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class TesteeAnswer : Entity
    {
        public virtual History History { get; set; }
        public virtual Answer Answer { get; set; }
    }
}
