using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteeApplication.TesteeSettings
{
    public class TesteeSettingsViewModel : INotifyPropertyChanged 
    {
        private Setting LoadSetting { get; set; }

        private Setting userSetting;
        public Setting UserSetting
        {
            get
            {
                return userSetting;
            }
            set
            {
                if (value != userSetting)
                {
                    userSetting = value;
                    RaisePropertyChanged("AmountOfQuestionsPerDay");
                    RaisePropertyChanged("FrequencyOfAsking");
                    RaisePropertyChanged("TimeOfStart");
                }
            }
        }

        #region Setting

        public int AmountOfQuestionsPerDay
        {
            get
            {
                return UserSetting.AmountOfQuestionsPerDay;
            }
            set
            {
                if (value != UserSetting.AmountOfQuestionsPerDay)
                {
                    UserSetting.AmountOfQuestionsPerDay = value;
                    RaisePropertyChanged("AmountOfQuestionsPerDay");
                }
            }
        }

        public int FrequencyOfAsking
        {
            get
            {
                return UserSetting.FrequencyOfAsking;
            }
            set
            {
                if (value != UserSetting.FrequencyOfAsking)
                {
                    UserSetting.FrequencyOfAsking = value;
                    RaisePropertyChanged("FrequencyOfAsking");
                }
            }
        }

        public DateTime TimeOfStart
        {
            get
            {
                return UserSetting.TimeOfStart;
            }
            set
            {
                if (value != UserSetting.TimeOfStart)
                {
                    UserSetting.TimeOfStart = value;
                    RaisePropertyChanged("TimeOfStart");
                }
            }
        }

        #endregion

        public TesteeSettingsViewModel()
        {
            UserSetting = Program.currentTestee.UserSetting;
            LoadSetting = Conversion.CopySetting(UserSetting);
        }

        public void Save()
        {
            ServicesHolder.ServiceClient.UpdateTestee(Program.currentTestee);
        }

        public void Cancel()
        {
            UserSetting = Conversion.CopySetting(LoadSetting);
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
    }
}
