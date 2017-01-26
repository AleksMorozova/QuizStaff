using AdminApplication.TrainingsForms.TrainingQuestion;
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

namespace AdminApplication.TrainingsForms.TrainingAddEdit
{
    public delegate void TrainingChangedEventHandler(object sender, EventArgs e);

    public class TrainingViewModel : INotifyPropertyChanged 
    {
        private Training LoadTraining { get; set; }

        private Training training;
        public Training Training
        {
            get
            {
                return training;
            }

            set
            {
                if (value != training)
                {
                    training = value;
                    RaisePropertyChanged("Training");
                    RaisePropertyChanged("TrainingTitle");
                    RaisePropertyChanged("Questions");
                }
            }
        }

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
            LoadTraining = Conversion.CopyTraining(training);
        }

        public void EditQuestion(Question question)
        {
            AddEditQuestionForm questionForm = new AddEditQuestionForm(question);
            FormManager.LocalizedFormList.Add(questionForm);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
            questionForm.ShowDialog();
        }

        public void AddQuestion(Training training)
        {
            AddEditQuestionForm questionForm = new AddEditQuestionForm();
            FormManager.LocalizedFormList.Add(questionForm);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
            questionForm.ShowDialog();
            questionForm.Question.Training = training;
            Training.Questions.Add(questionForm.Question);
        }

        public void DeleteQuestion(Question deletedQuestion)
        {
            if (deletedQuestion != null) 
            {
                if (deletedQuestion.Id != Guid.Empty)
                {
                    deletedQuestion.IsActive = false;

                    ServicesHolder.ServiceClient.SaveQuestion(deletedQuestion);
                }

                this.Training.Questions.Remove(deletedQuestion);
                OnTrainingChanged(EventArgs.Empty);
            }  
        }

        public void Cancel()
        {
            this.Training = Conversion.CopyTraining(LoadTraining);
        }

        public void Save()
        {
            if (this.Training != null)
            {
                var savedTraining = ServicesHolder.ServiceClient.SaveTraining(Conversion.ConvertTrainingToDTO(this.Training));
                this.Training = Conversion.ConvertTrainingFromDTO(savedTraining);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public event TrainingChangedEventHandler QuestionsListChanged;
        protected virtual void OnTrainingChanged(EventArgs e)
        {
            if (QuestionsListChanged != null)
                QuestionsListChanged(this, e);
        }
    }
}
