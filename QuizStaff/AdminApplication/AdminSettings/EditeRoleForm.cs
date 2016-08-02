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
    public partial class EditeRoleForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private EditeRoleViewModel model;

        public EditeRoleForm()
        {
            InitializeComponent();
            mvvmRoleContext.ViewModelType = typeof(EditeRoleViewModel);
            model = mvvmRoleContext.GetViewModel<EditeRoleViewModel>();
            BindCommands();
            mvvmRoleContext.SetViewModel(typeof(EditeRoleViewModel), model);
            model.SetUpViewModel();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            mvvmRoleContext.SetBinding(roleGridControl, role => role.DataSource, "Roles");
            mvvmRoleContext.SetBinding(permissionGridControl, permission => permission.DataSource, "Permissions");
        }

        private void BindCommands()
        {
            mvvmRoleContext.BindCommand<EditeRoleViewModel>(saveButton, viewModel => viewModel.Save());
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(EditeRoleForm));
            CultureInfo newCultureInfo = new CultureInfo(language);

            resources.ApplyResources(roleGridControlLayoutControlItem, "roleGridControlLayoutControlItem", newCultureInfo);
            resources.ApplyResources(permissionGridControlLayoutControlItem, "permissionGridControlLayoutControlItem", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            resources.ApplyResources(descriptionGridColumn, "descriptionGridColumn", newCultureInfo);
            resources.ApplyResources(roleGridColumn, "roleGridColumn", newCultureInfo);
            resources.ApplyResources(permissionGridColumn, "permissionGridColumn", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Roles";
        }

        public bool RoleHasPermission(Role role, Permission perm)
        {
            return (from p in role.Permissions where p.Permission.Id == perm.Id select p).Count() > 0;
        }

        void RefreshRolePermissions(int rowIndex)
        {
            var view = roleGridView;

            if (view.IsValidRowHandle(rowIndex))
            {               
                permissionGridView.ClearSelection();
                var role = view.GetRow(rowIndex) as Role;
                if (role != null)
                {
                    for (int rowHandle = 0; rowHandle < permissionGridView.RowCount; rowHandle++)
                    {
                        var perm = permissionGridView.GetRow(rowHandle) as Permission;
                        if (perm!=null)
                        {
                            if (RoleHasPermission(role, perm))
                        {
                            permissionGridView.SelectRow(rowHandle);
                        }
                        }
                    }
                }
            }
        }

        private void roleGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshRolePermissions(e.FocusedRowHandle);
        }

        private void EditeRoleForm_Load(object sender, EventArgs e)
        {
            RefreshRolePermissions(0);
        }

        private bool handleGridViewPermissionsSelectionChanged = true;
        private void permissionGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as GridView;
            var role = roleGridView.GetFocusedRow() as Role;

            if (role == null)
                return;

            Permission p = view.GetRow(e.ControllerRow) as Permission;
            if (view.IsFocusedView)
            {
                switch (e.Action)
                {
                    case CollectionChangeAction.Add:
                        AddPermissionToRole(role, p);
                        break;
                    case CollectionChangeAction.Remove:
                        RemovePermissionFromRole(role, p);
                        break;
                }
            }
            else if (handleGridViewPermissionsSelectionChanged)
            {
                handleGridViewPermissionsSelectionChanged = false;
                switch (e.Action)
                {
                    case CollectionChangeAction.Add:
                        view.SelectRow(e.ControllerRow);
                        break;
                    case CollectionChangeAction.Remove:
                        view.UnselectRow(e.ControllerRow);
                        break;
                }
            }

            handleGridViewPermissionsSelectionChanged = true;
        }

        public void AddPermissionToRole(Role role, Permission p)
        {
            var rolePerm = role.Permissions.Where(_ => _.Id == p.Id).FirstOrDefault();
            if (rolePerm == null)
            {
                RolePermission rolePermission = new RolePermission();
                rolePermission.Permission = p;
                role.Permissions.Add(rolePermission);
            }
        }

        public void RemovePermissionFromRole(Role role, Permission p)
        {
            var rolePerm = role.Permissions.Where(_ => _.Id == p.Id).FirstOrDefault();
            if (rolePerm != null)
            {
                role.Permissions.Remove(rolePerm);
            }

        }

        private void roleGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            Role role = v.GetRow(e.RowHandle) as Role;
            role.Permissions = new BindingList<RolePermission>();
        }
    }
}