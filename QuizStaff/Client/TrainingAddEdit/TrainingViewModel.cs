using DataTransferObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TrainingEditForm
{
    public class TrainingViewModel
    {
        private BindingList<QuestionDTO> questions;

        private TrainingDTO training;
        public TrainingDTO Training
        { 
            get 
            { 
                return training; 
            } 
            set 
            {
                if (value != null)
                    training = value; 
            } 
        }

        public TrainingViewModel() 
        {
            questions = new BindingList<QuestionDTO>();
        }

        public String TrainingTitle { get; set; }

        public BindingList<QuestionDTO> Questions 
        { 
            get { return questions; } 
            set { questions = value; } 
        }

        public void LoadTraining(Guid id)
        {
            if (id == Guid.Empty)
            {
                this.Training = new TrainingDTO();
            }
            else
            {
                this.Training = ServicesHolder.ServiceClient.GetTraining(id);
            }
        }

        public void EditQuestion(QuestionDTO question)
        {
            AddEditQuestionForm.AddEditQuestionForm questionForm = new AddEditQuestionForm.AddEditQuestionForm(question.Id);
            questionForm.ShowDialog();
            //TODO: implement updating of questions list
        }

        public void AddQuestion(TrainingDTO training)
        {
            if (training!=null)
            {
                LoadTraining(training.Id);
            }
            AddEditQuestionForm.AddEditQuestionForm questionForm = new AddEditQuestionForm.AddEditQuestionForm();
            questionForm.ShowDialog();
            training.Questions.Add(questionForm.Question);
        }

        public void Cancel()
        {
            //TODO: cancel edeting 
        }

        public void Save(TrainingDTO training)
        {
            if (training != null)
            {
                if (training.Id == Guid.Empty)
                {
                    ServicesHolder.ServiceClient.SaveTraining(training);
                }
                else
                {
                    ServicesHolder.ServiceClient.UpdateTraining(training);
                }
            }
        }
        
        public void LoadQuestions()
        {
            // TODO: implement loading of questions from external source
            XtraMessageBox.Show("Load questions");
        }
    }
}
