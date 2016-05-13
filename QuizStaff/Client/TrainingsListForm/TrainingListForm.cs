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

        public TrainingListForm()
        {            
            InitializeComponent();
            this.presenter = new TrainingListPresenter(this);           
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
            TrainingDTO editedTraining = (TrainingDTO)((GridView)gridTrainingList.MainView).GetFocusedRow();
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