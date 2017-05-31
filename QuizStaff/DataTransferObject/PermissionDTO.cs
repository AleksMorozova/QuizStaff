using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class PermissionDTO
    {
        public PermissionDTO()
        {
            Roles = new BindingList<RolePermissionDTO>();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual BindingList<RolePermissionDTO> Roles { get; set; }
        public virtual PermissionType Type { get; set; }

        public static implicit operator PermissionDTO(Permission permission)
        {
            PermissionDTO newPermission = new PermissionDTO();
            
            newPermission.Id = permission.Id;
            newPermission.Title = permission.Title;
            newPermission.Type = permission.Type;

            return newPermission;
        }
    }
}
