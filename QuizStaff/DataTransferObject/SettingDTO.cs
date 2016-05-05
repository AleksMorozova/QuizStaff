using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    class SettingDTO
    {
        public Guid Id { get; set; }
        public int AmountOfQuestionsPerDay { get; set; }
        public int FrequencyOfAsking { get; set; }
        public DateTime TimeOfStart { get; set; }

        public static implicit operator SettingDTO(Setting setting)
        {
            SettingDTO newSetting = new SettingDTO();
            Conversion.CopyProperty(setting, newSetting);
            return newSetting;
        }
    }
}
