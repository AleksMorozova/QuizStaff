using DevExpress.XtraEditors;
using DevExpress.Mvvm;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApplication.AdminSettings
{
    public partial class EditTesteesTrainingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private EditTesteesTrainingsViewModel model;
        public EditTesteesTrainingsForm(BindingList<Testee> SelectedTestees)
        {
            InitializeComponent();
            Localized(Program.СurrentLang);

            mvvmEditTesteesTrainingsContext.ViewModelType = typeof(EditTesteesTrainingsViewModel);
            BindCommand();
            model = mvvmEditTesteesTrainingsContext.GetViewModel<EditTesteesTrainingsViewModel>();
            model.SetUpTrainigs(SelectedTestees);
            mvvmEditTesteesTrainingsContext.SetViewModel(typeof(EditTesteesTrainingsViewModel), model);
            BindToViewModel();
        }
      
        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(EditTesteesTrainingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(testeeTraingLayoutControlItem, "testeeTraingsGridlayoutControl", newCultureInfo);
            resources.ApplyResources(applyButton, "simpleButtonApply", newCultureInfo);
            resources.ApplyResources(cancelButton, "simpleButtonCancel", newCultureInfo);
            resources.ApplyResources(Trainings, "Trainings", newCultureInfo);
            resources.ApplyResources(IsSelected, "IsSelected", newCultureInfo);
            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Edit testees and trainings";
        }
        
        private void BindCommand()
        {
            mvvmEditTesteesTrainingsContext.BindCommand<EditTesteesTrainingsViewModel>(applyButton, viewModel => viewModel.SaveSelectChanges());
        }
        
        private void BindToViewModel()
        {
            mvvmEditTesteesTrainingsContext.SetBinding(testeesTrainingsGridControl, trainings => trainings.DataSource, "Trainigs");
        }
    }
}