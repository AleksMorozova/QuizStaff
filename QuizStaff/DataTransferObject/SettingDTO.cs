using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class SettingDTO : INotifyPropertyChanged
    {
        public Guid Id { get; set; }

        private int amountOfQuestionsPerDay;
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

        private int frequencyOfAsking;
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

        private DateTime timeOfStart;
        public DateTime TimeOfStart
        {
            get
            {
                return timeOfStart;
            }
            set
            {
                if (value != timeOfStart)
                {
                    timeOfStart = value;
                    OnPropertyChanged("TimeOfStart");
                }
            }
        }

        public static implicit operator SettingDTO(Setting setting)
        {
            SettingDTO newSetting = new SettingDTO();
            Conversion.CopyProperty(setting, newSetting);
            return newSetting;
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
