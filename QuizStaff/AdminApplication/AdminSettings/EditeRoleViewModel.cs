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
        private TesteeDTO[] Testees;
        public void SetUpViewModel() 
        {
            this.Roles = LoadRoles();
            this.Permissions = LoadPermissions();
            Testees = ServicesHolder.ServiceClient.GetAllTestees();
        }

        public BindingList<Role> LoadRoles()
        {
            BindingList<Role> roles = new BindingList<Role>();
            var loadedRoles = ServicesHolder.ServiceClient.GetAllRoles();

            foreach (var r in loadedRoles)
            {
                if (r.Name != "Super administrator")
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
                if (p.Type != PermissionType.CreateAdministrator)
                {              
                    Permission permission = new Permission();
                    permission.Id = p.Id;
                    permission.Title = p.Title;
                    permission.Type = p.Type;
                    permissions.Add(permission);
                }
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
            foreach (var r in Roles)
            {
                if (r.Id == Guid.Empty)
                {
                    foreach (var testee in Testees.ToList())
                    {
                        ServicesHolder.ServiceClient.AddTesteeRole(testee, Conversion.ConvertRoleToDTO(r));
                    }
                }
                else 
                {
                    ServicesHolder.ServiceClient.UpdateRoles(Conversion.ConvertRoleToDTO(r));
                }
                
            }
        }
    }
}
