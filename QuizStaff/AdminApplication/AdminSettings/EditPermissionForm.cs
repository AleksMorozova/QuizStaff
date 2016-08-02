using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using DomainModel;
using DevExpress.XtraGrid.Views.Grid;

namespace AdminApplication.AdminSettings
{
    public partial class EditPermissionForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private EditPermissionsViewModel model;

        public EditPermissionForm(BindingList<Permission> Permissions)
        {
            InitializeComponent();
            Localized(Program.currentLang);

            mvvmPermissionContext.ViewModelType = typeof(EditPermissionsViewModel);
            model = mvvmPermissionContext.GetViewModel<EditPermissionsViewModel>();
            BindCommands();
            mvvmPermissionContext.SetViewModel(typeof(EditPermissionsViewModel), model);
            model.SetUpViewModel(Permissions);
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            mvvmPermissionContext.SetBinding(permissionGridControl, permission => permission.DataSource, "Permissions");
        }

        private void BindCommands()
        {
            //mvvmPermissionContext.BindCommand<EditSettingsViewModel>(saveButton, viewModel => viewModel.Save());
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(EditPermissionForm));
            CultureInfo newCultureInfo = new CultureInfo(language);

            resources.ApplyResources(permissionGridControl, "permissionGridControl", newCultureInfo);
            resources.ApplyResources(permissionGridColumn, "permissionGridColumn", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            resources.ApplyResources(addPermissionButton, "addPermissionButton", newCultureInfo);
            resources.ApplyResources(deletePermissionButton, "deletePermissionButton", newCultureInfo);
            resources.ApplyResources(permissionGridControlLayoutControlItem, "permissionGridControlLayoutControlItem", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Permissions";
        }

        private void permissionGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            Permission permission = v.GetRow(e.RowHandle) as Permission;
        }

        public BindingList<Permission> Permissions
        {
            get
            {
                return model.Permissions;
            }

            set
            {
                model.Permissions = value;
            }
        }
    }
}