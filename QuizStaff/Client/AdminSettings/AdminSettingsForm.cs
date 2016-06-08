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

        }

        private void BindToViewModel()
        {      
            mvvmAdminSettingsContext.SetBinding(testeeListGridControl, testee => testee.DataSource, "Testees");
            mvvmAdminSettingsContext.SetBinding(frequencySpinEdit, frequency => frequency.EditValue, "FrequencyOfAsking");
            mvvmAdminSettingsContext.SetBinding(questionAmountTextEdit, amount => amount.EditValue, "AmountOfQuestionsPerDay");
            mvvmAdminSettingsContext.SetBinding(timeOfAskingEditTime, time => time.EditValue, "TimeOfStart");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var t = model.Testees;
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(AdminSettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(questionAmountLayoutControlItem, "questionAmountLayoutControlItem", newCultureInfo);
            resources.ApplyResources(frequencyLayoutControlItem, "frequencyLayoutControlItem", newCultureInfo);
            resources.ApplyResources(timeOfAskingLayoutControlItem, "timeOfAskingLayoutControlItem", newCultureInfo);
            resources.ApplyResources(dateImpactLabel, "dateImpactLabel", newCultureInfo);
            resources.ApplyResources(fromDateEditLayoutControlItem, "fromDateEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(toDateEditLayoutControlItem, "toDateEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(usersListLayoutControlItem, "usersListLayoutControlItem", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            this.Text = resources.GetString("Title", newCultureInfo);
        }
    }
}