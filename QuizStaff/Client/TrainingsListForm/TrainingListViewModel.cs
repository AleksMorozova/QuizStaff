using DataTransferObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TrainingsListForm
{
    public class TrainingListViewModel
    {
        public BindingList<TrainingDTO> AllTrainings { get; set; }

        public List<TrainingDTO> Trainings = new List<TrainingDTO>();

        public void GetAllTrainings()
        {
            AllTrainings = new BindingList<TrainingDTO>();
            this.Trainings.AddRange(ServicesHolder.ServiceClient.GetAllTrainings());
            foreach (var t in Trainings)
            {
                AllTrainings.Add(t);
            }
        }

        public void AddTraining(BindingList<TrainingDTO> trainings)
        {
            TrainingAddEdit f = new TrainingAddEdit();
            FormManager.Instance.OpenChildForm(f, "Add training");
            trainings.Add(f.Training);
        }

        public void EditTraining(TrainingDTO editedTraining)
        {
            TrainingAddEdit f = new TrainingAddEdit(editedTraining);
            FormManager.Instance.OpenChildForm(f, "Edit training: " + editedTraining.TrainingTitle);
        }

        public void Save()
        {            
            // TODO: implement save of loaded of trainings
            XtraMessageBox.Show("Save");
        }

        public void Cancel()
        {
            // TODO: implement cancel of loading of trainings
            XtraMessageBox.Show("Cancel");           
        }

        public void LoadTrainings()
        {
            // TODO: implement loading of trainings from external source
            XtraMessageBox.Show("Load trainings");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }    
    }
}
