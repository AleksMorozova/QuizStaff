﻿using DataTransferObject;
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
            TrainingAddEdit trainingForm = new TrainingAddEdit();
            FormManager.Instance.OpenChildForm(trainingForm, "Add training");
            trainings.Add(trainingForm.Training);
        }

        public void EditTraining(TrainingDTO editedTraining)
        {
            TrainingAddEdit trainingForm = new TrainingAddEdit(editedTraining);
            FormManager.Instance.OpenChildForm(trainingForm, "Edit training: " + editedTraining.TrainingTitle);
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
