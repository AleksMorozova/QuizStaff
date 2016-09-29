using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataFromLMS
{
    public class LoadedQuestion
    {
        public string Question { get; set; }
        public List<LoadedAnswer> Answers { get; set; }
    }
}
