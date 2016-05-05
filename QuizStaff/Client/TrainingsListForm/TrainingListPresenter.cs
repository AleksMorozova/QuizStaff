using System.Collections.Generic;
using System.Windows.Forms;
using Server;
using DomainModel;

namespace Client
{
    public class TrainingListPresenter
    {
        ITrainingsListForm trainingListForm;
        IApplicationServer server;
        List<Training> trainingList = new List<Training>();      

        public TrainingListPresenter(ITrainingsListForm trainingListForm)
        {
            this.trainingListForm = trainingListForm;
            this.server = new ApplicationServer();
            this.trainingListForm.presenter = this;
            LoadAllTrainings();            
        }

        public void LoadAllTrainings()
        {
            this.trainingList = server.GetAllTrainings();
            trainingListForm.SetBindings(this.trainingList);
        }

        public void AddTraining()
        {
            // mock object
            MessageBox.Show("Added new training");
        }

        public void LoadTraining()
        {
            // mock object
            LoadAllTrainings();
            MessageBox.Show("Load trainings");
        }

        public void EditTraining(Training editedTraining)
        {
            // mock object            
            MessageBox.Show("Edited training: " + editedTraining.TrainingTitle);
        }

        public void Save()
        {
            // mock object 
            this.server.SaveAllTrainings(this.trainingList);
            MessageBox.Show("Trainings is saved: ");
        }

        public void Cancel()
        {
            // mock object                        
        }

    }
}
