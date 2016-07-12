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

namespace AdminApplication.AdminSettings
{
    public partial class EditSettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private EditSettingsViewModel model;
        private BindingList<Testee> selectedTestee;

        public EditSettingsForm(BindingList<Testee> Testees)
        {
            InitializeComponent(); 
            Localized(Program.currentLang);

            mvvmSettingsContext.ViewModelType = typeof(EditSettingsViewModel);
            BindCommands();
            model = mvvmSettingsContext.GetViewModel<EditSettingsViewModel>();
            model.SetUpSettings(Testees);
            mvvmSettingsContext.SetViewModel(typeof(EditSettingsViewModel), model);
            selectedTestee = Testees;
            model.SetUpSettings(Testees);
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            var outer = new BindingSource { DataSource = model.Setting};
            questionAmountTextEdit.DataBindings.Add("EditValue", outer, "AmountOfQuestionsPerDay");
            frequencySpinEdit.DataBindings.Add("EditValue", outer, "FrequencyOfAsking");
            timeOfAskingEditTime.DataBindings.Add("EditValue", outer, "TimeOfStart");
            showAnswerToggleSwitch.DataBindings.Add("EditValue", outer, "ShowCorrectAnswer");
            canEditToggleSwitch.DataBindings.Add("EditValue", outer, "CanUserEdit");
        }

        private void BindCommands()
        {
            mvvmSettingsContext.BindCommand<EditSettingsViewModel>(applyButton, viewModel => viewModel.Save());
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(EditSettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(questionAmountLayoutControlItem, "questionAmountLayoutControlItem", newCultureInfo);
            resources.ApplyResources(frequencyLayoutControlItem, "frequencyLayoutControlItem", newCultureInfo);
            resources.ApplyResources(timeOfAskingLayoutControlItem, "timeOfAskingLayoutControlItem", newCultureInfo);
            resources.ApplyResources(showAnswerToggleSwitchLayoutControlItem, "showAnswerToggleSwitchLayoutControlItem", newCultureInfo);
            resources.ApplyResources(canEditToggleSwitchLayoutControlItem, "canEditToggleSwitchLayoutControlItem", newCultureInfo);
            resources.ApplyResources(applyButton, "applyButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Settings";
        }
    }
}