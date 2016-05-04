using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [DataContract]
    public class Answer: Entity
    {
        public Answer()
        {
        }

        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }
}
