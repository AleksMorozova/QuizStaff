using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class QuestionDTO : INotifyPropertyChanged
    {
        public QuestionDTO() 
        {
            Answers = new BindingList<AnswerDTO>();
        }
        public Guid Id { get; set; }
        public Guid TrainingId { get; set; }

        private string questionText;
        public string QuestionText { 
            get 
            { 
                return questionText;
            }
            set 
            {
                if (value != questionText)
                {
                    questionText = value;
                    OnPropertyChanged("QuestionText");
                }   
            }
        }

        public virtual TrainingDTO Training { get; set; }
        public virtual BindingList<AnswerDTO> Answers { get; set; }

        public static implicit operator QuestionDTO(Question question)
        {
            QuestionDTO newQuestion = new QuestionDTO();
            Conversion.CopyProperty(question, newQuestion);
            foreach (var a in question.Answers)
            {
                newQuestion.Answers.Add((AnswerDTO)a);
            }
            return newQuestion;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
