using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Setting : Entity
    {
        public Setting()
        {
        }

        public int AmountOfQuestionsPerDay { get; set; }
        public int FrequencyOfAsking { get; set; }
        public DateTime TimeOfStart { get; set; }
    }
}
