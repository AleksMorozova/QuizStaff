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
            TrainingAddEdit f = new TrainingAddEdit();
            FormManager.Instance.OpenChildForm(f, "Add training");
        }

        public void LoadTraining()
        {
            // mock object
            LoadAllTrainings();
            MessageBox.Show("Load trainings");
        }

        public void EditTraining(TrainingDTO editedTraining)
        {
            TrainingAddEdit f = new TrainingAddEdit(editedTraining.Id);
            FormManager.Instance.OpenChildForm(f, "Edit training: "+ editedTraining.TrainingTitle);
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
