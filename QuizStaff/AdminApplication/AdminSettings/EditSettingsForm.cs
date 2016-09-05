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
            Localized(Program.СurrentLang);

            mvvmSettingsContext.ViewModelType = typeof(EditSettingsViewModel);
            BindCommands();
            model = mvvmSettingsContext.GetViewModel<EditSettingsViewModel>();
            model.SetUpSettings(Testees);
            mvvmSettingsContext.SetViewModel(typeof(EditSettingsViewModel), model);
            selectedTestee = Testees;
            model.SetUpSettings(Testees);
            BindToViewModel();
            SetUpRangeOfRecurrence(model.Recurrence);
            BindEndParameters();
        }

        private void BindEndParameters()
        {
            questionAmountSpinEdit.EditValue = null;
            endDateDateEdit.EditValue = null;

            if (model.Recurrence == RecurrenceType.WithSpecifiedEndDate)
            {
                endDateDateEdit.EditValue = model.EndDate;
            }
            else if (model.Recurrence == RecurrenceType.WithExactRepeated)
            {
                questionAmountSpinEdit.EditValue = model.AmountOfQuestionsPerDay;
            }
        }

        private void SetUpRangeOfRecurrence(RecurrenceType type)
        {
            withoutEndDateCheckEdit.Checked = (type == RecurrenceType.WithoutEnding);
            endAfterCheckEdit.Checked = (type == RecurrenceType.WithExactRepeated);
            endDateCheckEdit.Checked = (type == RecurrenceType.WithSpecifiedEndDate);
        }

        private void BindToViewModel()
        {
            var outer = new BindingSource { DataSource = model.Setting};

            canEditToggleSwitch.DataBindings.Add("EditValue", outer, "CanUserEdit");
            showAnswerToggleSwitch.DataBindings.Add("EditValue", outer, "ShowCorrectAnswer");
            hoursSpinEdit.DataBindings.Add("EditValue", outer, "Hours");
            minutesSpinEdit.DataBindings.Add("EditValue", outer, "Minutes");
            secondsSpinEdit.DataBindings.Add("EditValue", outer, "Seconds");
            startDateEdit.DataBindings.Add("EditValue", outer, "TimeOfStart");
            startTimeEdit.DataBindings.Add("EditValue", outer, "TimeOfStart");
        }

        private void BindCommands()
        {
            mvvmSettingsContext.BindCommand<EditSettingsViewModel>(applyButton, viewModel => viewModel.Save());
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(EditSettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
         
            resources.ApplyResources(generalSettingsLayoutControlGroup, "generalSettingsLayoutControlGroup", newCultureInfo);           
            resources.ApplyResources(showAnswerToggleSwitchLayoutControlItem, "showAnswerToggleSwitchLayoutControlItem", newCultureInfo);  
            resources.ApplyResources(canEditToggleSwitchLayoutControlItem, "canEditToggleSwitchLayoutControlItem", newCultureInfo);
            resources.ApplyResources(intervalIayoutControlGroup, "intervalIayoutControlGroup", newCultureInfo);
            resources.ApplyResources(intervalLabelControl, "intervalLabelControl", newCultureInfo);
            resources.ApplyResources(hoursLayoutControlItem, "hoursLayoutControlItem", newCultureInfo);
            resources.ApplyResources(minuteLayoutControlItem, "minuteLayoutControlItem", newCultureInfo);
            resources.ApplyResources(secondLayoutControlItem, "secondLayoutControlItem", newCultureInfo);
            resources.ApplyResources(startLayoutControlGroup, "startLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(startParametersLabelControl, "startParametersLabelControl", newCultureInfo);
            resources.ApplyResources(startDateLayoutControlItem, "startDateLayoutControlItem", newCultureInfo);
            resources.ApplyResources(startTimeLayoutControlItem, "timeOfAskingEditTimeLayoutControlItem", newCultureInfo);
            resources.ApplyResources(recurrenceLayoutControlGroup, "recurrenceLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(withoutEndDateCheckEdit, "withoutEndDateCheckEdit", newCultureInfo);
            resources.ApplyResources(endAfterCheckEdit, "endAfterCheckEdit", newCultureInfo);
            resources.ApplyResources(endDateCheckEdit, "endDateCheckEdit", newCultureInfo);
            resources.ApplyResources(questionAmountSpinEditLayoutControlItem, "questionAmountSpinEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(applyButton, "applyButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);            

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Settings";
        }
       
        #region Recurrence type changing
        private void withoutEndDateCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                endAfterCheckEdit.Checked = false;
                endDateCheckEdit.Checked = false;
                model.Recurrence = RecurrenceType.WithoutEnding;
            }
        }
 
        private void endAfterCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                withoutEndDateCheckEdit.Checked = false;
                endDateCheckEdit.Checked = false;
                model.Recurrence = RecurrenceType.WithExactRepeated;
            }
        }

        private void endDateCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                endAfterCheckEdit.Checked = false;
                withoutEndDateCheckEdit.Checked = false;
                model.Recurrence = RecurrenceType.WithSpecifiedEndDate;
            }
        }

        private void endDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit date = sender as DateEdit;
            model.EndDate = (DateTime)date.EditValue;
        }

        private void questionAmountSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            SpinEdit date = sender as SpinEdit;
            if ((int)date.Value != 0)
                model.AmountOfQuestionsPerDay = (int)date.Value;
        }
        #endregion
    }
}