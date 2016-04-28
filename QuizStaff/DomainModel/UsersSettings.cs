using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class UsersSettings
    {
        public int AmountOfQuestionsPerDay { get; set; }
        public DateTime FrequencyOfAsking { get; set; }
        public UsersSettings(int amountofq , DateTime freq)
        {
            AmountOfQuestionsPerDay = amountofq;
            FrequencyOfAsking = freq;
        }
    }
}
