using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Setting : Entity
    {
        public int AmountOfQuestionsPerDay { get; set; }
        public int Hours { get; set; }  
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RecurrenceType Recurrence { get; set; }

        public DateTime TimeOfStart { get; set; }
        public bool CanUserEdit { get; set; }
        public bool ShowCorrectAnswer { get; set; }
    }
}
