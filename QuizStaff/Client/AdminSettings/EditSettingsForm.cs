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
using DataTransferObject;
using System.Globalization;

namespace Client.AdminSettings
{
    public partial class EditSettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private AdminSettingsViewModel model;

        public EditSettingsForm(BindingList<TesteeDTO> Testees)
        {
            InitializeComponent();
            mvvmSettingsContext.ViewModelType = typeof(AdminSettingsViewModel);
            BindCommands();
            model = new AdminSettingsViewModel();
            mvvmSettingsContext.SetViewModel(typeof(AdminSettingsViewModel), model);
            model.SetUpSettings(Testees);
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            mvvmSettingsContext.SetBinding(frequencySpinEdit, frequency => frequency.EditValue, "FrequencyOfAsking");
            mvvmSettingsContext.SetBinding(questionAmountTextEdit, amount => amount.EditValue, "AmountOfQuestionsPerDay");
            mvvmSettingsContext.SetBinding(timeOfAskingEditTime, time => time.EditValue, "TimeOfStart");
        }

        private void BindCommands()
        {
           
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(AdminSettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(questionAmountLayoutControlItem, "questionAmountLayoutControlItem", newCultureInfo);
            resources.ApplyResources(frequencyLayoutControlItem, "frequencyLayoutControlItem", newCultureInfo);
            resources.ApplyResources(timeOfAskingLayoutControlItem, "timeOfAskingLayoutControlItem", newCultureInfo);
            resources.ApplyResources(applyButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            this.Text = resources.GetString("Title", newCultureInfo);
        }
    }
}