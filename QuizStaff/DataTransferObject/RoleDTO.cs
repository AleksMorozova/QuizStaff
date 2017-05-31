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
        public RoleDTO()
        {
            Permissions = new BindingList<RolePermissionDTO>();
            Testees = new BindingList<TesteeDTO>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual BindingList<RolePermissionDTO> Permissions { get; set; }
        public virtual BindingList<TesteeDTO> Testees { get; set; }

        public static implicit operator RoleDTO(Role role)
        {
            RoleDTO newRole = new  RoleDTO();

            newRole.Id = role.Id;
            newRole.Name = role.Name;
            newRole.Description = role.Description;
            newRole.Permissions = new BindingList<RolePermissionDTO>();

            if (role != null)
            {
                foreach (var permission in role.Permissions)
                {
                    newRole.Permissions.Add((RolePermissionDTO)permission);
                }
            }
            return newRole;
        }
    }
}
