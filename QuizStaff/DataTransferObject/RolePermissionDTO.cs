using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class RolePermissionDTO
    {
        public Guid Id { get; set; }

        public virtual RoleDTO Role { get; set; }
        public virtual PermissionDTO Permission { get; set; }

        public static implicit operator RolePermissionDTO(RolePermission rolePermission)
        {
            RolePermissionDTO newRolePermission =Conversion.ConvertRolePermissonToDTO(rolePermission);
           
            return newRolePermission;
        }
    }
}
