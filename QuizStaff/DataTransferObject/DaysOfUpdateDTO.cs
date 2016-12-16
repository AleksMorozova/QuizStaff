using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DaysOfUpdateDTO
    {
        public Guid Id { get; set; }
        public DayOfWeek Day { get; set; }
        public ApplicationSettingsDTO Settings { get; set; }
        public bool IsSelect { get; set; }
    }
}
