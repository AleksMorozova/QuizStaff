using System;
using System.Collections.Generic;
using DomainModel;
using DevExpress.XtraGrid.Views.Grid;
using DataTransferObject;
using DevExpress.Mvvm;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Client.TrainingsListForm
{
    public partial class TrainingListForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private TrainingListViewModel model;
      
        public TrainingListForm()
        {            
            InitializeComponent();

            mvvmTrainingsContext.ViewModelType = typeof(TrainingListViewModel);
            BindCommands();
            model = new TrainingListViewModel();
            mvvmTrainingsContext.SetViewModel(typeof(TrainingListViewModel), model);
            model.GetAllTrainings();
            BindToViewModel();
        }

        private void BindCommands()
        {
            mvvmTrainingsContext.BindCommand<TrainingListViewModel>(buttonSave, viewModel => viewModel.Save());
            mvvmTrainingsContext.BindCommand<TrainingListViewModel>(buttonCancel, viewModel => viewModel.Cancel());
            mvvmTrainingsContext.BindCommand<TrainingListViewModel>(buttonLoadTraining, viewModel => viewModel.LoadTrainings());

            mvvmTrainingsContext.BindCommand<TrainingListViewModel, TrainingDTO>(deleteTrainingButton,
              (x, currentTraining) => x.DeleteTraining(currentTraining), x => GetCurrentTraining());
            mvvmTrainingsContext.BindCommand<TrainingListViewModel, TrainingDTO>(buttonEditTraining,
                (x, currentTraining) => x.EditTraining(currentTraining), x => GetCurrentTraining());
            mvvmTrainingsContext.BindCommand<TrainingListViewModel, BindingList<TrainingDTO>>(buttonAddTraining,
                (x, currentTraining) => x.AddTraining(currentTraining), x => GetCurrentTrainings());
        }

        private void BindToViewModel()
        {
            mvvmTrainingsContext.SetBinding(trainingsGridControl, training => training.DataSource, "Trainings");
        }

        private BindingList<TrainingDTO> GetCurrentTrainings()
        {
            return (model!=null)? model.Trainings: new BindingList<TrainingDTO>();
        }

        private TrainingDTO GetCurrentTraining() 
        {
            int rowHandler = trainingsGridView.FocusedRowHandle;
            var editedTraining = (TrainingDTO)trainingsGridView.GetRow(rowHandler);
            return editedTraining;
        }

        private void trainingsGridView_DoubleClick(object sender, EventArgs e)
        {
            model.EditTraining(GetCurrentTraining());
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(TrainingListForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(buttonAddTraining, "buttonAddTraining", newCultureInfo);
            resources.ApplyResources(trainingsLayoutControlItem, "trainingsLayoutControlItem", newCultureInfo);
            resources.ApplyResources(buttonEditTraining, "buttonEditTraining", newCultureInfo);
            resources.ApplyResources(buttonLoadTraining, "buttonLoadTraining", newCultureInfo);
            resources.ApplyResources(titleGridColumn, "titleGridColumn", newCultureInfo);
            resources.ApplyResources(buttonCancel, "buttonCancel", newCultureInfo);
            resources.ApplyResources(buttonSave, "buttonSave", newCultureInfo);
            this.Text = resources.GetString("Title", newCultureInfo);
        }
    }
}