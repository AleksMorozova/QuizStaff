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
            Localized(Program.currentLang);

            mvvmEditTesteesTrainingsContext.ViewModelType = typeof(EditTesteesTrainingsViewModel);
            model = mvvmEditTesteesTrainingsContext.GetViewModel<EditTesteesTrainingsViewModel>();
            model.SetUpTrainigs(SelectedTestees);
            mvvmEditTesteesTrainingsContext.SetViewModel(typeof(EditTesteesTrainingsViewModel), model);
            BindToViewModel();
        }
        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(EditTesteesTrainingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(testeeTraingsGridlayoutControl, "testeeTraingsGridlayoutControl", newCultureInfo);
            resources.ApplyResources(simpleButtonApply, "simpleButtonApply", newCultureInfo);
            resources.ApplyResources(simpleButtonCancel, "simpleButtonCancel", newCultureInfo);
            resources.ApplyResources(Trainings, "Trainings", newCultureInfo);
            resources.ApplyResources(IsSelected, "IsSelected", newCultureInfo);
            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Edit testees and trainings";
        }
        
        private void BindToViewModel()
        {
            mvvmEditTesteesTrainingsContext.SetBinding(gridControlTesteesTrainings, trainings => trainings.DataSource, "Trainigs");
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}