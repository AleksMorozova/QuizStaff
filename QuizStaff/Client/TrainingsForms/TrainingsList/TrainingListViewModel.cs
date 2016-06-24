using Client.TrainingsForms.TrainingAddEdit;
using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
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
        public BindingList<Training> Trainings { get; set; }

        public void GetAllTrainings()
        {
            Trainings = new BindingList<Training>();
            var trainingsList = ServicesHolder.ServiceClient.GetAllTrainings();
            foreach (var training in trainingsList)
            {
                Trainings.Add(Conversion.ConvertTrainingFromDTO(training));
            }
        }

        public void AddTraining()
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm();
            FormManager.Instance.OpenChildForm(trainingForm, "Add training");
            FormManager.LocalizedFormList.Add(trainingForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            this.Trainings.Add(trainingForm.Training);
        }

        public void EditTraining(Training editedTraining)
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm(editedTraining);
            FormManager.Instance.OpenChildForm(trainingForm, "Edit training: " + editedTraining.TrainingTitle);
            FormManager.LocalizedFormList.Add(trainingForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
        }

        public void DeleteTraining(TrainingDTO deletedTraining)
        {
            deletedTraining.IsActive = false;
            ServicesHolder.ServiceClient.UpdateTraining(deletedTraining);
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
