using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Training : Entity, INotifyPropertyChanged
    {
        private string trainingTitle;
        public string TrainingTitle
        {
            get
            {
                return trainingTitle;
            }
            set
            {
                if (value != trainingTitle)
                {
                    trainingTitle = value;
                    OnPropertyChanged("TrainingTitle");
                }
            }
        }

        public bool IsActive { get; set; }
       
        private BindingList<Question> questions;
        public virtual BindingList<Question> Questions
        {
            get
            {
                return questions;
            }
            set
            {
                questions = value;
            }
        }

        public virtual BindingList<TesteeTraining> TesteeTrainings { get; set; }

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
