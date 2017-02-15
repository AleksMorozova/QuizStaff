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

namespace AdminApplication.Settings
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private SettingsViewModel model;

        public SettingsForm()
        {
            InitializeComponent();

            mvvmSettingsContext.ViewModelType = typeof(SettingsViewModel);

            model = mvvmSettingsContext.GetViewModel<SettingsViewModel>();
            BindCommand();
            model.SetUpViewModel();
            mvvmSettingsContext.SetViewModel(typeof(SettingsViewModel), model);
            BindToViewModel();

            SetUpFrom();
        }

        private void BindCommand()
        {
            mvvmSettingsContext.BindCommand<SettingsViewModel>(saveButton, viewModel => viewModel.Save());
        }

        private void BindToViewModel()
        {
            mvvmSettingsContext.SetBinding(lmsReportFileNameTextEdit, questionText => questionText.EditValue, "LMSReportFileName");
            mvvmSettingsContext.SetBinding(lmsReporPathTextEdit, questionText => questionText.EditValue, "LMSReportPath");
            mvvmSettingsContext.SetBinding(questionPathTextEdit, questionText => questionText.EditValue, "TrainingsQuestionsPath");
            mvvmSettingsContext.SetBinding(pathToAdditionalQuestionsTextEdit, questionText => questionText.EditValue, "AdditionalQuestionsPath");
        }

        private void SetUpFrom()
        {
            var days = model.Days.Where(_ => _.IsSelect).Select(_ => _.Day);
            dayOfUpdateCheckedComboBox.Properties.Items.Add(DayOfWeek.Monday, days.Contains(DayOfWeek.Monday));
            dayOfUpdateCheckedComboBox.Properties.Items.Add(DayOfWeek.Tuesday, days.Contains(DayOfWeek.Tuesday));
            dayOfUpdateCheckedComboBox.Properties.Items.Add(DayOfWeek.Wednesday, days.Contains(DayOfWeek.Wednesday));
            dayOfUpdateCheckedComboBox.Properties.Items.Add(DayOfWeek.Thursday, days.Contains(DayOfWeek.Thursday));
            dayOfUpdateCheckedComboBox.Properties.Items.Add(DayOfWeek.Friday, days.Contains(DayOfWeek.Friday));
            dayOfUpdateCheckedComboBox.Properties.Items.Add(DayOfWeek.Saturday, days.Contains(DayOfWeek.Saturday));
            dayOfUpdateCheckedComboBox.Properties.Items.Add(DayOfWeek.Sunday, days.Contains(DayOfWeek.Sunday));
        }

        private void dayOfUpdateCheckedComboBox_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (model.Days != null)
            {
                foreach (var role in model.Days)
                {
                    var countItems = dayOfUpdateCheckedComboBox.Properties.Items.Where(_ => _.Value.ToString() == role.Day.ToString());
                    bool exists = countItems.Count() > 0;
                    if (exists)
                    {
                        var t = dayOfUpdateCheckedComboBox.Properties.Items.Where(_ => _.Value.ToString() == role.Day.ToString()).First().CheckState;
                        role.IsSelect = (t == CheckState.Checked);
                    }
                }
            }
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(SettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);

            resources.ApplyResources(reportFileNameLayoutControlItem, "reportFileNameLayoutControlItem", newCultureInfo);
            resources.ApplyResources(reportFilePathLayoutControlItem, "reportFilePathLayoutControlItem", newCultureInfo);
            resources.ApplyResources(additionalQuestionsPathLayoutControlItem, "additionalQuestionsPathLayoutControlItem", newCultureInfo);
            resources.ApplyResources(questionFilesPathLayoutControlItem, "questionFilesPathLayoutControlItem", newCultureInfo);
            resources.ApplyResources(timeOfUpdateLayoutControlItem, "timeOfUpdateLayoutControlItem", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Application settings";
        }
    }
}