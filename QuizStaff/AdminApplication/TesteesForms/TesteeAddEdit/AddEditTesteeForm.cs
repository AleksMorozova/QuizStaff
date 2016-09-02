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
using DevExpress.XtraGrid.Views.Grid;
using DomainModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace AdminApplication.TesteesForm.TesteeAddEdit
{
    public partial class AddEditTesteeForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private TesteeViewModel model;
        private bool isExtended = false;
        private int SettingGroupWidth = 0;
        public Testee Testee
        {
            get
            {
                return model.Testee;
            }
            set
            {
                model.Testee = value;
            }
        }

        public AddEditTesteeForm()
            : this(new Testee() { IsActive = true, IsSelected = false, 
                UserSetting = new Setting() { TimeOfStart = DateTime.Now }, Trainings = new BindingList<TesteeTraining> { } }) { }

        public AddEditTesteeForm(Testee testee)
        {
            InitializeComponent();
            this.gridViewTrainings.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            
            mvvmTesteeContext.ViewModelType = typeof(TesteeViewModel);
            model = mvvmTesteeContext.GetViewModel<TesteeViewModel>();
            BindCommand();
            model.SetUpViewModel(testee);
            mvvmTesteeContext.SetViewModel(typeof(TesteeViewModel), model);          
            BindToViewModel();
            model.TesteeListChanged += new TesteeChangedEventHandler(TesteeListChanged);

            //set up form
            BindEndParameters();
            SetUpRolesComboBox();
            SetUpRangeOfRecurrence(model.Setting.Recurrence);

            //Expande settings group
            SettingGroupWidth = settingLayoutControlGroup.Width;
            settingLayoutControlGroup.Expanded = false;
            settingLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            isExtended = false;
        }
       
        private void TesteeListChanged(object sender, EventArgs e)
        {
            gridTrainings.Refresh();
        }

        private void BindCommand()
        {
            mvvmTesteeContext.BindCommand<TesteeViewModel>(saveButton, viewModel => viewModel.Save());
            mvvmTesteeContext.BindCommand<TesteeViewModel>(cancelButton, viewModel => viewModel.Cancel());
            mvvmTesteeContext.BindCommand<TesteeViewModel, TesteeTraining>(deleteTrainingButton,
                (x, currentTraining) => x.DeleteTraining(currentTraining), x => GetCurrentTesteeTraining());
            mvvmTesteeContext.BindCommand<TesteeViewModel, TesteeTraining>(addTrainingButton,
                (x, currentTraining) => x.AddTraining(currentTraining), x => new TesteeTraining() { IsActive = true, IsSelect = true});
        }

        private void BindToViewModel()
        {
            mvvmTesteeContext.SetBinding(textFirstName, questionText => questionText.EditValue, "FirstName");
            mvvmTesteeContext.SetBinding(textLastName, questionText => questionText.EditValue, "LastName");
            mvvmTesteeContext.SetBinding(textEmail, questionText => questionText.EditValue, "Email");
            mvvmTesteeContext.SetBinding(textLogin, questionText => questionText.EditValue, "Login");
            mvvmTesteeContext.SetBinding(gridTrainings, answers => answers.DataSource, "Trainings");
            mvvmTesteeContext.SetBinding(trainingsRepositoryItemLookUpEdit, training => training.DataSource, "AllTrainings");
            trainingsRepositoryItemLookUpEdit.DisplayMember = "TrainingTitle";
            trainingsRepositoryItemLookUpEdit.ValueMember = "TrainingTitle";

            //TODO: Rewrite binding to mvvmTesteeSettingsContext bindings
            var settingsBindingSource = new BindingSource { DataSource = model.Setting };
            canEditToggleSwitch.DataBindings.Add("EditValue", settingsBindingSource, "CanUserEdit");
            showAnswerToggleSwitch.DataBindings.Add("EditValue", settingsBindingSource, "ShowCorrectAnswer");
            hoursSpinEdit.DataBindings.Add("EditValue", settingsBindingSource, "Hours");
            minutesSpinEdit.DataBindings.Add("EditValue", settingsBindingSource, "Minutes");
            secondsSpinEdit.DataBindings.Add("EditValue", settingsBindingSource, "Seconds");
            startDateEdit.DataBindings.Add("EditValue", settingsBindingSource, "TimeOfStart");
            startTimeEdit.DataBindings.Add("EditValue", settingsBindingSource, "TimeOfStart");           
        }               

        private void SetUpRolesComboBox()
        {
            if (model.Roles != null && model.Roles.Count()>0)
            {
                foreach (var role in model.Roles)
                {
                    rolesComboBox.Properties.Items.Add(role.Role.Name, role.IsActive);
                }
            }
            else 
            {
                model.Roles = new BindingList<TesteeRoles>();
                foreach (var role in model.AllRoles)
                {
                    rolesComboBox.Properties.Items.Add(role.Name, false);
                    model.Roles.Add(new TesteeRoles() { IsActive = false, Role = role });
                }
            }

            var superUseRole = model.AllRoles.
              Where(_ => _.Permissions.Any(p => p.Permission.Type == PermissionType.EditSetUp)).Select(r => r.Name);

            var unShow = model.AllRoles.
             Where(_ => _.Permissions.Any(p => p.Permission.Type == PermissionType.GetQuestion)).Select(r => r.Name);

            for (int i = 0; i < rolesComboBox.Properties.Items.Count; i++)
            {
                if (superUseRole.Contains(rolesComboBox.Properties.Items[i].Value))
                    rolesComboBox.Properties.Items[i].Enabled = Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.CreateAdministrator);
            }

            for (int i = 0; i < rolesComboBox.Properties.Items.Count; i++)
            {
                if (!Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.CreateAdministrator))
                {
                    if (rolesComboBox.Properties.Items[i].Value.ToString() == "Super administrator".ToString())
                        rolesComboBox.Properties.Items.Remove(rolesComboBox.Properties.Items[i]);
                }
            }
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

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(AddEditTesteeForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(firstNameLayoutControlItem, "firstNameLayoutControlItem", newCultureInfo);
            resources.ApplyResources(lastNameLayoutControlItem, "lastNameLayoutControlItem", newCultureInfo);
            resources.ApplyResources(loginLayoutControlItem, "loginLayoutControlItem", newCultureInfo);
            resources.ApplyResources(emailLayoutControlItem, "emailLayoutControlItem", newCultureInfo);
            resources.ApplyResources(trainingsLayoutControlItem, "trainingsLayoutControlItem", newCultureInfo);
            resources.ApplyResources(gridTrainings, "gridTrainings", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            resources.ApplyResources(titleGridColumn, "titleGridColumn", newCultureInfo);
            resources.ApplyResources(generalInfLayoutControlGroup, "generalInfLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(rolesComboBoxLayoutControlItem, "rolesComboBoxLayoutControlItem", newCultureInfo);        
            resources.ApplyResources(showAnswerToggleSwitchLayoutControlItem, "showAnswerToggleSwitchLayoutControlItem", newCultureInfo);
            resources.ApplyResources(canEditToggleSwitchLayoutControlItem, "canEditToggleSwitchLayoutControlItem", newCultureInfo);
            resources.ApplyResources(generalSettingsLayoutControlGroup, "generalSettingsLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(intervalIayoutControlGroup, "intervalIayoutControlGroup", newCultureInfo);
            resources.ApplyResources(intervalLabelControl, "intervalLabelControl", newCultureInfo);
            resources.ApplyResources(hoursLayoutControlItem, "hoursLayoutControlItem", newCultureInfo);
            resources.ApplyResources(minuteLayoutControlItem, "minuteLayoutControlItem", newCultureInfo);
            resources.ApplyResources(secondLayoutControlItem, "secondLayoutControlItem", newCultureInfo);
            resources.ApplyResources(startLayoutControlGroup, "startLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(startParametersLabelControl, "startParametersLabelControl", newCultureInfo);
            resources.ApplyResources(startDateLayoutControlItem, "startDateLayoutControlItem", newCultureInfo);
            resources.ApplyResources(startTimeLayoutControlItem, "startTimeLayoutControlItem", newCultureInfo);
            resources.ApplyResources(recurrenceLayoutControlGroup, "recurrenceLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(questionAmountSpinEditLayoutControlItem, "questionAmountSpinEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(editSettingButton, "editSettingButton", newCultureInfo);

            #region Trnslate radio group
            string withoutEnding = !String.IsNullOrEmpty(resources.GetString("withoutEndDateCheckEdit.Text", newCultureInfo))
                ? resources.GetString("withoutEndDateCheckEdit.Text", newCultureInfo) : "Without end condition";
            withoutEndDateCheckEdit.Text = withoutEnding;        
            string endAfter = !String.IsNullOrEmpty(resources.GetString("endAfterCheckEdit.Text", newCultureInfo))
                ? resources.GetString("endAfterCheckEdit.Text", newCultureInfo) : "End after";
            endAfterCheckEdit.Text = endAfter;
            string endDate = !String.IsNullOrEmpty(resources.GetString("endDateCheckEdit.Text", newCultureInfo))
                ? resources.GetString("endDateCheckEdit.Text", newCultureInfo) : "End date";
            endDateCheckEdit.Text = endDate;
            #endregion

            string title = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Testee";
            this.Text = title + (Testee != null && !String.IsNullOrEmpty(Testee.Login) ? ":" + Testee.Login : "");
        }

        private TesteeTraining GetCurrentTesteeTraining()
        {
            int rowHandler = this.gridViewTrainings.FocusedRowHandle;
            var editedTesteeTraining = (TesteeTraining)gridViewTrainings.GetRow(rowHandler);
            return editedTesteeTraining;
        }

        private void rolesComboBox_Closed(object sender, ClosedEventArgs e)
        {
            if (model.Roles != null)
            {
                foreach (var role in model.Roles)
                {
                    var countItems = rolesComboBox.Properties.Items.Where(_ => _.Value == role.Role.Name);
                    bool exists = countItems.Count() > 0;
                    if (exists)
                    {
                        var t = rolesComboBox.Properties.Items.Where(_ => _.Value == role.Role.Name).First().CheckState;
                        role.IsActive = (t == CheckState.Checked);
                    }
                }
            } 
        }

        private void editSettingButton_Click(object sender, EventArgs e)
        {
            if (settingLayoutControlGroup.Expanded)
            {
                Program.ApplicationMainForm.Width -= SettingGroupWidth; 
            }
            else
            {
                Program.ApplicationMainForm.Width += SettingGroupWidth; 
            }

            settingLayoutControlGroup.Visibility = (!isExtended)
                ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                :DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            settingLayoutControlGroup.Expanded = !isExtended;
            isExtended = settingLayoutControlGroup.Expanded;
        }

        #region Work with newly added training
        private void gridViewTrainings_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            model.AddTraining(new TesteeTraining() { IsActive = true, IsSelect = true });
        }
       
        private void trainingsRepositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //Write selected training to testee trainings 
            var testeeTraining = GetCurrentTesteeTraining();

            GridLookUpEdit editor = (sender as GridLookUpEdit);
            var currentTraining = editor.EditValue;
            if (currentTraining != null)
            {
                testeeTraining.Training = model.AllTrainings.Where(_ => _.TrainingTitle == currentTraining.ToString()).First();
                testeeTraining.IsActive = true;
            }
        }
        #endregion

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
                questionAmountSpinEdit.EditValue = model.AmountOfQuestionsPerDay;
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
                endDateDateEdit.EditValue = model.EndDate;
                model.Recurrence = RecurrenceType.WithSpecifiedEndDate;
            }
        } 
        
        private void endDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit date = sender as DateEdit;
            model.EndDate = date.DateTime;
        }

        private void questionAmountSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            SpinEdit date = sender as SpinEdit;
            if((int)date.Value != 0)
                model.AmountOfQuestionsPerDay = (int)date.Value;
        }
        #endregion
    }
}