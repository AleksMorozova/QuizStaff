using System;
using System.Collections.Generic;
using DomainModel;
using DevExpress.XtraGrid.Views.Grid;
using DataTransferObject;

namespace Client.TrainingsListForm
{
    public partial class TrainingListForm : DevExpress.XtraEditors.XtraForm, ITrainingsListForm
    {
        public TrainingListPresenter presenter { get; set; }
        private TrainingListViewModel model;
        public TrainingListForm()
        {            
            InitializeComponent();
            this.presenter = new TrainingListPresenter(this);

            mvvmTrainingsContext.ViewModelType = typeof(TrainingListViewModel);
            model = new TrainingListViewModel();
            mvvmTrainingsContext.SetViewModel(typeof(TrainingListViewModel), model);
            model.LoadAllTrainings();
            BindToViewModel();   

        }

        private void BindToViewModel()
        {
            //binding property
            mvvmTrainingsContext.SetBinding(gridTrainingList, answers => answers.DataSource, "Trainings");

            //Binding command
           // mvvmTrainingsContext.BindCommand<QuestionViewModel, QuestionDTO>(saveButton, (viewModel, question) => viewModel.SaveQuestion(question), x => Question);
            //mvvmTrainingsContext.BindCommand<QuestionViewModel>(cancelButton, viewModel => viewModel.Cancel());
        }

        public void SetBindings(ICollection<TrainingDTO> trainingList)
        {
            gridTrainingList.DataSource = trainingList;
        }

        private void buttonAddTraining_Click(object sender, EventArgs e)
        {
            presenter.AddTraining();
        }

        private void buttonEditTraining_Click(object sender, EventArgs e)
        {
            //TrainingDTO editedTraining = (TrainingDTO)((GridView)gridTrainingList.MainView).GetFocusedRow();

            int rowHandler = gridView1.FocusedRowHandle;

            var editedTraining = (TrainingDTO)gridView1.GetRow(rowHandler);


            presenter.EditTraining(editedTraining);
        }

        private void buttonLoadTraining_Click(object sender, EventArgs e)
        {
            presenter.LoadTraining();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            presenter.Cancel();
        }
    }
}