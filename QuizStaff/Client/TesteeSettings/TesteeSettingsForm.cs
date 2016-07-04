using System;
using DomainModel;
using System.Globalization;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Client.TesteeSettings
{
    public partial class TesteeSettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private TesteeSettingsViewModel model;
      
        public TesteeSettingsForm()
        {
            InitializeComponent();
            Localized(Program.currentLang);
            SetUpComboBox();

            mvvmTesteeSettingsContext.ViewModelType = typeof(TesteeSettingsViewModel);
            model = mvvmTesteeSettingsContext.GetViewModel<TesteeSettingsViewModel>();
            mvvmTesteeSettingsContext.SetViewModel(typeof(TesteeSettingsViewModel), model);

            BindCommands();
            SetControlAccess(model.UserSetting.CanUserEdit);
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
            var inner = new BindingSource { DataSource = model.UserSetting };
            questionAmountSpinEdit.DataBindings.Add("EditValue", inner, "AmountOfQuestionsPerDay");
            frequencySpinEdit.DataBindings.Add("EditValue", inner, "FrequencyOfAsking");
            timeOfAskingEditTime.DataBindings.Add("EditValue", inner, "TimeOfStart");
        }

        private void SetControlAccess(bool canEdit)
        {
            questionAmountSpinEdit.Enabled = canEdit;
            frequencySpinEdit.Enabled = canEdit;
            timeOfAskingEditTime.Enabled = canEdit;
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
            resources.ApplyResources(languageLayoutControlItem, "languageLayoutControlItem", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Settings";
        }

        private void languageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = sender as ComboBoxEdit;

            if (cb != null)
            {
                string currentLanguage = cb.SelectedItem as string;
                Localized(currentLanguage);
                FormManager.Instance.LocalizedForms(currentLanguage);
                Program.currentLang = currentLanguage;
            }
        }

        private void SetUpComboBox() 
        {
            languageComboBoxEdit.Properties.Items.Add("en-US");
            languageComboBoxEdit.Properties.Items.Add("ru-RU");
            int index = languageComboBoxEdit.Properties.Items.IndexOf(Program.currentLang);
            languageComboBoxEdit.SelectedIndex = index;
        } 
    }
}