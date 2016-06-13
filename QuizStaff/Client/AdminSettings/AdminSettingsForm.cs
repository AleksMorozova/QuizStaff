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
using DataTransferObject;

namespace Client.AdminSettings
{
    public partial class AdminSettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private AdminSettingsViewModel model;

        public AdminSettingsForm()
        {
            InitializeComponent();

            mvvmAdminSettingsContext.ViewModelType = typeof(AdminSettingsViewModel);
            BindCommands();
            model = new AdminSettingsViewModel();
            mvvmAdminSettingsContext.SetViewModel(typeof(AdminSettingsViewModel), model);
            model.GetAllTestees();
            BindToViewModel();
        }

        private void BindCommands()
        {

            mvvmAdminSettingsContext.BindCommand<AdminSettingsViewModel, BindingList<TesteeDTO>>(saveButton, (viewModel, questionID)
                => viewModel.EditSettings(questionID), x => GetSelectedTestees());
        }

        private BindingList<TesteeDTO> GetSelectedTestees() 
        {
            //TODO: Get selected testees 
            return (this.model!=null && this.model.Testees!=null) ? model.Testees: new BindingList<TesteeDTO>();
        }

        private void BindToViewModel()
        {      
            mvvmAdminSettingsContext.SetBinding(testeeListGridControl, testee => testee.DataSource, "Testees");
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(AdminSettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(usersListLayoutControlItem, "usersListLayoutControlItem", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            this.Text = resources.GetString("Title", newCultureInfo);
        }
    }
}