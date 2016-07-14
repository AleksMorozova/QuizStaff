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
            else 
            {
                Setting.TimeOfStart = System.DateTime.Today.AddHours(11);
            }
        }
        
        public void Save()
        {
            List<SettingDTO> savedSettings = new List<SettingDTO>();

            if (this.Setting != null)
            {
                foreach (Testee testee in SelectedTestees)
                {
                    testee.UserSetting.AmountOfQuestionsPerDay = this.Setting.AmountOfQuestionsPerDay;
                    testee.UserSetting.FrequencyOfAsking = this.Setting.FrequencyOfAsking;
                    testee.UserSetting.CanUserEdit = this.Setting.CanUserEdit;
                    testee.UserSetting.ShowCorrectAnswer = this.Setting.ShowCorrectAnswer;
                    testee.UserSetting.TimeOfStart = this.Setting.TimeOfStart;

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
