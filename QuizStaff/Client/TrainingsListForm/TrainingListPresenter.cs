using System.Collections.Generic;
using System.Windows.Forms;
using DomainModel;
using DataTransferObject;
using System.Collections.ObjectModel;
using System.Linq;

namespace Client
{
    public class TrainingListPresenter
    {
        private ITrainingsListForm trainingListForm;
        private ICollection<TrainingDTO> trainings = new ObservableCollection<TrainingDTO>();
        private Client.ServiceReference.ApplicationServerClient server;

        public TrainingListPresenter(ITrainingsListForm trainingListForm)
        {
            this.server = ServicesHolder.ServiceClient;
            this.trainingListForm = trainingListForm;                        
            LoadAllTrainings();            
        }

        public void LoadAllTrainings()
        {                 
            this.trainings = server.GetAllTrainings();
            trainingListForm.SetBindings(this.trainings);
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

        public void EditTraining(TrainingDTO editedTraining)
        {
            // mock object            
            MessageBox.Show("Edited training: " + editedTraining.TrainingTitle);
        }

        public void Save()
        {               
            // mock object 
            this.server.SaveAllTrainings(this.trainings.ToArray());
            MessageBox.Show("Trainings is saved: ");
        }

        public void Cancel()
        {
            // mock object                        
        }

    }
}
