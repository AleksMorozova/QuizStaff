using DataTransferObject;
using DevExpress.Mvvm;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;

namespace Client.AdminSettings
{
    public class AdminSettingsViewModel:  ViewModelBase
    {
        public BindingList<Testee> Testees { get; set; }

        private Setting setting = new Setting();
        public virtual Setting Setting { get; set; }

        public void SetUpSettings(BindingList<Testee> currentTestees)
        {
            Setting = new Setting();

            var t = currentTestees.GroupBy(_ => _.UserSetting.AmountOfQuestionsPerDay);
            if (t.Count() == 1)
            {
                Setting.AmountOfQuestionsPerDay = t.First().First().UserSetting.AmountOfQuestionsPerDay;
            }

            var t1 = currentTestees.GroupBy(_ => _.UserSetting.FrequencyOfAsking);
            if (t.Count() == 1)
            {
                Setting.FrequencyOfAsking = t.First().First().UserSetting.FrequencyOfAsking;
            }

            var t2 = currentTestees.GroupBy(_ => _.UserSetting.TimeOfStart);
            if (t.Count() == 1)
            {
                Setting.TimeOfStart = t.First().First().UserSetting.TimeOfStart;
            }
        }

        public void GetAllTestees()
        {
            Testees = new BindingList<Testee>();
            var testeeList = ServicesHolder.ServiceClient.GetAllTestees();

            foreach (var testee in testeeList)
            {
                Testees.Add(Conversion.ConvertTesteeFromDTO(testee));
            }
        }

        public void EditSettings(BindingList<Testee> selectedTestee) 
        {
            EditSettingsForm editSettings = new EditSettingsForm(selectedTestee);
            FormManager.childForms.Add(editSettings);
            FormManager.Instance.LocalizedForms(Program.currentLang);
            editSettings.ShowDialog();
        }

        public void Save(BindingList<Testee> selectedTestee)
        {                
            // TODO: set to all users new settings
            if (this.Setting != null)
            {
                SettingDTO s = this.Setting;
                foreach (Testee testee in selectedTestee)
                {
                    s.Id = testee.UserSetting.Id;
                    ServicesHolder.ServiceClient.UpdateSettings(s);
                }
            }
        }
    }
}
