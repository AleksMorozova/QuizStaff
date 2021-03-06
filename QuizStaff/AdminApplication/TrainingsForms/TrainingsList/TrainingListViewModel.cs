﻿using AdminApplication.TrainingsForms.TrainingAddEdit;
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

namespace AdminApplication.TrainingsListForm
{
    public delegate void TrainingChangedEventHandler(object sender, EventArgs e);

    public class TrainingListViewModel
    {
        public BindingList<Training> Trainings { get; set; }
        private TrainingDTO[] ReadTrainings;

        public void GetAllTrainings()
        {
            Trainings = new BindingList<Training>();

            ReadTrainings = ServicesHolder.ServiceClient.GetAllActiveTrainings();

            foreach (var training in ReadTrainings)
            {
                if (training.IsActive)
                    Trainings.Add(Conversion.ConvertTrainingFromDTO(training));
            }
        }

        public void AddTraining()
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm();
            FormManager.Instance.OpenChildForm(trainingForm, "Add training");
            FormManager.LocalizedFormList.Add(trainingForm);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
            this.Trainings.Add(trainingForm.Training);
        }

        public void EditTraining(Training editedTraining)
        {
            TrainingAddEditForm trainingForm = new TrainingAddEditForm(editedTraining);
            FormManager.Instance.OpenChildForm(trainingForm, "Edit training: " + editedTraining.TrainingTitle);
            FormManager.LocalizedFormList.Add(trainingForm);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
        }

        public void DeleteTraining(Training deletedTraining)
        {
            if (deletedTraining != null)
            {
                if (deletedTraining.Id != Guid.Empty)
                {
                    deletedTraining.IsActive = false;
                    ServicesHolder.ServiceClient.SaveTraining(deletedTraining);
                }
                else
                {
                    var savedTraining = ServicesHolder.ServiceClient.FindByTitle(deletedTraining.TrainingTitle);
                    savedTraining.IsActive = false;
                    ServicesHolder.ServiceClient.SaveTraining(savedTraining);
                }
                this.Trainings.Remove(deletedTraining);
                OnTrainingListChanged(EventArgs.Empty);
            }
        }

        public void LoadTrainings()
        {
            ServicesHolder.ServiceClient.LoadTrainings();
            XtraMessageBox.Show("Trainings was successfully load");
        }

        public void LoadQuestions()
        {
            ServicesHolder.ServiceClient.LoadAdditionalQuestions();
            XtraMessageBox.Show("Questions was successfully load");
        }

        public event TrainingChangedEventHandler TrainingListChanged;
        protected virtual void OnTrainingListChanged(EventArgs e)
        {
            if (TrainingListChanged != null)
                TrainingListChanged(this, e);
        }
    }
}
