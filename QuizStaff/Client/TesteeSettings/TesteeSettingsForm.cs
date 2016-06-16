using System;
using DomainModel;
using System.Globalization;
using System.ComponentModel;

namespace Client.TesteeSettings
{
    public partial class TesteeSettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private TesteeSettingsViewModel model;
      
        public TesteeSettingsForm()
        {
            InitializeComponent();

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
            mvvmTesteeSettingsContext.SetBinding(questionAmountSpinEdit, questionText => questionText.EditValue, "UserSetting.AmountOfQuestionsPerDay");
            mvvmTesteeSettingsContext.SetBinding(frequencySpinEdit, questionText => questionText.EditValue, "UserSetting.FrequencyOfAsking");
            mvvmTesteeSettingsContext.SetBinding(timeOfAskingEditTime, questionText => questionText.EditValue, "UserSetting.TimeOfStart");
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

            this.Text = resources.GetString("Title", newCultureInfo);
        }
    }
}