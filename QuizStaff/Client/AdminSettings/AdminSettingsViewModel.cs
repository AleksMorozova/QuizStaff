using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.AdminSettings
{
    public class AdminSettingsViewModel
    {
        public BindingList<TesteeDTO> Testees { get; set; }

        public int AmountOfQuestionsPerDay { get; set; }

        public int FrequencyOfAsking { get; set; }

        public DateTime TimeOfStart { get; set; }

        public void GetAllTestees()
        {
            Testees = new BindingList<TesteeDTO>();
            var testeeList = ServicesHolder.ServiceClient.GetAllTestees();
            foreach (var testee in testeeList)
            {
                Testees.Add(testee);
                FrequencyOfAsking = testee.UserSetting.FrequencyOfAsking;
                TimeOfStart = testee.UserSetting.TimeOfStart;
            }

            var t = Testees.GroupBy(_=>_.UserSetting.AmountOfQuestionsPerDay);
            if (t.Count()==1)
            {
                AmountOfQuestionsPerDay = t.First().First().UserSetting.AmountOfQuestionsPerDay;
            }

            var t1 = Testees.GroupBy(_ => _.UserSetting.FrequencyOfAsking);
            if (t.Count() == 1)
            {
                FrequencyOfAsking = t.First().First().UserSetting.FrequencyOfAsking;
            }

            var t2 = Testees.GroupBy(_ => _.UserSetting.TimeOfStart);
            if (t.Count() == 1)
            {
                TimeOfStart = t.First().First().UserSetting.TimeOfStart;
            }
        }
    }
}
