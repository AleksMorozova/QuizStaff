using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Training
    {
        public String TrainingTitle { get; set; }
        public List<Question> Questions {get;set;}

        public Training(string trainingtitle)
        {
            this.TrainingTitle = trainingtitle;
            this.Questions = new List<Question>();
        }
    }
}
