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

namespace Client.TesteesForm.TesteeAddEdit
{
    public partial class AddEditTesteeForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
       private TesteeViewModel model;
       private Testee currentTestee;

       public AddEditTesteeForm()
           : this(new Testee() { IsActive = true}) { }

        public AddEditTesteeForm(Testee testee)
        {
            InitializeComponent();
            this.gridViewTrainings.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            mvvmTesteeContext.ViewModelType = typeof(TesteeViewModel);
            BindCommand();
            model = new TesteeViewModel();
            model.Testee = testee;
            model.GetAllTrainings();
            mvvmTesteeContext.SetViewModel(typeof(TesteeViewModel), model);          
            BindToViewModel(); 
            currentTestee = model.Testee;  
        }               

        private void BindCommand()
        {
            mvvmTesteeContext.BindCommand<TesteeViewModel, Testee>(saveButton, (viewModel, testee)
                => viewModel.Save(testee), x => currentTestee);
        }

        private void BindToViewModel()
        {
            mvvmTesteeContext.SetBinding(textFirstName, questionText => questionText.EditValue, "Testee.FirstName");
            mvvmTesteeContext.SetBinding(textLastName, questionText => questionText.EditValue, "Testee.LastName");
            mvvmTesteeContext.SetBinding(textEmail, questionText => questionText.EditValue, "Testee.Email");
            mvvmTesteeContext.SetBinding(textLogin, questionText => questionText.EditValue, "Testee.Login");
            mvvmTesteeContext.SetBinding(gridTrainings, answers => answers.DataSource, "Testee.Trainings");
            mvvmTesteeContext.SetBinding(trainingsRepositoryItemLookUpEdit, training => training.DataSource, "AllTrainings");
         
            trainingsRepositoryItemLookUpEdit.DisplayMember = "TrainingTitle";
            trainingsRepositoryItemLookUpEdit.ValueMember = "TrainingTitle";  
                 
            //TODO: Rewrite binding to mvvmTesteeSettingsContext bindings
            var outer = new BindingSource { DataSource = model.Testee };
            var inner = new BindingSource(outer, "UserSetting");
            questionAmountSpinEdit.DataBindings.Add("EditValue", inner, "AmountOfQuestionsPerDay");
            frequencySpinEdit.DataBindings.Add("EditValue", inner, "FrequencyOfAsking");
            canEditToggleSwitch.DataBindings.Add("EditValue", inner, "CanUserEdit");
            timeOfStartTimeEdit.DataBindings.Add("EditValue", inner, "TimeOfStart");
        }               

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
            resources.ApplyResources(questionAmountLayoutControlItem, "questionAmountLayoutControlItem", newCultureInfo);
            resources.ApplyResources(frequencyLayoutControlItem, "frequencyLayoutControlItem", newCultureInfo);
            resources.ApplyResources(timeOfStartTimeEditLayoutControlItem, "timeOfStartTimeEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(timeOfStartTimeEditLayoutControlItem, "timeOfStartTimeEditLayoutControlItem", newCultureInfo);
            this.Text = resources.GetString("Title", newCultureInfo) + (Testee != null && !String.IsNullOrEmpty(Testee.Login) ? ":" + Testee.Login : "");
        }

        private void gridViewTrainings_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //TODO: get current testee training 
            GridView v = sender as GridView;
            var currentValue = v.EditingValue;
            TesteeTraining training = v.GetRow(e.RowHandle) as TesteeTraining;
            training.Training = model.AllTrainings.Where(_ => _.TrainingTitle == currentValue.ToString()).First();
            training.TrainingID = model.AllTrainings.Where(_ => _.TrainingTitle == currentValue.ToString()).First().Id;
            training.TesteeID = model.Testee.Id;
        }
    }
}