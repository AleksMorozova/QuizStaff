using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class UserAnswers
    {
        public List< Answer> Answer { get; set; }
        public UserAnswers ()
        {
            Answer = new List<Answer>();
        }
    }
}
