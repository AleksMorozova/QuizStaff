using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.TesteeSettings
{
    public class TesteeSettingsViewModel
    {
        public Setting UserSetting  { get; set; }
        
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
                }
            }
        }

        #endregion

        public TesteeSettingsViewModel()
        {
            UserSetting = Program.СurrentTestee.UserSetting;
        }

        public void Save(Testee testee)
        {
            if (testee != null)
            {
                ServicesHolder.ServiceClient.UpdateTestee(testee);
            }
        }        
    }
}
