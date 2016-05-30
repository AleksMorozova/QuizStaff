using DataTransferObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TrainingEditForm
{
    public class TrainingViewModel
    {
        public TrainingDTO Training { get; set; }

        public void EditQuestion(QuestionDTO question)
        {
            AddEditQuestionForm.AddEditQuestionForm questionForm = new AddEditQuestionForm.AddEditQuestionForm(question);
            questionForm.ShowDialog();
        }

        public void AddQuestion(TrainingDTO training)
        {
            AddEditQuestionForm.AddEditQuestionForm questionForm = new AddEditQuestionForm.AddEditQuestionForm();
            questionForm.ShowDialog();
            questionForm.Question.TrainingId = training.Id;
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
