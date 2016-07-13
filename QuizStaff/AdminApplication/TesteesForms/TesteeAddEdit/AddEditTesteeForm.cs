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

namespace AdminApplication.TesteesForm.TesteeAddEdit
{
    public partial class AddEditTesteeForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
       private TesteeViewModel model;

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
            model.GetAllTrainings();
            model.SetUpViewModel(testee);
            mvvmTesteeContext.SetViewModel(typeof(TesteeViewModel), model);          
            BindToViewModel(); 
        }               

        private void BindCommand()
        {
            mvvmTesteeContext.BindCommand<TesteeViewModel>(saveButton, viewModel => viewModel.Save());
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
            var inner = new BindingSource { DataSource = model.Setting };
            questionAmountSpinEdit.DataBindings.Add("EditValue", inner, "AmountOfQuestionsPerDay");
            frequencySpinEdit.DataBindings.Add("EditValue", inner, "FrequencyOfAsking");
            canEditToggleSwitch.DataBindings.Add("EditValue", inner, "CanUserEdit");
            timeOfStartTimeEdit.DataBindings.Add("EditValue", inner, "TimeOfStart");
            showAnswerToggleSwitch.DataBindings.Add("EditValue", inner, "ShowCorrectAnswer");
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
            resources.ApplyResources(showAnswerToggleSwitchLayoutControlItem, "showAnswerToggleSwitchLayoutControlItem", newCultureInfo);
            resources.ApplyResources(canEditToggleSwitchLayoutControlItem, "canEditToggleSwitchLayoutControlItem", newCultureInfo);
            resources.ApplyResources(settingLayoutControlGroup, "settingLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(generalInfLayoutControlGroup, "generalInfLayoutControlGroup", newCultureInfo);
            
            string title = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Testee";
            this.Text = title + (Testee != null && !String.IsNullOrEmpty(Testee.Login) ? ":" + Testee.Login : "");
        }

        private void gridViewTrainings_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //TODO: get current testee training 
            GridView v = sender as GridView;
            var currentValue = v.EditingValue;           
            TesteeTraining training = v.GetRow(e.RowHandle) as TesteeTraining;
            training.IsActive = true;
            training.IsSelect = true;

            if (currentValue != null)
                training.Training = model.AllTrainings.Where(_ => _.TrainingTitle == currentValue.ToString()).First();

        }

        private TesteeTraining GetCurrentTesteeTraining()
        {
            int rowHandler = this.gridViewTrainings.FocusedRowHandle;
            var editedTesteeTraining = (TesteeTraining)gridViewTrainings.GetRow(rowHandler);
            return editedTesteeTraining;
        }

        private void gridTrainings_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                var testeeTraining = GetCurrentTesteeTraining();
                if (testeeTraining != null)
                {
                    testeeTraining.IsActive = false;

                    TesteeTraining newTesteeTraining = new TesteeTraining();
                    newTesteeTraining.Id = testeeTraining.Id;
                    newTesteeTraining.IsActive = testeeTraining.IsActive;
                    newTesteeTraining.Training = Conversion.ConvertTrainingFromDTO(testeeTraining.Training);
                    // TODO: implement discarding of entity 
                    ServicesHolder.ServiceClient.DeleteTesteeTraining(Conversion.ConvertTesteeTrainingToDTO(newTesteeTraining));
                }
            }
        }

        private void trainingsRepositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var testeeTraining = GetCurrentTesteeTraining();

            GridLookUpEdit editor = (sender as GridLookUpEdit);
            var currentTraining = editor.EditValue;
            if (currentTraining != null)
                testeeTraining.Training = model.AllTrainings.Where(_ => _.TrainingTitle == currentTraining.ToString()).First();
        }
    }
}