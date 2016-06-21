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
using DomainModel;

namespace Client.AdminSettings
{
    public partial class EditSettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private AdminSettingsViewModel model;
        private BindingList<Testee> selectedTestee;

        public EditSettingsForm(BindingList<Testee> Testees)
        {
            InitializeComponent();
            mvvmSettingsContext.ViewModelType = typeof(AdminSettingsViewModel);
            //TODO: Set command binding
            BindCommands();
            model = new AdminSettingsViewModel();
            mvvmSettingsContext.SetViewModel(typeof(AdminSettingsViewModel), model);
            selectedTestee = Testees;
            model.SetUpSettings(Testees);
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            //TODO: Rewrite binding to mvvmTesteeSettingsContext bindings
            var outer = new BindingSource { DataSource = model.Setting};
            questionAmountTextEdit.DataBindings.Add("EditValue", outer, "AmountOfQuestionsPerDay");
            frequencySpinEdit.DataBindings.Add("EditValue", outer, "FrequencyOfAsking");
            timeOfAskingEditTime.DataBindings.Add("EditValue", outer, "TimeOfStart");
        }

        private void BindCommands()
        {
            mvvmSettingsContext.BindCommand<AdminSettingsViewModel, BindingList<Testee>>(applyButton, (viewModel, testee)
                => viewModel.Save(testee), x => selectedTestee);
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
            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Settings";
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            model.Save(selectedTestee);
        }
    }
}