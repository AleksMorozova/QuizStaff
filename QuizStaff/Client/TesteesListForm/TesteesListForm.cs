using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DataTransferObject;
using System.ComponentModel;
using System.Globalization;


namespace Client
{
    public partial class TesteesListForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private TesteesListViewModel model;       

        public TesteesListForm()
        {
            InitializeComponent();

            mvvmTesteesContext.ViewModelType = typeof(TesteesListViewModel);
            BindCommands();
            model = new TesteesListViewModel();
            mvvmTesteesContext.SetViewModel(typeof(TesteesListViewModel), model);
            model.GetAllTestee();
            BindToViewModel();            
        }
        private void BindCommands()
        {
            mvvmTesteesContext.BindCommand<TesteesListViewModel>(buttonSave, viewModel => viewModel.Save());
            mvvmTesteesContext.BindCommand<TesteesListViewModel>(buttonCancel, viewModel => viewModel.Cancel());
            mvvmTesteesContext.BindCommand<TesteesListViewModel>(buttonLoadTestees , viewModel => viewModel.LoadTestees());
            mvvmTesteesContext.BindCommand<TesteesListViewModel, TesteeDTO>(buttonEditTestee,
                (x, currentTestee) => x.EditTestee (currentTestee), x => GetCurrentTestee());
            mvvmTesteesContext.BindCommand<TesteesListViewModel, BindingList<TesteeDTO>>(buttonAddTestee,
                (x, currentTestee) => x.AddTestee (currentTestee), x => GetCurrentTestees());
        }
        private void BindToViewModel()
        {
            mvvmTesteesContext.SetBinding(gridTestees , testee => testee.DataSource, "Testees");              
        }

        private BindingList<TesteeDTO> GetCurrentTestees()
        {
            return (model != null) ? model.Testees : new BindingList<TesteeDTO>();
        }

        private TesteeDTO GetCurrentTestee()
        {
            int rowHandler = testeeGridView.FocusedRowHandle;
            var editedTestee = (TesteeDTO)testeeGridView.GetRow(rowHandler);
            return editedTestee;
        }

        private void testeeGridView_DoubleClick(object sender, EventArgs e)
        {
            model.EditTestee(GetCurrentTestee());
        }
       
        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(TesteesListForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(buttonAddTestee, "buttonAddTestee", newCultureInfo);
            resources.ApplyResources(testeesLayoutControlItem, "testeesLayoutControlItem", newCultureInfo);
            resources.ApplyResources(buttonEditTestee, "buttonEditTestee", newCultureInfo);
            resources.ApplyResources(buttonLoadTestees , "buttonLoadTestee", newCultureInfo);
            resources.ApplyResources(columnEmail, "columnEmail", newCultureInfo);
            resources.ApplyResources(columnFirstName, "columnFirstName", newCultureInfo);
            resources.ApplyResources(columnLastName, "columnLastName", newCultureInfo);
            resources.ApplyResources(columnLogin, "columnLogin", newCultureInfo);
            resources.ApplyResources(columnTrainings, "columnTrainings", newCultureInfo);
            resources.ApplyResources(buttonCancel, "buttonCancel", newCultureInfo);
            resources.ApplyResources(buttonSave, "buttonSave", newCultureInfo);            
        }
    }
}