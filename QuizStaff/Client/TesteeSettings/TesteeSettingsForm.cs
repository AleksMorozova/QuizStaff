using System;
using DomainModel;
using System.Globalization;
using System.ComponentModel;
using System.Windows.Forms;

namespace Client.TesteeSettings
{
    public partial class TesteeSettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private TesteeSettingsViewModel model;
      
        public TesteeSettingsForm()
        {
            InitializeComponent();
            Localized(Program.currentLang);

            mvvmTesteeSettingsContext.ViewModelType = typeof(TesteeSettingsViewModel);
            BindCommands();
            model = new TesteeSettingsViewModel();
            model.SetUpSetting();
            mvvmTesteeSettingsContext.SetViewModel(typeof(TesteeSettingsViewModel), model);
            BindToViewModel();
        }

        private void BindCommands()
        {
            mvvmTesteeSettingsContext.BindCommand<TesteeSettingsViewModel, Testee>(saveButton, (viewModel, testee)
                => viewModel.Save(testee), x => Program.currentTestee);
        }

        private void BindToViewModel() 
        {
            //TODO: Rewrite binding to mvvmTesteeSettingsContext bindings
            var outer = new BindingSource { DataSource = Program.currentTestee };
            var inner = new BindingSource(outer, "UserSetting");
            questionAmountSpinEdit.DataBindings.Add("EditValue", inner, "AmountOfQuestionsPerDay");
            frequencySpinEdit.DataBindings.Add("EditValue", inner, "FrequencyOfAsking");
            timeOfAskingEditTime.DataBindings.Add("EditValue", inner, "TimeOfStart");
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(TesteeSettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(questionAmountSpinEditLayoutControlItem, "questionAmountSpinEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(frequencySpinEditLayoutControlItem, "frequencySpinEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(timeOfAskingEditTimeLayoutControlItem, "timeOfAskingEditTimeLayoutControlItem", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Settings";
        }
    }
}