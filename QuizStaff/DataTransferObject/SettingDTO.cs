using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class SettingDTO
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
                }
            }
        }

        public bool CanUserEdit { get; set; }

        public bool ShowCorrectAnswer { get; set; }

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RecurrenceType Recurrence { get; set; }

        public static implicit operator SettingDTO(Setting setting)
        {
            SettingDTO newSetting = new SettingDTO();

            newSetting.Id = setting.Id;
            newSetting.Hours = setting.Hours;
            newSetting.Minutes = setting.Minutes;
            newSetting.Seconds = setting.Seconds;
            newSetting.StartDate = setting.TimeOfStart;
            newSetting.EndDate = setting.TimeOfStart;
            newSetting.Recurrence = setting.Recurrence;

            newSetting.AmountOfQuestionsPerDay = setting.AmountOfQuestionsPerDay;
            newSetting.TimeOfStart = setting.TimeOfStart;
            newSetting.CanUserEdit = setting.CanUserEdit;
            newSetting.ShowCorrectAnswer = setting.ShowCorrectAnswer;

            return newSetting;
        }
    }
}
