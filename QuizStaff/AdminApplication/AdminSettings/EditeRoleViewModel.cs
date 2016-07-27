using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.AdminSettings
{
    public class EditeRoleViewModel
    {
        public void SetUpViewModel() 
        {
            this.Roles = LoadRoles();
            this.Permissions = LoadPermissions();
        }

        public BindingList<Role> LoadRoles()
        {
            BindingList<Role> roles = new BindingList<Role>();
            var loadedRoles = ServicesHolder.ServiceClient.GetAllRoles();

            foreach (var r in loadedRoles)
            {
                roles.Add(Conversion.ConvertRoleFromDTO(r));
            }

            return roles;
        }

        public BindingList<Permission> LoadPermissions()
        {
            BindingList<Permission> permissions = new BindingList<Permission>();
            var loadedPermissions = ServicesHolder.ServiceClient.GetAllPermissions();
            foreach (var p in loadedPermissions)
            {
                Permission permission = new Permission();
                permission.Id = p.Id;
                permission.Title = p.Title;
                permissions.Add(permission);
            }

            return permissions;
        }

        private BindingList<Role> roles;
        public BindingList<Role> Roles
        {
            get
            {
                return roles;
            }

            set
            {
                if (roles != value)
                {
                    roles = value;
                    RaisePropertyChanged("Roles");
                }
            }
        }

        private BindingList<Permission> permissions;
        public BindingList<Permission> Permissions
        {
            get
            {
                return permissions;
            }

            set
            {
                if (permissions != value)
                {
                    permissions = value;
                    RaisePropertyChanged("Permissions");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Save() 
        {

            foreach (var p in Permissions)
            {

                PermissionDTO savedPermission = new PermissionDTO();
                savedPermission.Id = p.Id;
                savedPermission.Title = p.Title;

                ServicesHolder.ServiceClient.UpdatePermissions(savedPermission);
            }

            foreach (var r in Roles)
            {
                ServicesHolder.ServiceClient.UpdateRoles(Conversion.ConvertRoleToDTO(r));
            }
        }
    }
}
