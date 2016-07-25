using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.AdminSettings
{
    public class EditPermissionsViewModel
    {
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

        public void SetUpViewModel(BindingList<Permission> permissions) 
        {
            Permissions = permissions;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
