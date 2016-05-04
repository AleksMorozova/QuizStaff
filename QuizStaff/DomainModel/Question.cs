using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [DataContract]
    public class Question : Entity
    {
        public Question()
        {
        }

        public Guid TrainingId { get; set; }
        public string QuestionText { get; set; }
        public virtual Training Training { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
