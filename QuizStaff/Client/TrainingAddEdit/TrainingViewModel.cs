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
        public virtual TrainingDTO Training { get; set; }

        public TrainingViewModel() 
        {
            questions = new BindingList<QuestionDTO>();
        }

        public String TrainingTitle { get; set; }
        public BindingList<QuestionDTO> Questions { get { return questions; } set { questions = value; } }

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

            //this.Training = new TrainingDTO() { TrainingTitle = "Test training", Questions = new BindingList<QuestionDTO>() { new QuestionDTO() { QuestionText = "Test question" } } };
        }

        public void EditQuestion(Guid id)
        {
            AddEditQuestionForm.AddEditQuestionForm questionForm = new AddEditQuestionForm.AddEditQuestionForm(id);
            questionForm.ShowDialog();
        }

        public void AddQuestion()
        {
            AddEditQuestionForm.AddEditQuestionForm questionForm = new AddEditQuestionForm.AddEditQuestionForm();
            questionForm.ShowDialog();
            this.Training.Questions.Add(questionForm.Question);
        }

        public void Cancel()
        {
            //TODO: cancel edeting 
        }
        
        public void Save()
        {
           // ServicesHolder.ServiceClient.s
        }
        
        public void LoadQuestions()
        {
            // TODO: implement loading of questions from external source
            XtraMessageBox.Show("Load questions");
        }
    }
}
