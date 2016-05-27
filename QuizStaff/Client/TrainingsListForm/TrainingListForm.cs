using System;
using System.Collections.Generic;
using DomainModel;
using DevExpress.XtraGrid.Views.Grid;
using DataTransferObject;
using DevExpress.Mvvm;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Client.TrainingsListForm
{
    public partial class TrainingListForm : DevExpress.XtraEditors.XtraForm
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
            mvvmTrainingsContext.BindCommand<TrainingListViewModel, TrainingDTO>(buttonEditTraining,
                (x, currentTraining) => x.EditTraining(currentTraining), x => GetCurrentTraining());


            mvvmTrainingsContext.BindCommand<TrainingListViewModel, BindingList<TrainingDTO>>(buttonAddTraining,
    (x, currentTraining) => x.AddTraining(currentTraining), x => GetCurrentTrainings());
        }

        private void BindToViewModel()
        {
            mvvmTrainingsContext.SetBinding(trainingsGridControl, training => training.DataSource, "AllTrainings");
        }

        private BindingList<TrainingDTO> GetCurrentTrainings()
        {
            return (model!=null)? model.AllTrainings:
                new BindingList<TrainingDTO>();
        }

        private TrainingDTO GetCurrentTraining() 
        {
            int rowHandler = trainingsGridView.FocusedRowHandle;
            var editedTraining = (TrainingDTO)trainingsGridView.GetRow(rowHandler);
            return editedTraining;
        }
    }
}