using DAL;
using DAL.Repositories;
using DataTransferObject;
using DomainModel;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class RoleService: IRoleService
    {
        public List<RoleDTO> GetAllRoles(QuizDBContext context)
        {
            EFRepository<Role> repo = new EFRepository<Role>(context);
            var roles = new List<Role>(repo.ReadAll());
            return roles.Select(role => (RoleDTO)role).ToList();
        }

        public List<PermissionDTO> GetAllPermissions(QuizDBContext context)
        {
            EFRepository<Permission> repo = new EFRepository<Permission>(context);
            var permissions = new List<Permission>(repo.ReadAll());
            return permissions.Select(permission => (PermissionDTO)permission).ToList();
        }

        public void UpdateRole(QuizDBContext context, RoleDTO role)
        {
            EFRoleRepository repo = new EFRoleRepository(context);
            if (role.Id == Guid.Empty)
            {
                repo.Create(Conversion.ConvertRoleFromDTO(role));
            }
            else
            {
                repo.Update(Conversion.ConvertRoleFromDTO(role));
            }
        }

        public void SaveRole(QuizDBContext context, RoleDTO role)
        {
            EFTesteeRepository repo = new EFTesteeRepository(context);
            var allTestee = repo.ReadAll();

            foreach (var testee in allTestee.ToList())
            {
                testee.Roles.Add(new TesteeRoles() { Role = Conversion.ConvertRoleFromDTO(role), IsActive = false });
                repo.Update(Conversion.ConvertTesteeFromDTO(testee));
            }
        }
    }
}
