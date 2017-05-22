using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class RoleDTO 
    {
        public Guid Id { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                }
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != description)
                {
                    description = value;
                }
            }
        }

        private BindingList<PermissionDTO> permissions;
        public virtual BindingList<PermissionDTO> Permissions
        {
            get
            {
                return permissions;
            }
            set
            {
                if (value != permissions)
                {
                    permissions = value;
                }
            }
        }

        public virtual BindingList<TesteeDTO> Testees { get; set; }

        public static implicit operator RoleDTO(Role role)
        {
            RoleDTO newRole = new  RoleDTO();

            newRole.Id = role.Id;
            newRole.Name = role.Name;
            newRole.Description = role.Description;
            newRole.Permissions = new BindingList<PermissionDTO>();

            if (role != null)
            {
                foreach (var permission in role.Permissions)
                {
                    newRole.Permissions.Add((PermissionDTO)permission);
                }
            }
            return newRole;
        }
    }
}
