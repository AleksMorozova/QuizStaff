using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class AnswerDTO : INotifyPropertyChanged
    {
        public Guid Id { get; set; }

        private string answerText;
        public string AnswerText 
        { 
            get { return answerText; }
            set 
            {
                if (value != answerText)
                {
                    answerText = value;
                    OnPropertyChanged("AnswerText");
                }
            }
        }
        public bool IsCorrect { get; set; }

        public static implicit operator AnswerDTO(Answer answer)
        {
            AnswerDTO newAnswer = new AnswerDTO();
            Conversion.CopyProperty(answer, newAnswer);
            return newAnswer;
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
