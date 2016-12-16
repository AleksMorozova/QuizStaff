using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class DaysOfUpdate : Entity
    {
        public DayOfWeek Day { get; set; }
        public ApplicationSettings Settings { get; set; }
        public bool IsSelect { get; set; }
    }
}
