using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Role : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual BindingList<RolePermission> Permissions { get; set; }
        public virtual BindingList<Testee> Testees { get; set; }
    }
}
