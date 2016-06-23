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

        public void SetUpSetting() 
        {
            UserSetting = Program.currentTestee.UserSetting;
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
