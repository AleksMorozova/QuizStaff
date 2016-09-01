using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DataTransferObject;
using System.ComponentModel;
using System.Globalization;
using DomainModel;


namespace AdminApplication.TesteesForms.TesteesList
{
    public partial class TesteesListForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private TesteesListViewModel model;       

        public TesteesListForm()
        {
            InitializeComponent();

            mvvmTesteesContext.ViewModelType = typeof(TesteesListViewModel);
            model = mvvmTesteesContext.GetViewModel<TesteesListViewModel>();     
            BindCommands();
            mvvmTesteesContext.SetViewModel(typeof(TesteesListViewModel), model);
            model.GetAllTestee();
            model.TesteeListChanged += new TesteeChangedEventHandler(TesteeListChanged);
            BindToViewModel();            
        }

        private void BindCommands()
        {
            mvvmTesteesContext.BindCommand<TesteesListViewModel>(buttonSave, viewModel => viewModel.Save());
            mvvmTesteesContext.BindCommand<TesteesListViewModel>(buttonCancel, viewModel => viewModel.Cancel());
            mvvmTesteesContext.BindCommand<TesteesListViewModel>(loadTesteesButton , viewModel => viewModel.LoadTestees());
            mvvmTesteesContext.BindCommand<TesteesListViewModel>(addTesteeButton, viewModel => viewModel.AddTestee());
            mvvmTesteesContext.BindCommand<TesteesListViewModel, Testee>(editTesteeButton,
                (x, currentTestee) => x.EditTestee (currentTestee), x => GetCurrentTestee());
            mvvmTesteesContext.BindCommand<TesteesListViewModel, Testee>(deleteTesteeButton,
                (x, currentTestee) => x.DeleteTestee(currentTestee), x => GetCurrentTestee());
        }

        private void BindToViewModel()
        {
            mvvmTesteesContext.SetBinding(gridTestees , testee => testee.DataSource, "Testees");              
        }
       
        private void TesteeListChanged(object sender, EventArgs e)
        {
            gridTestees.Refresh();
        }

        private Testee GetCurrentTestee()
        {
            int rowHandler = testeeGridView.FocusedRowHandle;
            var editedTestee = (Testee)testeeGridView.GetRow(rowHandler);
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
            resources.ApplyResources(addTesteeButton, "addTesteeButton", newCultureInfo);
            resources.ApplyResources(testeesLayoutControlItem, "testeesLayoutControlItem", newCultureInfo);
            resources.ApplyResources(editTesteeButton, "editTesteeButton", newCultureInfo);
            resources.ApplyResources(loadTesteesButton, "loadTesteesButton", newCultureInfo);
            resources.ApplyResources(deleteTesteeButton , "deleteTesteeButton", newCultureInfo);
            resources.ApplyResources(columnEmail, "columnEmail", newCultureInfo);
            resources.ApplyResources(columnFirstName, "columnFirstName", newCultureInfo);
            resources.ApplyResources(columnLastName, "columnLastName", newCultureInfo);
            resources.ApplyResources(columnLogin, "columnLogin", newCultureInfo);
            resources.ApplyResources(columnTrainings, "columnTrainings", newCultureInfo);
            resources.ApplyResources(buttonCancel, "buttonCancel", newCultureInfo);
            resources.ApplyResources(buttonSave, "buttonSave", newCultureInfo);
            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ?resources.GetString("Title", newCultureInfo):"Testees";
        }
    }
}