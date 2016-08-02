using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class RolePermission: Entity
    {
        public virtual Role Role { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
