using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.AdminSettings
{
    public class EditSettingsViewModel
    {
        public BindingList<Testee> SelectedTestees { get; set; }

        public Setting Setting {get; set; }

        public int AmountOfQuestionsPerDay
        {
            get
            {
                return Setting.AmountOfQuestionsPerDay;
            }
            set
            {
                if (value != Setting.AmountOfQuestionsPerDay)
                {
                    Setting.AmountOfQuestionsPerDay = value;
                    RaisePropertyChanged("AmountOfQuestionsPerDay");
                }
            }
        }

        public int Hours
        {
            get
            {
                return Setting.Hours;
            }
            set
            {
                if (value != Setting.Hours)
                {
                    Setting.Hours = value;
                    RaisePropertyChanged("Hours");
                }
            }
        }
        
        public int Minutes
        {
            get
            {
                return Setting.Minutes;
            }
            set
            {
                if (value != Setting.Minutes)
                {
                    Setting.Minutes = value;
                    RaisePropertyChanged("Minutes");
                }
            }
        }

        public int Seconds
        {
            get
            {
                return Setting.Seconds;
            }
            set
            {
                if (value != Setting.Seconds)
                {
                    Setting.Seconds = value;
                    RaisePropertyChanged("Seconds");
                }
            }
        }

        public DateTime TimeOfStart
        {
            get
            {
                return Setting.TimeOfStart;
            }
            set
            {
                if (value != Setting.TimeOfStart)
                {
                    Setting.TimeOfStart = value;
                    RaisePropertyChanged("TimeOfStart");
                }
            }
        }

        public DateTime EndDate
        {
            get
            {
                return Setting.EndDate;
            }
            set
            {
                if (value != Setting.EndDate)
                {
                    Setting.EndDate = value;
                    RaisePropertyChanged("EndDate");
                }
            }
        }

        public bool CanUserEdit
        {
            get
            {
                return Setting.CanUserEdit;
            }
            set
            {
                if (value != Setting.CanUserEdit)
                {
                    Setting.CanUserEdit = value;
                    RaisePropertyChanged("CanUserEdit");
                }
            }
        }

        public bool ShowCorrectAnswer
        {
            get
            {
                return Setting.ShowCorrectAnswer;
            }
            set
            {
                if (value != Setting.ShowCorrectAnswer)
                {
                    Setting.ShowCorrectAnswer = value;
                    RaisePropertyChanged("ShowCorrectAnswer");
                }
            }
        }

        public RecurrenceType Recurrence
        {
            get
            {
                return Setting.Recurrence;
            }
            set
            {
                if (value != Setting.Recurrence)
                {
                    Setting.Recurrence = value;
                    RaisePropertyChanged("Recurrence");
                }
            }
        }

        public void SetUpSettings(BindingList<Testee> currentTestees)
        {
            SelectedTestees = currentTestees;
            Setting = new Setting();

            Setting.AmountOfQuestionsPerDay =
                (currentTestees.GroupBy(_ => _.UserSetting.AmountOfQuestionsPerDay).Count()==1)
                ? currentTestees.First().UserSetting.AmountOfQuestionsPerDay
                : 0;

            Setting.Hours =
                (currentTestees.GroupBy(_ => _.UserSetting.Hours).Count() == 1)
                ? currentTestees.First().UserSetting.Hours
                : 0;

            Setting.Minutes =
                (currentTestees.GroupBy(_ => _.UserSetting.Minutes).Count() == 1)
                ? currentTestees.First().UserSetting.Minutes
                : 0;

            Setting.Seconds =
                (currentTestees.GroupBy(_ => _.UserSetting.Seconds).Count() == 1)
                ? currentTestees.First().UserSetting.Seconds
                : 0;

            Setting.TimeOfStart =
                (currentTestees.GroupBy(_ => _.UserSetting.TimeOfStart).Count() == 1)
                ? currentTestees.First().UserSetting.TimeOfStart
                : System.DateTime.Now;

            Setting.EndDate =
                (currentTestees.GroupBy(_ => _.UserSetting.EndDate).Count() == 1)
                ? currentTestees.First().UserSetting.EndDate
                : System.DateTime.Today.AddHours(11);

            Setting.Recurrence =
                (currentTestees.GroupBy(_ => _.UserSetting.Recurrence).Count() == 1)
                ? currentTestees.First().UserSetting.Recurrence
                : RecurrenceType.WithExactRepeated;
        }
        
        public void Save()
        {
            List<SettingDTO> savedSettings = new List<SettingDTO>();

            if (this.Setting != null)
            {
                foreach (Testee testee in SelectedTestees)
                {                   
                    testee.UserSetting.CanUserEdit = this.Setting.CanUserEdit;
                    testee.UserSetting.ShowCorrectAnswer = this.Setting.ShowCorrectAnswer;
                    testee.UserSetting.Hours = this.Setting.Hours;
                    testee.UserSetting.Minutes = this.Setting.Minutes;
                    testee.UserSetting.Seconds = this.Setting.Seconds;
                    testee.UserSetting.TimeOfStart = this.Setting.TimeOfStart;   
                    testee.UserSetting.AmountOfQuestionsPerDay = this.Setting.AmountOfQuestionsPerDay;
                    testee.UserSetting.EndDate = (this.Setting.EndDate != DateTime.MinValue) ? this.Setting.EndDate : DateTime.MaxValue;
                    testee.UserSetting.Recurrence = this.Setting.Recurrence;

                    savedSettings.Add(testee.UserSetting);
                }
            }

            ServicesHolder.ServiceClient.UpdateSettings(savedSettings.ToArray());
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
