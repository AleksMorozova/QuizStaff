using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Permission : Entity
    {
        public virtual string Title { get; set; }
        public virtual BindingList<Role> Roles { get; set; }
        public virtual PermissionType Type { get; set; }
    }
}
