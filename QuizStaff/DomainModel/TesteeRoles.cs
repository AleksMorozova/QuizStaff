using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class TesteeRoles : Entity
    {
        public virtual Testee Testee { get; set; }
        public virtual Role Role { get; set; }
        public bool IsActive { get; set; }
    }
}
