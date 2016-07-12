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
using DevExpress.Mvvm;
using DomainModel;

namespace AdminApplication.AdminSettings
{
    public partial class EditTesteesTrainingsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private EditTesteesTrainingsViewModel model;
        public EditTesteesTrainingsForm(BindingList<Testee> SelectedTestees)
        {
            InitializeComponent();

            mvvmEditTesteesTrainingsContext.ViewModelType = typeof(EditTesteesTrainingsViewModel);
            model = mvvmEditTesteesTrainingsContext.GetViewModel<EditTesteesTrainingsViewModel>();
            mvvmEditTesteesTrainingsContext.SetViewModel(typeof(EditTesteesTrainingsViewModel), model);
            BindToViewModel();
        }
        public void Localized(string language)
        {

        }
        
        private void BindToViewModel()
        {
            mvvmEditTesteesTrainingsContext.SetBinding(gridControlTesteesTrainings, trainings => trainings.DataSource, "Trainigs");
        }
    }
}