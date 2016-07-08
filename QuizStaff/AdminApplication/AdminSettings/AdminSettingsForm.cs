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
using System.Globalization;
using DataTransferObject;
using DomainModel;

namespace AdminApplication.AdminSettings
{
    public partial class AdminSettingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private AdminSettingsViewModel model;

        public AdminSettingsForm()
        {
            InitializeComponent();

            mvvmAdminSettingsContext.ViewModelType = typeof(AdminSettingsViewModel);
            //BindCommands();
            model = mvvmAdminSettingsContext.GetViewModel<AdminSettingsViewModel>();
            mvvmAdminSettingsContext.SetViewModel(typeof(AdminSettingsViewModel), model);
            model.GetAllTestees();
            BindToViewModel();
        }

        private void BindCommands()
        {
            mvvmAdminSettingsContext.BindCommand<AdminSettingsViewModel, BindingList<Testee>>(saveButton, (viewModel, questionID)
                => viewModel.EditSettings(questionID), x => GetSelectedTestees());
        }

        private BindingList<Testee> GetSelectedTestees() 
        {
            //TODO: Get selected testees 
            BindingList<Testee> selectedTestee = new BindingList<Testee>();
            if (this.model != null && this.model.Testees != null)
            {
                var test = model.Testees.Where(_ => _.IsSelected);
            foreach (var t in test)
                selectedTestee.Add(t);}

            return (this.model != null && this.model.Testees != null) ? selectedTestee : new BindingList<Testee>();
        }

        private void BindToViewModel()
        {      
            mvvmAdminSettingsContext.SetBinding(testeeListGridControl, testee => testee.DataSource, "Testees");
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(AdminSettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);

            resources.ApplyResources(usersListLayoutControlItem, "usersListLayoutControlItem", newCultureInfo);
            resources.ApplyResources(lastNameGridColumn, "lastNameGridColumn", newCultureInfo);
            resources.ApplyResources(firstNameGridColumn, "firstNameGridColumn", newCultureInfo);
            resources.ApplyResources(amountOfQuestionsPerDayGridColumn, "amountOfQuestionsPerDayGridColumn", newCultureInfo);
            resources.ApplyResources(attribute10GridColumn, "attribute10GridColumn", newCultureInfo);
            resources.ApplyResources(attribute1GridColumn, "attribute1GridColumn", newCultureInfo);
            resources.ApplyResources(attribute2GridColumn, "attribute2GridColumn", newCultureInfo);
            resources.ApplyResources(attribute3GridColumn, "attribute3GridColumn", newCultureInfo);
            resources.ApplyResources(attribute4GridColumn, "attribute4GridColumn", newCultureInfo);
            resources.ApplyResources(attribute5GridColumn, "attribute5GridColumn", newCultureInfo);
            resources.ApplyResources(attribute6GridColumn, "attribute6GridColumn", newCultureInfo);
            resources.ApplyResources(attribute7GridColumn, "attribute7GridColumn", newCultureInfo);
            resources.ApplyResources(attribute8GridColumn, "attribute8GridColumn", newCultureInfo);
            resources.ApplyResources(attribute9GridColumn, "attribute9GridColumn", newCultureInfo);
            resources.ApplyResources(attribute10GridColumn, "attribute10GridColumn", newCultureInfo);
            resources.ApplyResources(frequencyOfAskingGridColumn, "frequencyOfAskingGridColumn", newCultureInfo);
            resources.ApplyResources(timeOfStartGridColumn, "timeOfStartGridColumn", newCultureInfo);
            resources.ApplyResources(canEditGridColumn, "canEditGridColumn", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(showCorrectAnswerGridColumn, "showCorrectAnswerGridColumn", newCultureInfo);
            resources.ApplyResources(checkGridColumn, "checkGridColumn", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Settings";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO: Refresh grid and return command binding 
            model.EditSettings(GetSelectedTestees());
            model.GetAllTestees();
            testeeListGridControl.DataSource = model.Testees;
        }
    }
}