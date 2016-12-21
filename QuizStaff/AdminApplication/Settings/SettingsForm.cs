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

namespace AdminApplication.Settings
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm
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
            mvvmSettingsContext.SetBinding(timeOfUpdateTextEdit, questionText => questionText.EditValue, "TimeOfUpdating");
        }

        private void SetUpFrom()
        {
            var days = model.Days.Where(_ => _.IsSelect).Select(_ => _.Day);
            checkedComboBoxEdit1.Properties.Items.Add(DayOfWeek.Monday, days.Contains(DayOfWeek.Monday));
            checkedComboBoxEdit1.Properties.Items.Add(DayOfWeek.Tuesday, days.Contains(DayOfWeek.Tuesday));
            checkedComboBoxEdit1.Properties.Items.Add(DayOfWeek.Wednesday, days.Contains(DayOfWeek.Wednesday));
            checkedComboBoxEdit1.Properties.Items.Add(DayOfWeek.Thursday, days.Contains(DayOfWeek.Thursday));
            checkedComboBoxEdit1.Properties.Items.Add(DayOfWeek.Friday, days.Contains(DayOfWeek.Friday));
            checkedComboBoxEdit1.Properties.Items.Add(DayOfWeek.Saturday, days.Contains(DayOfWeek.Saturday));
            checkedComboBoxEdit1.Properties.Items.Add(DayOfWeek.Sunday, days.Contains(DayOfWeek.Sunday));
        }

        private void checkedComboBoxEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (model.Days != null)
            {
                foreach (var role in model.Days)
                {
                    var countItems = checkedComboBoxEdit1.Properties.Items.Where(_ => _.Value.ToString() == role.Day.ToString());
                    bool exists = countItems.Count() > 0;
                    if (exists)
                    {
                        var t = checkedComboBoxEdit1.Properties.Items.Where(_ => _.Value.ToString() == role.Day.ToString()).First().CheckState;
                        role.IsSelect = (t == CheckState.Checked);
                    }
                }
            }
        }
    }
}