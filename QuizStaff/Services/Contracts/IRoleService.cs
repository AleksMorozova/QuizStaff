using DAL;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IRoleService
    {
        List<RoleDTO> GetAllRoles(QuizDBContext context);

        List<PermissionDTO> GetAllPermissions(QuizDBContext context);

        void UpdateRole(QuizDBContext context, RoleDTO role);

        void SaveRole(QuizDBContext context, RoleDTO role);
    }
}
