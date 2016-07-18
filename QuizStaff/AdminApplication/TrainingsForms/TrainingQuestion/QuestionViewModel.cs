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

        public void DeleteAnswer(Answer deleteAnswer) 
        {
            if(deleteAnswer != null)
                deleteAnswer.IsActive = false;
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
