using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Setting : Entity, INotifyPropertyChanged
    {
        public int amountOfQuestionsPerDay;
        public int AmountOfQuestionsPerDay
        {
            get
            {
                return amountOfQuestionsPerDay;
            }
            set
            {
                if (value != amountOfQuestionsPerDay)
                {
                    amountOfQuestionsPerDay = value;
                    OnPropertyChanged("AmountOfQuestionsPerDay");
                }
            }
        }

        public int frequencyOfAsking;
        public int FrequencyOfAsking
        {
            get
            {
                return frequencyOfAsking;
            }
            set
            {
                if (value != frequencyOfAsking)
                {
                    frequencyOfAsking = value;
                    OnPropertyChanged("FrequencyOfAsking");
                }
            }
        }

        public DateTime TimeOfStart { get; set; }

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
