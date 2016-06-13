﻿using System;
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

namespace Client.TesteesForm.TesteeAddEdit
{
    public partial class AddEditTesteeForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
       private TesteeViewModel model;
       private TesteeDTO currentTestee;

        public AddEditTesteeForm()
            : this(new TesteeDTO()) { }

        public AddEditTesteeForm(TesteeDTO testee)
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
            mvvmTesteeContext.BindCommand<TesteeViewModel>(cancelButton, viewModel => viewModel.Cancel());

            mvvmTesteeContext.BindCommand<TesteeViewModel, TesteeDTO>(addTrainingButton, (viewModel, testee)
                => viewModel.AddTraining(testee), x => currentTestee);
            
            mvvmTesteeContext.BindCommand<TesteeViewModel, TesteeDTO>(saveButton, (viewModel, testee)
                => viewModel.Save(testee), x => currentTestee);
        }

        private void BindToViewModel()
        {
            mvvmTesteeContext.SetBinding(textFirstName, questionText => questionText.EditValue, "Testee.FirstName");
            mvvmTesteeContext.SetBinding(textLastName, questionText => questionText.EditValue, "Testee.LastName");
            mvvmTesteeContext.SetBinding(textEmail, questionText => questionText.EditValue, "Testee.Email");
            mvvmTesteeContext.SetBinding(textLogin, questionText => questionText.EditValue, "Testee.Login");
            mvvmTesteeContext.SetBinding(spinEditQuestAmount, questionText => questionText.EditValue, "Testee.UserSetting.AmountOfQuestionsPerDay");
            mvvmTesteeContext.SetBinding(spinEditFrqOfAsk, questionText => questionText.EditValue, "Testee.UserSetting.FrequencyOfAsking");
            mvvmTesteeContext.SetBinding(gridTrainings, answers => answers.DataSource, "Testee.Trainings");

            mvvmTesteeContext.SetBinding(trainingsRepositoryItemLookUpEdit, training => training.DataSource, "AllTrainings");
            trainingsRepositoryItemLookUpEdit.DisplayMember = "TrainingTitle";
            trainingsRepositoryItemLookUpEdit.ValueMember = "TrainingTitle";
        }               

        public TesteeDTO Testee
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
            resources.ApplyResources(layoutControlItemFirstName, "layoutControlItemFirstName", newCultureInfo);
            resources.ApplyResources(layoutControlItemLastName, "layoutControlItemLastName", newCultureInfo);
            resources.ApplyResources(layoutControlItemLogin, "layoutControlItemLogin", newCultureInfo);
            resources.ApplyResources(layoutControlItemEmail, "layoutControlItemEmail", newCultureInfo);
            resources.ApplyResources(addTrainingButton, "addTrainingButton", newCultureInfo);
            resources.ApplyResources(layoutControlItemTranings, "layoutControlItemTranings", newCultureInfo);
            resources.ApplyResources(gridTrainings, "gridTrainings", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            resources.ApplyResources(titleGridColumn, "titleGridColumn", newCultureInfo);
            resources.ApplyResources(layoutControlItemQuestionAmount, "layoutControlItemQuestionAmount", newCultureInfo);
            resources.ApplyResources(layoutControlItemFreqOfAsk, "layoutControlItemFreqOfAsk", newCultureInfo);
            resources.ApplyResources(layoutControlItemCanUserEdit, "layoutControlItemCanUserEdit", newCultureInfo);
            resources.ApplyResources(layoutControlItemCanUserEdit, "layoutControlItemCanUserEdit", newCultureInfo);
            resources.ApplyResources(layoutControlItemCanUserEdit, "layoutControlItemCanUserEdit", newCultureInfo);
            this.Text = resources.GetString("Title", newCultureInfo) + (Testee != null && !String.IsNullOrEmpty(Testee.Login) ? ":" + Testee.Login : "");
        }

        private void gridViewTrainings_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //TODO: get current testee training 
            GridView v = sender as GridView;
            var currentValue = v.EditingValue;
            TesteeTrainingDTO training = v.GetRow(e.RowHandle) as TesteeTrainingDTO;
            training.Training = model.AllTrainings.Where(_ => _.TrainingTitle == currentValue.ToString()).First();
            training.TrainingID = model.AllTrainings.Where(_ => _.TrainingTitle == currentValue.ToString()).First().Id;
            training.TesteeID = model.Testee.Id;
        }
    }
}