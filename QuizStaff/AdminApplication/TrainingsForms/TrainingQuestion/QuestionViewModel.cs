using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApplication.TrainingsForms.TrainingQuestion
{
    public delegate void QuestionChangedEventHandler(object sender, EventArgs e);

    public class QuestionViewModel
    {
        public Question Question { get; set; }

        public string QuestionText
        {
            get
            {
                return Question.QuestionText;
            }
            set
            {
                if (value != Question.QuestionText)
                {
                    Question.QuestionText = value;
                    RaisePropertyChanged("QuestionText");
                }
            }
        }

        public BindingList<Answer> Answers
        {
            get
            {
                return Question.Answers;
            }
            set
            {
                if (value != Question.Answers)
                {
                    Question.Answers = value;
                    RaisePropertyChanged("Answers");
                }
            }
        }

        public void SetUpViewModel(Question question)
        {
            this.Question = question;
        }

        public void DeleteAnswer(Answer deletedAnswer) 
        {
            if (deletedAnswer != null)
            {
                deletedAnswer.IsActive = false;
                ServicesHolder.ServiceClient.UpdateAnswer(Conversion.ConvertAnswerToDTO(deletedAnswer));
                Question.Answers.Remove(deletedAnswer);

                OnQuestionChanged(EventArgs.Empty);
            }
        }

        public void AddAnswer(Answer addAnswer)
        {
            if (addAnswer != null)
            {
                Question.Answers.Add(addAnswer);
                OnQuestionChanged(EventArgs.Empty);
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
        
        public event QuestionChangedEventHandler QuestionsListChanged;
        protected virtual void OnQuestionChanged(EventArgs e)
        {
            if (QuestionsListChanged != null)
                QuestionsListChanged(this, e);
        }
    }
}
