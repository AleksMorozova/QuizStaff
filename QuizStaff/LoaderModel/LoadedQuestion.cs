using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaderModel
{
    public class LoadedQuestion
    {
        public string Training { get; set; }
        public string Question { get; set; }
        public List<LoadedAnswer> Answers { get; set; }
    }
}
