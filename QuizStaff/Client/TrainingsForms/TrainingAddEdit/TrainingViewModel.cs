using Client.TrainingsForms.TrainingQuestion;
using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TrainingsForms.TrainingAddEdit
{
    public class TrainingViewModel
    {
        public Training Training { get; set; }

        public void EditQuestion(Question question)
        {
            AddEditQuestionForm questionForm = new AddEditQuestionForm(question);
            FormManager.childForms.Add(questionForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            questionForm.ShowDialog();
        }

        public void AddQuestion(Training training)
        {
            AddEditQuestionForm questionForm = new AddEditQuestionForm();
            FormManager.childForms.Add(questionForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            questionForm.ShowDialog();
            questionForm.Question.TrainingId = training.Id;
            training.Questions.Add(questionForm.Question);
        }

        public void DeleteQuestion(Question deletedQuestion)
        {
            deletedQuestion.IsActive = false;
            ServicesHolder.ServiceClient.UpdateQuestion(deletedQuestion);
        }

        public void Cancel()
        {
            //TODO: cancel edeting 
        }

        public void Save(Training training)
        {
            if (training != null)
            {
                if (training.Id == Guid.Empty)
                {
                    ServicesHolder.ServiceClient.SaveTraining(Conversion.ConvertTrainingToDTO(training));
                }
                else
                {
                    ServicesHolder.ServiceClient.UpdateTraining(Conversion.ConvertTrainingToDTO(training));
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
