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
        public TesteeSettingsViewModel()
        {
            UserSetting = Program.currentTestee.UserSetting;
            LoadSetting = Conversion.CopySetting(UserSetting);
        }

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
                    RaisePropertyChanged("Minutes");
                    RaisePropertyChanged("Hours");
                    RaisePropertyChanged("Seconds");
                    RaisePropertyChanged("TimeOfStart");
                    RaisePropertyChanged("EndDate");
                    RaisePropertyChanged("Recurrence");
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

        public int Hours
        {
            get
            {
                return UserSetting.Hours;
            }
            set
            {
                if (value != UserSetting.Hours)
                {
                    UserSetting.Hours = value;
                    RaisePropertyChanged("Hours");
                }
            }
        }

        public int Minutes
        {
            get
            {
                return UserSetting.Minutes;
            }
            set
            {
                if (value != UserSetting.Minutes)
                {
                    UserSetting.Minutes = value;
                    RaisePropertyChanged("Minutes");
                }
            }
        }

        public int Seconds
        {
            get
            {
                return UserSetting.Seconds;
            }
            set
            {
                if (value != UserSetting.Seconds)
                {
                    UserSetting.Seconds = value;
                    RaisePropertyChanged("Seconds");
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

        public DateTime EndDate
        {
            get
            {
                return UserSetting.EndDate;
            }
            set
            {
                if (value != UserSetting.EndDate)
                {
                    UserSetting.EndDate = value;
                    RaisePropertyChanged("EndDate");
                }
            }
        }

        public RecurrenceType Recurrence
        {
            get
            {
                return UserSetting.Recurrence;
            }
            set
            {
                if (value != UserSetting.Recurrence)
                {
                    UserSetting.Recurrence = value;
                    RaisePropertyChanged("Recurrence");
                }
            }
        }
        #endregion

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
