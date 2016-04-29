using System;
using System.Collections.Generic;
using DomainModel;
using DevExpress.XtraGrid.Views.Grid;

namespace Client.TrainingsListForm
{
    public partial class TrainingListForm : DevExpress.XtraEditors.XtraForm, ITrainingsListForm
    {
        public TrainingListPresenter presenter { get; set; }
           
        public TrainingListForm()
        {            
            InitializeComponent();            
        }

        public void SetBindings(List<Training> trainingList)
        {
            gridTrainingList.DataSource = trainingList;
        }

        private void buttonAddTraining_Click(object sender, EventArgs e)
        {
            presenter.AddTraining();
        }

        private void buttonEditTraining_Click(object sender, EventArgs e)
        {
            Training editedTraining = (Training)((GridView)gridTrainingList.MainView).GetFocusedRow();
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