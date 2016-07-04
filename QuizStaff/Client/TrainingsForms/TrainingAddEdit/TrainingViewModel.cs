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

        public string TrainingTitle
        {
            get
            {
                return Training.TrainingTitle;
            }

            set
            {
                if (value != Training.TrainingTitle)
                {
                    Training.TrainingTitle = value;
                    RaisePropertyChanged("TrainingTitle");
                }
            }
        }

        public Guid Id
        {
            get
            {
                return Training.Id;
            }

            set
            {
                if (value != Training.Id)
                {
                    Training.Id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        public BindingList<Question> Questions
        {
            get
            {
                return Training.Questions;
            }

            set
            {
                if (value != Training.Questions) 
                {
                    Training.Questions = value;
                    RaisePropertyChanged("Questions");
                }
            }
        }

        public void SetUpViewModel(Training training)
        {
            this.Training = training;
        }

        public void EditQuestion(Question question)
        {
            AddEditQuestionForm questionForm = new AddEditQuestionForm(question);
            FormManager.LocalizedFormList.Add(questionForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            questionForm.ShowDialog();
        }

        public void AddQuestion(Training training)
        {
            AddEditQuestionForm questionForm = new AddEditQuestionForm();
            FormManager.LocalizedFormList.Add(questionForm);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            questionForm.ShowDialog();
            questionForm.Question.Training = training;
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

        public void Save()
        {
            if (this.Training != null)
            {
                if (this.Training.Id == Guid.Empty)
                {
                    var savedTraining = ServicesHolder.ServiceClient.SaveTraining(Conversion.ConvertTrainingToDTO(this.Training));
                    this.Training = Conversion.ConvertTrainingFromDTO(savedTraining);
                    this.Id = savedTraining.Id;
                }
                else
                {
                    ServicesHolder.ServiceClient.UpdateTraining(Conversion.ConvertTrainingToDTO(this.Training));
                }
            }
        }
        
        public void LoadQuestions()
        {
            // TODO: implement loading of questions from external source
            XtraMessageBox.Show("Load questions");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
