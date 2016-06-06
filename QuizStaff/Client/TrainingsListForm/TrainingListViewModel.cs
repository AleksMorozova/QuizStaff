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
        public BindingList<TrainingDTO> Trainings { get; set; }

        public void GetAllTrainings()
        {
            Trainings = new BindingList<TrainingDTO>();
            var trainingsList = ServicesHolder.ServiceClient.GetAllTrainings();
            foreach (var training in trainingsList)
            {
                Trainings.Add(training);
            }
        }

        public void AddTraining(BindingList<TrainingDTO> trainings)
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm();
            FormManager.Instance.OpenChildForm(trainingForm, "Add training");            
            FormManager.Instance.LocalizedForms(Program.currentLang);
            trainings.Add(trainingForm.Training);
        }

        public void EditTraining(TrainingDTO editedTraining)
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm(editedTraining);
            FormManager.Instance.OpenChildForm(trainingForm, "Edit training: " + editedTraining.TrainingTitle);
            FormManager.Instance.LocalizedForms(Program.currentLang);
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
    }
}
