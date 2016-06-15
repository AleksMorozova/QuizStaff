using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Question : Entity, INotifyPropertyChanged
    {
        public Question() 
        {
            answers = new BindingList<Answer>();
        }

        public Guid TrainingId { get; set; }
     
        public bool IsActive { get; set; }

        public virtual Training Training { get; set; }
        
        private string questionText;
        public string QuestionText
        {
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

        private BindingList<Answer> answers;
        public virtual BindingList<Answer> Answers
        {
            get
            {
                return answers;
            }
            set
            {
                if (value != answers)
                {
                    answers = value;
                    OnPropertyChanged("Answers");
                }
            }
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
