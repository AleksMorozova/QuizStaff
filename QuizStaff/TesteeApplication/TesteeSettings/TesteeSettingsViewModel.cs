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
        public delegate void SettingsChangedEventHandler(object sender, EventArgs e);

        public TesteeSettingsViewModel()
        {
            LoadSetting = Conversion.CopySetting(Program.СurrentTestee.UserSetting);
        }

        #region Setting
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
       
        public int AmountOfQuestionsPerDay
        {
            get
            {
                return Program.СurrentTestee.UserSetting.AmountOfQuestionsPerDay;
            }
            set
            {
                if (value != Program.СurrentTestee.UserSetting.AmountOfQuestionsPerDay)
                {
                    Program.СurrentTestee.UserSetting.AmountOfQuestionsPerDay = value;
                    RaisePropertyChanged("AmountOfQuestionsPerDay");
                }
            }
        }

        public int Hours
        {
            get
            {
                return Program.СurrentTestee.UserSetting.Hours;
            }
            set
            {
                if (value != Program.СurrentTestee.UserSetting.Hours)
                {
                    Program.СurrentTestee.UserSetting.Hours = value;
                    RaisePropertyChanged("Hours");
                }
            }
        }

        public int Minutes
        {
            get
            {
                return Program.СurrentTestee.UserSetting.Minutes;
            }
            set
            {
                if (value != Program.СurrentTestee.UserSetting.Minutes)
                {
                    Program.СurrentTestee.UserSetting.Minutes = value;
                    RaisePropertyChanged("Minutes");
                }
            }
        }

        public int Seconds
        {
            get
            {
                return Program.СurrentTestee.UserSetting.Seconds;
            }
            set
            {
                if (value != Program.СurrentTestee.UserSetting.Seconds)
                {
                    Program.СurrentTestee.UserSetting.Seconds = value;
                    RaisePropertyChanged("Seconds");
                }
            }
        }

        public DateTime TimeOfStart
        {
            get
            {
                return Program.СurrentTestee.UserSetting.TimeOfStart;
            }
            set
            {
                if (value != Program.СurrentTestee.UserSetting.TimeOfStart)
                {
                    Program.СurrentTestee.UserSetting.TimeOfStart = value;
                    RaisePropertyChanged("TimeOfStart");
                }
            }
        }

        public DateTime EndDate
        {
            get
            {
                return Program.СurrentTestee.UserSetting.EndDate;
            }
            set
            {
                if (value != Program.СurrentTestee.UserSetting.EndDate)
                {
                    Program.СurrentTestee.UserSetting.EndDate = value;
                    RaisePropertyChanged("EndDate");
                }
            }
        }

        public RecurrenceType Recurrence
        {
            get
            {
                return Program.СurrentTestee.UserSetting.Recurrence;
            }
            set
            {
                if (value != Program.СurrentTestee.UserSetting.Recurrence)
                {
                    Program.СurrentTestee.UserSetting.Recurrence = value;
                    RaisePropertyChanged("Recurrence");
                }
            }
        }
        #endregion

        public void Save()
        {
            ServicesHolder.ServiceClient.UpdateTestee(Program.СurrentTestee);
        }

        public void Cancel()
        {
            //if (LoadSetting != null)
            //{
            //    Program.СurrentTestee.UserSetting = Conversion.CopySetting(LoadSetting);
            //    OnSetingsChanged(EventArgs.Empty);
            //}
        }

        public event SettingsChangedEventHandler SetingsChanged;
        protected virtual void OnSetingsChanged(EventArgs e)
        {
            if (SetingsChanged != null)
                SetingsChanged(this, e);
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
