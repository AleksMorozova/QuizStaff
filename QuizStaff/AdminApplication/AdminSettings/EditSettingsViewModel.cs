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

        public int FrequencyOfAsking
        {
            get
            {
                return Setting.FrequencyOfAsking;
            }
            set
            {
                if (value != Setting.FrequencyOfAsking)
                {
                    Setting.FrequencyOfAsking = value;
                    RaisePropertyChanged("FrequencyOfAsking");
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
        
        public void SetUpSettings(BindingList<Testee> currentTestees)
        {
            SelectedTestees = currentTestees;
            Setting = new Setting();

            var t = currentTestees.GroupBy(_ => _.UserSetting.AmountOfQuestionsPerDay);
            if (t.Count() == 1)
            {
                Setting.AmountOfQuestionsPerDay = t.First().First().UserSetting.AmountOfQuestionsPerDay;
            }

            var t1 = currentTestees.GroupBy(_ => _.UserSetting.FrequencyOfAsking);
            if (t1.Count() == 1)
            {
                Setting.FrequencyOfAsking = t.First().First().UserSetting.FrequencyOfAsking;
            }

            var t2 = currentTestees.GroupBy(_ => _.UserSetting.TimeOfStart);
            if (t2.Count() == 1)
            {
                Setting.TimeOfStart = t.First().First().UserSetting.TimeOfStart;
            }
        }
        
        public void Save()
        {
            if (this.Setting != null)
            {
                SettingDTO s = this.Setting;
                foreach (Testee testee in SelectedTestees)
                {
                    s.Id = testee.UserSetting.Id;
                    ServicesHolder.ServiceClient.UpdateSettings(s);
                }
            }
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
