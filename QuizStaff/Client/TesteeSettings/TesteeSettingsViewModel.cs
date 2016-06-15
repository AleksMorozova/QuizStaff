using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TesteeSettings
{
    public class TesteeSettingsViewModel
    {
        public Setting UserSetting;

        public void SetUpSetting() 
        {
            UserSetting = Program.currentTestee.UserSetting;
        }
    }
}
