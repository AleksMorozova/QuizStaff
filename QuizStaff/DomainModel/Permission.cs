﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Permission : Entity
    {
        public Permission()
        {
            Roles = new BindingList<RolePermission>();
        }
        public virtual string Title { get; set; }
        public virtual BindingList<RolePermission> Roles { get; set; }
        public virtual PermissionType Type { get; set; }
    }
}
