using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ApplicationSettingsDTO
    {
        public Guid Id { get; set; }
        public virtual BindingList<DaysOfUpdateDTO> Days { get; set; }
        public DateTime TimeOfUpdating { get; set; }
        public string LMSReportFileName { get; set; }
        public string LMSReportPath { get; set; }
        public string TrainingsQuestionsPath { get; set; }
        public string AdditionalQuestionsPath { get; set; }
    }
}
